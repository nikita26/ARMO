using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using Microsoft.Win32;

namespace ARMO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Task> tasks = new List<Task>();
        int fileNum = 0;
        bool work = true;
        bool pauseTimer = false;
        Thread workingThread = null;
        Task task;

        private void SearchByDirectory(string path, string patternName, string textFile)        //Функция поиска .txt файлов с указанными параметрами
        {
            Console.Clear();
            workingThread = Thread.CurrentThread;
            DirectoryInfo dirinfo = new DirectoryInfo(path);
            try
            {

                foreach (var file in dirinfo.GetFiles("*" + patternName + "*.txt", SearchOption.AllDirectories))
                {
                    Console.WriteLine(file.FullName);
                    fileNum++;                                          //Нумерация обрабатываемого файла
                    Invoke(new Action(() => {
                        toolStripNameFile.Text = file.FullName;
                        fileNumber.Text = fileNum.ToString();
                    }));

                    if (File.ReadAllText(file.FullName, Encoding.GetEncoding(1251)).Contains(textFile))     //Проверка на присуствии заданного текста в файле
                        Invoke(new Action(() => {
                            treeView1.Nodes.Add(new TreeNode(file.Name));
                        }));
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            Invoke(new Action(() => {
                workingThread.Abort();
                buttonPause.Enabled = false;
                buttonPause.Visible = false;
                buttonContinue.Enabled = false;
                buttonContinue.Visible = false;
                buttonCancel.Enabled = false;
                buttonCancel.Visible = false;
                work = false;
            }));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fileDialog = new FolderBrowserDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                startDirectory.Text = fileDialog.SelectedPath;
            }
        }

        private void search_Click(object sender, EventArgs e)       //Начало поиска
        {
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\ARMO"))   //Сохранение в реестр используемых параметров поиска
            {
                key.SetValue("startDirectory", startDirectory.Text);
                key.SetValue("patternName", patternName.Text);
                key.SetValue("textInFile", textInFile.Text);
            }
            treeView1.Nodes.Clear();
            task = new Task(()=>SearchByDirectory(startDirectory.Text, patternName.Text, textInFile.Text));
            task.Start();

            DateTime time = new DateTime(0);
            pauseTimer = false;
            work = true;
            fileNum = 0;
            Task tasktimer = new Task(() => {           //Поток с таймером от начала поиска
                while (work)
                {
                    Thread.Sleep(1000);
                    if (!pauseTimer)
                        time = time.AddSeconds(1);
                    Invoke(new Action(() => {
                        timer.Text = time.ToLongTimeString();
                    }));
                }
            });
            tasktimer.Start();

            buttonCancel.Enabled = true;
            buttonCancel.Visible = true;
            buttonPause.Enabled = true;
            buttonPause.Visible = true;
            fileNumber.Text = null;
            toolStripNameFile.Text = null;

        }

        private void buttonCancel_Click(object sender, EventArgs e)     //Отмена поиска
        {
            if (workingThread.ThreadState.ToString().Contains(System.Threading.ThreadState.Suspended.ToString()))
            {
                workingThread.Resume();
            }
            workingThread.Abort();
            work = false;

            buttonPause.Enabled = false;
            buttonPause.Visible = false;
            buttonContinue.Enabled = false;
            buttonContinue.Visible = false;
            buttonCancel.Enabled = false;
            buttonCancel.Visible = false;
        }

        private void buttonPause_Click(object sender, EventArgs e)      //Приостановка поиска
        {
            workingThread.Suspend();
            pauseTimer = true;

            buttonPause.Enabled = false;
            buttonPause.Visible = false;
            buttonContinue.Enabled = true;
            buttonContinue.Visible = true;
        }

        private void buttonContinue_Click(object sender, EventArgs e)       //Продолжение поиска
        {
            workingThread.Resume();
            pauseTimer = false;

            buttonContinue.Enabled = false;
            buttonContinue.Visible = false;
            buttonPause.Enabled = true;
            buttonPause.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\ARMO"))   //Загрузка параметров поиска при их наличии в реестре
            {
                startDirectory.Text = key?.GetValue("startDirectory")?.ToString();
                patternName.Text = key?.GetValue("patternName")?.ToString();
                textInFile.Text = key?.GetValue("textInFile")?.ToString();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\ARMO"))   //Сохранение в реестр последних используемых параметров поиска
            {
                key.SetValue("startDirectory", startDirectory.Text);
                key.SetValue("patternName", patternName.Text);
                key.SetValue("textInFile", textInFile.Text);
            }

        }
    }
}

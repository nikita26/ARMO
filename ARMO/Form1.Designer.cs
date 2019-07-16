namespace ARMO
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.patternName = new System.Windows.Forms.TextBox();
            this.textInFile = new System.Windows.Forms.TextBox();
            this.startDirectory = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.search = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.timer = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.fileNumber = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripNameFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Стартовая директория";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Шаблон имени файла";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = " Текст, содержашийся в файле";
            // 
            // patternName
            // 
            this.patternName.Location = new System.Drawing.Point(349, 82);
            this.patternName.Name = "patternName";
            this.patternName.Size = new System.Drawing.Size(202, 20);
            this.patternName.TabIndex = 4;
            // 
            // textInFile
            // 
            this.textInFile.Location = new System.Drawing.Point(349, 135);
            this.textInFile.Name = "textInFile";
            this.textInFile.Size = new System.Drawing.Size(202, 20);
            this.textInFile.TabIndex = 5;
            // 
            // startDirectory
            // 
            this.startDirectory.Location = new System.Drawing.Point(349, 28);
            this.startDirectory.Name = "startDirectory";
            this.startDirectory.Size = new System.Drawing.Size(202, 20);
            this.startDirectory.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(557, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Обзор";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(331, 413);
            this.treeView1.TabIndex = 8;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(352, 162);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 9;
            this.search.Text = "Поиск";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timer,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel1,
            this.fileNumber,
            this.toolStripNameFile});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // timer
            // 
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(12, 17);
            this.timer.Text = "-";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(28, 17);
            this.toolStripStatusLabel2.Text = "сек.";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(52, 17);
            this.toolStripStatusLabel1.Text = "Файлов:";
            // 
            // fileNumber
            // 
            this.fileNumber.Name = "fileNumber";
            this.fileNumber.Size = new System.Drawing.Size(14, 17);
            this.fileNumber.Text = "#";
            // 
            // toolStripNameFile
            // 
            this.toolStripNameFile.Name = "toolStripNameFile";
            this.toolStripNameFile.Size = new System.Drawing.Size(12, 17);
            this.toolStripNameFile.Text = "-";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Enabled = false;
            this.buttonCancel.Location = new System.Drawing.Point(433, 162);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Visible = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.Enabled = false;
            this.buttonPause.Location = new System.Drawing.Point(384, 192);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(87, 23);
            this.buttonPause.TabIndex = 12;
            this.buttonPause.Text = "Пауза";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Visible = false;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonContinue
            // 
            this.buttonContinue.Enabled = false;
            this.buttonContinue.Location = new System.Drawing.Point(384, 192);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(87, 23);
            this.buttonContinue.TabIndex = 13;
            this.buttonContinue.Text = "Продолжить";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Visible = false;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.startDirectory);
            this.Controls.Add(this.textInFile);
            this.Controls.Add(this.patternName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox patternName;
        private System.Windows.Forms.TextBox textInFile;
        private System.Windows.Forms.TextBox startDirectory;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripNameFile;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.ToolStripStatusLabel timer;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel fileNumber;
    }
}


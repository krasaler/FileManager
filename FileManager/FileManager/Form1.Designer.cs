namespace FileManager
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel4 = new System.Windows.Forms.Panel();
            this.file1 = new FileManager.FileItems();
            this.panel3 = new System.Windows.Forms.Panel();
            this.drive1 = new FileManager.DriveSelect();
            this.panel5 = new System.Windows.Forms.Panel();
            this.file2 = new FileManager.FileItems();
            this.panel1 = new System.Windows.Forms.Panel();
            this.drive2 = new FileManager.DriveSelect();
            this.panel6 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navigateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hidenFilesOnofToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jumpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(733, 453);
            this.panel2.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.splitContainer1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 33);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(733, 420);
            this.panel7.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel4);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1MinSize = 50;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel5);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2MinSize = 50;
            this.splitContainer1.Size = new System.Drawing.Size(733, 420);
            this.splitContainer1.SplitterDistance = 367;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.file1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 23);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(367, 397);
            this.panel4.TabIndex = 3;
            // 
            // file1
            // 
            this.file1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.file1.Hiden = false;
            this.file1.Location = new System.Drawing.Point(0, 0);
            this.file1.Name = "file1";
            this.file1.path = "C:\\\\";
            this.file1.Size = new System.Drawing.Size(367, 397);
            this.file1.TabIndex = 0;
            this.file1.KeyItem += new FileManager.FileItems.KeyItemDelegate(this.fileItem_KeyItem);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.drive1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(367, 23);
            this.panel3.TabIndex = 2;
            // 
            // drive1
            // 
            this.drive1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drive1.Drive = "C:\\";
            this.drive1.Location = new System.Drawing.Point(0, 0);
            this.drive1.Name = "drive1";
            this.drive1.Size = new System.Drawing.Size(367, 23);
            this.drive1.TabIndex = 0;
            this.drive1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.file2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 23);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(362, 397);
            this.panel5.TabIndex = 2;
            // 
            // file2
            // 
            this.file2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.file2.Hiden = false;
            this.file2.Location = new System.Drawing.Point(0, 0);
            this.file2.Name = "file2";
            this.file2.path = "D:\\\\";
            this.file2.Size = new System.Drawing.Size(362, 397);
            this.file2.TabIndex = 0;
            this.file2.KeyItem += new FileManager.FileItems.KeyItemDelegate(this.fileItem_KeyItem);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.drive2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 23);
            this.panel1.TabIndex = 1;
            // 
            // drive2
            // 
            this.drive2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drive2.Drive = "C:\\";
            this.drive2.Location = new System.Drawing.Point(0, 0);
            this.drive2.Name = "drive2";
            this.drive2.Size = new System.Drawing.Size(362, 23);
            this.drive2.TabIndex = 0;
            this.drive2.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(733, 33);
            this.panel6.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.selectsToolStripMenuItem,
            this.navigateToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(733, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // selectsToolStripMenuItem
            // 
            this.selectsToolStripMenuItem.Name = "selectsToolStripMenuItem";
            this.selectsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.selectsToolStripMenuItem.Text = "Selects";
            // 
            // navigateToolStripMenuItem
            // 
            this.navigateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hidenFilesOnofToolStripMenuItem,
            this.jumpToolStripMenuItem});
            this.navigateToolStripMenuItem.Name = "navigateToolStripMenuItem";
            this.navigateToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.navigateToolStripMenuItem.Text = "Navigate";
            // 
            // hidenFilesOnofToolStripMenuItem
            // 
            this.hidenFilesOnofToolStripMenuItem.Name = "hidenFilesOnofToolStripMenuItem";
            this.hidenFilesOnofToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.hidenFilesOnofToolStripMenuItem.Text = "Hiden files OFF";
            this.hidenFilesOnofToolStripMenuItem.Click += new System.EventHandler(this.hidenFilesOnofToolStripMenuItem_Click);
            // 
            // jumpToolStripMenuItem
            // 
            this.jumpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appDataToolStripMenuItem,
            this.windowsToolStripMenuItem,
            this.startMenuToolStripMenuItem,
            this.hostToolStripMenuItem});
            this.jumpToolStripMenuItem.Name = "jumpToolStripMenuItem";
            this.jumpToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.jumpToolStripMenuItem.Text = "Jump";
            // 
            // appDataToolStripMenuItem
            // 
            this.appDataToolStripMenuItem.Name = "appDataToolStripMenuItem";
            this.appDataToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.appDataToolStripMenuItem.Text = "AppData";
            this.appDataToolStripMenuItem.Click += new System.EventHandler(this.appDataToolStripMenuItem_Click);
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.windowsToolStripMenuItem.Text = "Windows";
            this.windowsToolStripMenuItem.Click += new System.EventHandler(this.windowsToolStripMenuItem_Click);
            // 
            // startMenuToolStripMenuItem
            // 
            this.startMenuToolStripMenuItem.Name = "startMenuToolStripMenuItem";
            this.startMenuToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.startMenuToolStripMenuItem.Text = "Start Menu";
            this.startMenuToolStripMenuItem.Click += new System.EventHandler(this.startMenuToolStripMenuItem_Click);
            // 
            // hostToolStripMenuItem
            // 
            this.hostToolStripMenuItem.Name = "hostToolStripMenuItem";
            this.hostToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.hostToolStripMenuItem.Text = "Host";
            this.hostToolStripMenuItem.Click += new System.EventHandler(this.hostToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Файловый менеджер";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fileItem_KeyItem);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private FileItems file1;
        private FileItems file2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private DriveSelect drive1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private DriveSelect drive2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem navigateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hidenFilesOnofToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jumpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ToolStripMenuItem startMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hostToolStripMenuItem;

    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            file1.path = drive1.Drive;
            file2.path = drive2.Drive;
            file1.FocusSet();
            drive1.comboBox1.SelectedIndexChanged += new EventHandler(Drive1Change);
            drive2.comboBox1.SelectedIndexChanged += new EventHandler(Drive2Change);
            drive1.comboBox1.KeyUp += drive1_KeyUp;
            drive2.comboBox1.KeyUp +=drive2_KeyUp;
        }

        private void drive2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                file2.Focus();
            }
            if (e.KeyCode == Keys.F2 & e.Alt)
            {
                drive2.comboBox1.DroppedDown = true;
                drive2.comboBox1.Focus();
            }

        }

        void drive1_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                file1.Focus();
            }
            if (e.KeyCode == Keys.F2 & e.Alt)
            {
                drive2.comboBox1.DroppedDown = true;
                drive2.comboBox1.Focus();
            }
        }

        private void Drive2Change(object sender, EventArgs e)
        {
            file2.path = drive2.Drive;
        }

        private void Drive1Change(object sender, EventArgs e)
        {
            file1.path = drive1.Drive;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            file1.Width = Width / 2;
            drive2.Left = Width / 2;
        }

        private void hidenFilesOnofToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (file1.Hiden)
            {
                hidenFilesOnofToolStripMenuItem.Text = "Hiden files OFF";
                file1.Hiden = false;
                file2.Hiden = false;
            }
            else
            {
                hidenFilesOnofToolStripMenuItem.Text = "Hiden files ON";
                file1.Hiden = true;
                file2.Hiden = true;
            }

        }

        private void appDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(file1.ContainsFocus)
                file1.path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\";
            if (file2.ContainsFocus)
                file2.path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\";
        }

        private void windowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (file1.ContainsFocus)
                file1.path = Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "\\";
            if (file2.ContainsFocus)
                file2.path = Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "\\";
        }

        private void startMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (file1.ContainsFocus)
                file1.path = Environment.GetFolderPath(Environment.SpecialFolder.StartMenu)+"\\";
            if (file2.ContainsFocus)
                file2.path = Environment.GetFolderPath(Environment.SpecialFolder.StartMenu) + "\\"; ;
        }

        private void hostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (file1.ContainsFocus)
                file1.path = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\drivers\\etc\\";
            if (file2.ContainsFocus)
                file2.path = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\drivers\\etc\\"; ;
        }

        private void fileItem_KeyItem(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1 & e.Alt)
            {
                drive1.comboBox1.DroppedDown = true;
                drive1.comboBox1.Focus();
            }
            if (e.KeyCode == Keys.F2 & e.Alt)
            {
                drive2.comboBox1.DroppedDown = true;
                drive2.comboBox1.Focus();
            }
        }
    }
}

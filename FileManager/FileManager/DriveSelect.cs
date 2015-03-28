using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace FileManager
{
    public partial class DriveSelect : UserControl
    {
        private int indexchange;
        public String Drive
        {
            get;
            set;
        }
        public DriveSelect()
        {
            InitializeComponent();
        }

        public string ConvertByte(double root)
        {
            if (root < 1024)
            {
                return Math.Round(root, 2) + " байт";
            }
            root /= 1024;
            if (root < 1024)
            {
                return Math.Round(root, 2) + " Кб";
            }
            root /= 1024;
            if (root < 1024)
            {
                return Math.Round(root, 2) + " Мб";
            }
            root /= 1024;
            if (root < 1024)
            {
                return Math.Round(root, 2) + " Гб";
            }
            root /= 1024;
            return Math.Round(root, 2) + " Тб";
        }

        private void DriveSelect_Load(object sender, EventArgs e)
        {
            string[] a;
            a = Directory.GetLogicalDrives();
            comboBox1.Items.AddRange(a);
            for (int i = 0; i < comboBox1.Items.Count; i++)
            {
                imageList1.Images.Add(GetFileIcon(a[i]));
            }
            comboBox1.SelectedIndex = 0;
            DriveInfo T = new DriveInfo(comboBox1.Text);
            if (T.VolumeLabel == "")
                label1.Text = "[_нет_] " + ConvertByte(T.TotalFreeSpace) + " из " + ConvertByte(T.TotalSize) + " свободно";
            else
                label1.Text = "[" + T.VolumeLabel + "] " + ConvertByte(T.TotalFreeSpace) + " из " + ConvertByte(T.TotalSize) + " свободно";
            indexchange = comboBox1.SelectedIndex;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            Drive = comboBox1.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DriveInfo T = new DriveInfo(comboBox1.Text);
            try
            {
                Drive = comboBox1.Text;
                if (T.VolumeLabel == "")
                    label1.Text = "[_нет_] " + ConvertByte(T.TotalFreeSpace) + " из " + ConvertByte(T.TotalSize) + " свободно";
                else
                    label1.Text = "[" + T.VolumeLabel + "] " + ConvertByte(T.TotalFreeSpace) + " из " + ConvertByte(T.TotalSize) + " свободно";
                indexchange = comboBox1.SelectedIndex;
            }
            catch (System.IO.IOException)
            {
                while (MessageBox.Show("Диск не доступен или не вставлен((((", "Ошибка", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (T.IsReady)
                    {
                        if (T.VolumeLabel == "")
                            label1.Text = "[_нет_] " + ConvertByte(T.TotalFreeSpace) + " из " + ConvertByte(T.TotalSize) + " свободно";
                        else
                            label1.Text = "[" + T.VolumeLabel + "] " + ConvertByte(T.TotalFreeSpace) + " из " + ConvertByte(T.TotalSize) + " свободно";
                        indexchange = comboBox1.SelectedIndex;
                        return;
                    }
                }
                comboBox1.SelectedIndex = indexchange;
            }

        }
        Icon GetFileIcon(String fileName)
        {
            IntPtr hImgSmall;
            SHFILEINFO shinfo = new SHFILEINFO();
            hImgSmall = Win32.SHGetFileInfo(fileName, 0, ref shinfo,
                                           (uint)Marshal.SizeOf(shinfo),
                                            Win32.SHGFI_ICON |
                                            Win32.SHGFI_SMALLICON);

            return System.Drawing.Icon.FromHandle(shinfo.hIcon);
        }
        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();
            e.Graphics.DrawImage(imageList1.Images[e.Index], e.Bounds.Left, e.Bounds.Top);
            e.Graphics.DrawString(comboBox1.Items[e.Index].ToString(), e.Font, new
             SolidBrush(e.ForeColor), e.Bounds.Left + imageList1.Images[e.Index].Width, e.Bounds.Top + 2);
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }
    }
}

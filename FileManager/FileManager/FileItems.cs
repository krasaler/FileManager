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
using System.Threading;

namespace FileManager
{
    public partial class FileItems : UserControl
    {
        private int index;
        private string icondll;
        private int FileCount;
        private bool hidden;
        private int DirectoryCount;
        private string Path;
        private double sizeall;

        public FileItems()
        {
            InitializeComponent();
            label2.BackColor = Color.FromArgb(0, 100, 200);
            listView1.GotFocus += listView1_GotFocus;
            listView1.LostFocus += listView1_LostFocus;
        }

        void listView1_LostFocus(object sender, EventArgs e)
        {
            label2.BackColor = Color.FromArgb(0, 255, 255);
        }

        void listView1_GotFocus(object sender, EventArgs e)
        {
            label2.BackColor = Color.FromArgb(0, 100, 255);
        }
        private void index_desctop_ini(string root)
        {
            if (!File.Exists(root + "\\desktop.ini"))
            {
                throw new Exception();
            }
            StreamReader obj = new StreamReader(root + "\\desktop.ini");
            string t = obj.ReadLine();
            while (!obj.EndOfStream)
            {
                t = obj.ReadLine();
                if (t.IndexOf("IconResource") >= 0)
                {
                    t = t.Remove(0, t.IndexOf("=") + 1);
                    icondll = t.Split(',')[0];
                    index = Convert.ToInt32(t.Split(',')[1]);
                    break;
                }
            }
        }
        public void Update(string root)
        {
            try
            {
                DirectoryInfo a = new DirectoryInfo(root);
                DirectoryInfo[] Directories;
                FileInfo[] Fylies;
                sizeall = 0;
                //получаем список файлов и папок 
                Directories = a.GetDirectories();
                Fylies = a.GetFiles();
                //очищаем
                this.listView1.Items.Clear();
                imageList1.Images.Clear();
                //Строка ...
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = "...";
                listViewItem.BackColor = Color.FromArgb(255, 255, 255);
                listViewItem.SubItems.Add("");
                listViewItem.SubItems.Add("");
                listViewItem.SubItems.Add("");
                imageList1.Images.Add(GetFileIcon("..."));
                listViewItem.ImageIndex = imageList1.Images.Count - 1;
                if (root.LastIndexOf("\\") != root.IndexOf("\\"))
                    listView1.Items.Add((ListViewItem)listViewItem.Clone());
                //Добавление папок
                foreach (DirectoryInfo Set in Directories)
                {
                    listViewItem.SubItems.Clear();
                    listViewItem.Text = Set.Name;
                    listViewItem.SubItems.Add("");
                    listViewItem.SubItems.Add("<ПАПКА>");
                    listViewItem.SubItems.Add(Set.LastWriteTime.ToString());
                    imageList1.Images.Add(GetFileIcon(Set.FullName));
                    listViewItem.ImageIndex = imageList1.Images.Count - 1;
                    if (((Set.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden) & Hiden)
                    {
                        listView1.Items.Add((ListViewItem)listViewItem.Clone());
                        DirectoryCount++;
                    }
                    if (((Set.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden))
                    {
                        listView1.Items.Add((ListViewItem)listViewItem.Clone());
                        DirectoryCount++;
                    }
                }
                //Добавление файлов
                foreach (FileInfo set in Fylies)
                {
                    //Работа с данными
                    listViewItem.SubItems.Clear();
                    listViewItem.Text = set.Name.Remove(set.Name.LastIndexOf(set.Extension));
                    if (set.Extension.Length >= 2)
                        listViewItem.SubItems.Add(set.Extension.Substring(1));
                    else
                        listViewItem.SubItems.Add(set.Extension);

                    listViewItem.SubItems.Add(ConvertByte(set.Length));
                    listViewItem.SubItems.Add(set.LastWriteTime.ToString());
                    //Загрузка исконки
                 /*   pic = Icon.ExtractAssociatedIcon(set.FullName);*/
                    imageList1.Images.Add(GetFileIcon(set.FullName));
                    listViewItem.ImageIndex = imageList1.Images.Count - 1;
                    //Добавлениен элемента в список
                    if (((set.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden) & Hiden)
                    {
                        sizeall += set.Length;
                        listView1.Items.Add((ListViewItem)listViewItem.Clone());
                        FileCount++;
                    }
                    if (((set.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden))
                    {
                        sizeall += set.Length;
                        listView1.Items.Add((ListViewItem)listViewItem.Clone());
                        FileCount++;
                    }
                }
                label1.Text = "0 байт из " + ConvertByte(sizeall) + ", файлов 0 из " + FileCount + ", папок 0 из " + DirectoryCount;
                listView1.Items[0].Focused = true;
                listView1.Items[0].Selected = true;
            }
            catch (System.UnauthorizedAccessException)
            {
                MessageBox.Show("Нету прав для доступа к директории");
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                MessageBox.Show("Указанной директории не существует");
            }
            catch (System.Exception)
            {

            }
        }
        public void LoadFileIcon(int start, int count)
        {

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
        public bool FocusGet()
        {
            return listView1.ContainsFocus;
        }
        public void FocusSet()
        {
            listView1.Focus();
        }
        public bool Hiden
        {
            get
            {
                return hidden;
            }
            set
            {
                hidden = value;
                path = Path;
            }
        }

        public string path
        {
            get
            {
                return Path;
            }
            set
            {
                FileCount = 0;
                DirectoryCount = 0;
                Update(value);
                Path = value;
                label2.Text = value;
            }

        }

        private void FileItems_Resize(object sender, EventArgs e)
        {
            listView1.Width = Width;
            listView1.Height = Height - label1.Height - label2.Height;
            listView1.Columns[0].Width = Width - listView1.Columns[1].Width - listView1.Columns[2].Width - listView1.Columns[3].Width - 4;
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (listView1.FocusedItem.Text == "...")
                {
                    string str = Path;
                    str = Path.Remove(Path.LastIndexOf("\\"));
                    str = str.Remove(str.LastIndexOf("\\"));
                    path = str + "\\";
                }
                else
                {
                    if (listView1.FocusedItem.SubItems[2].Text == "<ПАПКА>")
                    {
                        path = Path.Remove(Path.LastIndexOf("\\")) + "\\" + listView1.FocusedItem.Text + "\\";
                    }
                    else
                    {
                        System.Diagnostics.Process MyProc = new System.Diagnostics.Process();
                        MyProc.StartInfo.FileName = Path.Remove(Path.LastIndexOf("\\")) + "\\" + listView1.FocusedItem.Text + "." + listView1.FocusedItem.SubItems[1].Text;
                        MyProc.Start();
                    }
                }
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
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a, b;
            a = 0; b = 0;
            double sizef = 0;
            for (int i = 0; i < listView1.SelectedItems.Count; i++)
            {
                if (listView1.SelectedItems[i].SubItems[2].Text == "<ПАПКА>")
                {
                    a++;
                }
                else
                {

                    try
                    {
                        FileInfo t = new FileInfo(Path.Remove(Path.LastIndexOf("\\")) + "\\" + listView1.SelectedItems[i].Text + "." + listView1.SelectedItems[i].SubItems[1].Text);
                        sizef += t.Length;
                        b++;
                    }
                    catch (System.Exception)
                    {

                    }

                }
                label1.Text = ConvertByte(sizef) + " из " + ConvertByte(sizeall) + ", файлов " + b + " из " + FileCount + ", папок " + a + " из " + DirectoryCount;
            }
        }

        private void listView1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (listView1.FocusedItem.Text == "...")
                {
                    string str = Path;
                    str = Path.Remove(Path.LastIndexOf("\\"));
                    str = str.Remove(str.LastIndexOf("\\"));
                    path = str + "\\";
                }
                else
                {
                    if (listView1.FocusedItem.SubItems[2].Text == "<ПАПКА>")
                    {
                        path = Path.Remove(Path.LastIndexOf("\\")) + "\\" + listView1.FocusedItem.Text + "\\";
                    }
                    else
                    {
                        System.Diagnostics.Process MyProc = new System.Diagnostics.Process();
                        MyProc.StartInfo.FileName = Path.Remove(Path.LastIndexOf("\\")) + "\\" + listView1.FocusedItem.Text + "." + listView1.FocusedItem.SubItems[1].Text;
                        MyProc.Start();
                    }
                }
            }
        }
        public delegate void KeyItemDelegate(object sender, KeyEventArgs e);
        public event KeyItemDelegate KeyItem;
        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            KeyItem(sender, e);
        }
    }
}

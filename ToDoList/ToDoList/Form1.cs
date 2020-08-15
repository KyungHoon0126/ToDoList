using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleDiary
{
    public partial class Form1 : Form
    {
        public string setting_file_path = null;
        public string setting_file_folder_path = null;
        public Form1()
        {
            SettingCHK();
            InitializeComponent();
        }

        public void SettingCHK()
        {
            string strFile = Environment.CurrentDirectory + "\\Setting.txt";
            FileInfo fileInfo = new FileInfo(strFile);
            if (!fileInfo.Exists)
            {
                setting_file_path = "존재하지 않습니다!";
            }
            else
            {
                setting_file_path = strFile;
            }
        }

        private void 설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingForm settingForm = new SettingForm();
            settingForm.call_value = setting_file_path;
            settingForm.ShowDialog();
        }

        public void setting_reload()
        {
            SettingForm settingForm = new SettingForm();
            System.IO.StreamReader in_file_line = new System.IO.StreamReader(setting_file_path);
            setting_file_folder_path = in_file_line.ReadLine();
        }

        public void reload()
        {
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(setting_file_path + DateTime.Now.ToString("yyyMMdd") + ".txt");
            FileInfo info = new FileInfo(setting_file_path + DateTime.Now.ToString("yyyMMdd") + ".txt");
            if (!info.Exists)
            {
                MessageBox.Show("파일이 존재하지 않습니다!");
            }
            else
            {
                while ((line = file.ReadLine()) != null)
                {
                    ToDoListBox.Items.Add(file.ReadLine());
                }
            }
        }

        private void load_button_Click(object sender, EventArgs e)
        {
            setting_reload();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            ToDoListBox.Items.Add(textBox1.Text);
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            FileInfo fileInfo = new FileInfo(setting_file_folder_path + DateTime.Now.ToString("yyyMMdd") + ".txt");
            if (!fileInfo.Exists) File.Create(setting_file_folder_path + DateTime.Now.ToString("yyyMMdd") + ".txt"); //존재하지 않으면 파일 생성
            StreamWriter reader = new StreamWriter(setting_file_folder_path + DateTime.Now.ToString("yyyMMdd") + ".txt");
            foreach(var input in ToDoListBox.Items)
            {
                reader.WriteLine(input);
            }
        }
    }
}

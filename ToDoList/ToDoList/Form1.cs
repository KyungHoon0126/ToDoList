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
            setting_reload();
            InitializeComponent();
        }

        public void SettingCHK()
        {
            string strFile = Environment.CurrentDirectory + "\\Setting.txt";
            FileInfo fileInfo = new FileInfo(strFile);
            if (!fileInfo.Exists)
            {
                setting_file_path = null;
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
            //SettingForm settingForm = new SettingForm();
            if (setting_file_path != null)
            {
                using (StreamReader in_file_line = new StreamReader(setting_file_path))
                {
                    setting_file_folder_path = in_file_line.ReadLine();
                }
            }
        }

        public void load()
        {
            string[] line = File.ReadAllLines(setting_file_folder_path + DateTime.Now.ToString("yyyMMdd") + ".txt");
            FileInfo info = new FileInfo(setting_file_folder_path + DateTime.Now.ToString("yyyMMdd") + ".txt");
            if (!info.Exists)
            {
                MessageBox.Show("파일이 존재하지 않습니다!");
            }
            else
            {
                foreach (string input in line) 
                {
                    ToDoListBox.Items.Add(input);
                }
            }
        }

        public void save()
        {
            FileInfo fileInfo = new FileInfo(setting_file_folder_path + DateTime.Now.ToString("yyyMMdd") + ".txt");
            if (!fileInfo.Exists)
            {
                using (FileStream fs = File.Create(setting_file_folder_path + DateTime.Now.ToString("yyyMMdd") + ".txt")) //존재하지 않으면 파일 생성
                {
                }
            }
            using (StreamWriter writer = new StreamWriter(setting_file_folder_path + DateTime.Now.ToString("yyyMMdd") + ".txt"))
            {
                foreach (var input in ToDoListBox.Items)
                {
                    writer.WriteLine(input.ToString());
                }
            }
        }

        public void delete()
        {
            for(int i = (ToDoListBox.Items.Count - 1); i >= 0; i--)
            {
                if (ToDoListBox.GetItemChecked(i))
                {
                    ToDoListBox.Items.RemoveAt(i);
                }
            }
        }

        private void load_button_Click(object sender, EventArgs e)
        {
            ToDoListBox.Items.Clear();
            load();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            ToDoListBox.Items.Add(textBox1.Text);
            textBox1.Text = "";
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            save();
            MessageBox.Show("저장이 완료되었습니다!");
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            delete();
            if (MessageBox.Show("저장하시겠습니까?", "저장", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                save();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar== (char)Keys.Enter)
            {
                this.add_button_Click(sender, e);
                e.Handled = true;
                textBox1.Text = "";
            }
        }

        private void setting_load_Click(object sender, EventArgs e)
        {
            SettingCHK();
        }
    }
}

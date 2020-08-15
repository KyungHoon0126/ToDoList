using Microsoft.WindowsAPICodePack.Dialogs; //Install-Package WindowsAPICodePack-Core -Version 1.1.2, Install-Package WindowsAPICodePack-Shell -Version 1.1.1
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleDiary
{
    public partial class SettingForm : Form
    {
        private string strpath; //설정 파일 경로
        public string call_value
        {
            get
            {
                return this.strpath;
            }
            set
            {
                this.strpath = value;
            }
        }
        public SettingForm()
        {
            InitializeComponent();
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            file_dir.Text = "설정파일 경로: " + strpath;
        }

        private void folder_setting_Click(object sender, EventArgs e)
        {
            Form1 MainForm = new Form1();
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;

            if(dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                using(StreamWriter out_file = new StreamWriter(strpath))
                {
                    out_file.WriteLine(dialog.FileName + "\\");
                }
                MainForm.setting_reload();
                MessageBox.Show("설정 완료!");
            }
        }

        private void make_setting_file_button_Click(object sender, EventArgs e)
        {
            FileInfo fileinfo = new FileInfo(strpath);
            if (!fileinfo.Exists)
            {
                try
                {
                    strpath = Environment.CurrentDirectory + "\\Setting.txt";
                    System.IO.File.Create(strpath);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message.ToString());
                }
                MessageBox.Show("생성 성공!");
            }
            else
            {
                MessageBox.Show("이미 생성된 파일입니다!");
            }
        }
    }
}

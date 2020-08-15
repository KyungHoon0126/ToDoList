namespace SimpleDiary
{
    partial class SettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.file_dir = new System.Windows.Forms.Label();
            this.folder_setting = new System.Windows.Forms.Button();
            this.make_setting_file_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // file_dir
            // 
            this.file_dir.AutoSize = true;
            this.file_dir.Location = new System.Drawing.Point(12, 49);
            this.file_dir.Name = "file_dir";
            this.file_dir.Size = new System.Drawing.Size(37, 15);
            this.file_dir.TabIndex = 0;
            this.file_dir.Text = "파일";
            // 
            // folder_setting
            // 
            this.folder_setting.Location = new System.Drawing.Point(15, 246);
            this.folder_setting.Name = "folder_setting";
            this.folder_setting.Size = new System.Drawing.Size(303, 56);
            this.folder_setting.TabIndex = 1;
            this.folder_setting.Text = "폴더 설정";
            this.folder_setting.UseVisualStyleBackColor = true;
            this.folder_setting.Click += new System.EventHandler(this.folder_setting_Click);
            // 
            // make_setting_file_button
            // 
            this.make_setting_file_button.Location = new System.Drawing.Point(15, 184);
            this.make_setting_file_button.Name = "make_setting_file_button";
            this.make_setting_file_button.Size = new System.Drawing.Size(303, 56);
            this.make_setting_file_button.TabIndex = 2;
            this.make_setting_file_button.Text = "설정 파일 생성";
            this.make_setting_file_button.UseVisualStyleBackColor = true;
            this.make_setting_file_button.Click += new System.EventHandler(this.make_setting_file_button_Click);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 314);
            this.Controls.Add(this.make_setting_file_button);
            this.Controls.Add(this.folder_setting);
            this.Controls.Add(this.file_dir);
            this.Name = "SettingForm";
            this.Text = "설정창";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label file_dir;
        private System.Windows.Forms.Button folder_setting;
        private System.Windows.Forms.Button make_setting_file_button;
    }
}
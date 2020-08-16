namespace SimpleDiary
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.setting_load = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.load_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.Label();
            this.ToDoListBox = new System.Windows.Forms.CheckedListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.setting_load);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.load_button);
            this.panel1.Controls.Add(this.save_button);
            this.panel1.Controls.Add(this.delete_button);
            this.panel1.Controls.Add(this.add_button);
            this.panel1.Controls.Add(this.date);
            this.panel1.Controls.Add(this.ToDoListBox);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 496);
            this.panel1.TabIndex = 0;
            // 
            // setting_load
            // 
            this.setting_load.Location = new System.Drawing.Point(670, 276);
            this.setting_load.Name = "setting_load";
            this.setting_load.Size = new System.Drawing.Size(267, 46);
            this.setting_load.TabIndex = 9;
            this.setting_load.Text = "설정 불러오기";
            this.setting_load.UseVisualStyleBackColor = true;
            this.setting_load.Click += new System.EventHandler(this.setting_load_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(670, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(267, 25);
            this.textBox1.TabIndex = 7;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // load_button
            // 
            this.load_button.Location = new System.Drawing.Point(670, 224);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(267, 46);
            this.load_button.TabIndex = 6;
            this.load_button.Text = "불러오기";
            this.load_button.UseVisualStyleBackColor = true;
            this.load_button.Click += new System.EventHandler(this.load_button_Click);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(670, 172);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(267, 46);
            this.save_button.TabIndex = 5;
            this.save_button.Text = "저장";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(670, 120);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(267, 46);
            this.delete_button.TabIndex = 4;
            this.delete_button.Text = "삭제";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(670, 66);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(267, 48);
            this.add_button.TabIndex = 3;
            this.add_button.Text = "추가";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(12, 35);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(42, 15);
            this.date.TabIndex = 2;
            this.date.Text = "날짜:";
            // 
            // ToDoListBox
            // 
            this.ToDoListBox.FormattingEnabled = true;
            this.ToDoListBox.Location = new System.Drawing.Point(12, 53);
            this.ToDoListBox.Name = "ToDoListBox";
            this.ToDoListBox.Size = new System.Drawing.Size(649, 424);
            this.ToDoListBox.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.설정ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(949, 30);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 설정ToolStripMenuItem
            // 
            this.설정ToolStripMenuItem.Name = "설정ToolStripMenuItem";
            this.설정ToolStripMenuItem.Size = new System.Drawing.Size(53, 26);
            this.설정ToolStripMenuItem.Text = "설정";
            this.설정ToolStripMenuItem.Click += new System.EventHandler(this.설정ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 496);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ToDoList!";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button load_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.CheckedListBox ToDoListBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 설정ToolStripMenuItem;
        private System.Windows.Forms.Button setting_load;
    }
}


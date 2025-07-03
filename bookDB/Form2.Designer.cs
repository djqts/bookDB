namespace bookMS
{
    partial class Form2
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
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            ReaderPwd = new TextBox();
            ReaderID = new TextBox();
            label6 = new Label();
            label7 = new Label();
            tabPage2 = new TabPage();
            AdminPwd = new TextBox();
            AdminID = new TextBox();
            label5 = new Label();
            label4 = new Label();
            checkBox1 = new CheckBox();
            label1 = new Label();
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            忘记密码ToolStripMenuItem = new ToolStripMenuItem();
            新用户注册ToolStripMenuItem = new ToolStripMenuItem();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.HotTrack = true;
            tabControl.ItemSize = new Size(66, 29);
            tabControl.Location = new Point(136, 122);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(512, 186);
            tabControl.TabIndex = 11;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(ReaderPwd);
            tabPage1.Controls.Add(ReaderID);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label7);
            tabPage1.Location = new Point(4, 33);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(504, 149);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "用户";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // ReaderPwd
            // 
            ReaderPwd.Font = new Font("楷体", 10.5F);
            ReaderPwd.Location = new Point(162, 94);
            ReaderPwd.Name = "ReaderPwd";
            ReaderPwd.PasswordChar = '*';
            ReaderPwd.Size = new Size(272, 31);
            ReaderPwd.TabIndex = 8;
            // 
            // ReaderID
            // 
            ReaderID.Font = new Font("楷体", 10.5F);
            ReaderID.Location = new Point(162, 30);
            ReaderID.Name = "ReaderID";
            ReaderID.Size = new Size(272, 31);
            ReaderID.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("楷体", 10.5F);
            label6.Location = new Point(63, 103);
            label6.Name = "label6";
            label6.Size = new Size(76, 21);
            label6.TabIndex = 6;
            label6.Text = "密码：";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("楷体", 10.5F);
            label7.Location = new Point(63, 43);
            label7.Name = "label7";
            label7.Size = new Size(76, 21);
            label7.TabIndex = 5;
            label7.Text = "账户：";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(AdminPwd);
            tabPage2.Controls.Add(AdminID);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 33);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(504, 149);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "管理员";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // AdminPwd
            // 
            AdminPwd.Font = new Font("楷体", 10.5F);
            AdminPwd.Location = new Point(162, 91);
            AdminPwd.Name = "AdminPwd";
            AdminPwd.PasswordChar = '*';
            AdminPwd.Size = new Size(272, 31);
            AdminPwd.TabIndex = 14;
            // 
            // AdminID
            // 
            AdminID.Font = new Font("楷体", 10.5F);
            AdminID.Location = new Point(162, 27);
            AdminID.Name = "AdminID";
            AdminID.Size = new Size(272, 31);
            AdminID.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("楷体", 10.5F);
            label5.Location = new Point(63, 40);
            label5.Name = "label5";
            label5.Size = new Size(76, 21);
            label5.TabIndex = 11;
            label5.Text = "账户：";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("楷体", 10.5F);
            label4.Location = new Point(63, 100);
            label4.Name = "label4";
            label4.Size = new Size(76, 21);
            label4.TabIndex = 12;
            label4.Text = "密码：";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(322, 338);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 28);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "显示密码";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("华文行楷", 16F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(212, 56);
            label1.Name = "label1";
            label1.Size = new Size(345, 33);
            label1.TabIndex = 13;
            label1.Text = "欢迎登陆图书管理系统";
            // 
            // button1
            // 
            button1.Font = new Font("楷体", 10.5F);
            button1.Location = new Point(306, 372);
            button1.Name = "button1";
            button1.Size = new Size(150, 50);
            button1.TabIndex = 14;
            button1.Text = "登录";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 忘记密码ToolStripMenuItem, 新用户注册ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(749, 32);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // 忘记密码ToolStripMenuItem
            // 
            忘记密码ToolStripMenuItem.Name = "忘记密码ToolStripMenuItem";
            忘记密码ToolStripMenuItem.Size = new Size(98, 28);
            忘记密码ToolStripMenuItem.Text = "忘记密码";
            // 
            // 新用户注册ToolStripMenuItem
            // 
            新用户注册ToolStripMenuItem.Name = "新用户注册ToolStripMenuItem";
            新用户注册ToolStripMenuItem.Size = new Size(116, 28);
            新用户注册ToolStripMenuItem.Text = "新用户注册";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 477);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(checkBox1);
            Controls.Add(tabControl);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPage1;
        private TextBox ReaderPwd;
        private TextBox ReaderID;
        private Label label6;
        private Label label7;
        private TabPage tabPage2;
        private TextBox AdminPwd;
        private TextBox AdminID;
        private Label label5;
        private Label label4;
        private CheckBox checkBox1;
        private Label label1;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 忘记密码ToolStripMenuItem;
        private ToolStripMenuItem 新用户注册ToolStripMenuItem;
    }
}
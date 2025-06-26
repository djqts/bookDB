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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            tabPage2 = new TabPage();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            checkBox1 = new CheckBox();
            label1 = new Label();
            button1 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.HotTrack = true;
            tabControl1.ItemSize = new Size(66, 29);
            tabControl1.Location = new Point(140, 104);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(512, 186);
            tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(textBox5);
            tabPage1.Controls.Add(textBox6);
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
            // textBox5
            // 
            textBox5.Font = new Font("楷体", 10.5F);
            textBox5.Location = new Point(162, 94);
            textBox5.Name = "textBox5";
            textBox5.PasswordChar = '*';
            textBox5.Size = new Size(272, 31);
            textBox5.TabIndex = 8;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("楷体", 10.5F);
            textBox6.Location = new Point(162, 30);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(272, 31);
            textBox6.TabIndex = 7;
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
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(textBox4);
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
            // textBox3
            // 
            textBox3.Font = new Font("楷体", 10.5F);
            textBox3.Location = new Point(162, 91);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(272, 31);
            textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("楷体", 10.5F);
            textBox4.Location = new Point(162, 27);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(272, 31);
            textBox4.TabIndex = 13;
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
            checkBox1.Location = new Point(322, 314);
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
            label1.Location = new Point(233, 25);
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
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 477);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(checkBox1);
            Controls.Add(tabControl1);
            Name = "Form2";
            Text = "Form2";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label6;
        private Label label7;
        private TabPage tabPage2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label5;
        private Label label4;
        private CheckBox checkBox1;
        private Label label1;
        private Button button1;
    }
}
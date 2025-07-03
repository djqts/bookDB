namespace bookMS

{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("华文行楷", 16F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(249, 70);
            label1.Name = "label1";
            label1.Size = new Size(345, 33);
            label1.TabIndex = 0;
            label1.Text = "欢迎登陆图书管理系统";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("楷体", 10.5F);
            label2.Location = new Point(232, 174);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 1;
            label2.Text = "账户：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("楷体", 10.5F);
            label3.Location = new Point(232, 234);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 2;
            label3.Text = "密码：";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("楷体", 10.5F);
            textBox1.Location = new Point(334, 164);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(272, 31);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("楷体", 10.5F);
            textBox2.Location = new Point(334, 228);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(272, 31);
            textBox2.TabIndex = 4;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("楷体", 10.5F);
            radioButton2.Location = new Point(409, 313);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(101, 25);
            radioButton2.TabIndex = 5;
            radioButton2.Text = "管理员";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Font = new Font("楷体", 10.5F);
            radioButton1.Location = new Point(275, 313);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(79, 25);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "用户";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("楷体", 10.5F);
            button1.Location = new Point(334, 394);
            button1.Name = "button1";
            button1.Size = new Size(150, 50);
            button1.TabIndex = 7;
            button1.Text = "登录";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(819, 514);
            Controls.Add(button1);
            Controls.Add(radioButton1);
            Controls.Add(radioButton2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button1;
    }
}

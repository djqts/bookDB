namespace bookMS
{
    partial class AddUser
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
            button1 = new Button();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Font = new Font("仿宋", 12F);
            button1.Location = new Point(335, 426);
            button1.Name = "button1";
            button1.Size = new Size(173, 34);
            button1.TabIndex = 21;
            button1.Text = "确认添加";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Font = new Font("仿宋", 12F);
            textBox4.Location = new Point(357, 311);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(255, 35);
            textBox4.TabIndex = 18;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("仿宋", 12F);
            label4.Location = new Point(237, 311);
            label4.Name = "label4";
            label4.Size = new Size(58, 24);
            label4.TabIndex = 17;
            label4.Text = "密码";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Font = new Font("仿宋", 12F);
            textBox3.Location = new Point(357, 172);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(255, 35);
            textBox3.TabIndex = 16;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("仿宋", 12F);
            label3.Location = new Point(237, 172);
            label3.Name = "label3";
            label3.Size = new Size(58, 24);
            label3.TabIndex = 15;
            label3.Text = "姓名";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Font = new Font("仿宋", 12F);
            textBox2.Location = new Point(357, 239);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(255, 35);
            textBox2.TabIndex = 14;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("仿宋", 12F);
            label2.Location = new Point(237, 239);
            label2.Name = "label2";
            label2.Size = new Size(58, 24);
            label2.TabIndex = 13;
            label2.Text = "性别";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("仿宋", 12F);
            textBox1.Location = new Point(357, 109);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(255, 35);
            textBox1.TabIndex = 12;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("仿宋", 12F);
            label1.Location = new Point(261, 112);
            label1.Name = "label1";
            label1.Size = new Size(34, 24);
            label1.TabIndex = 11;
            label1.Text = "ID";
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 547);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "AddUser";
            Text = "AddUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
    }
}
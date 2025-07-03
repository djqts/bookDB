namespace bookMS
{
    partial class ModifyBook
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
            button2 = new Button();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox2 = new TextBox();
            label7 = new Label();
            textBox3 = new TextBox();
            label8 = new Label();
            textBox1 = new TextBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.Font = new Font("仿宋", 12F);
            button2.Location = new Point(300, 368);
            button2.Name = "button2";
            button2.Size = new Size(325, 40);
            button2.TabIndex = 43;
            button2.Text = "确认修改";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox5.Font = new Font("仿宋", 12F);
            textBox5.Location = new Point(331, 266);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(351, 35);
            textBox5.TabIndex = 42;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("仿宋", 12F);
            label5.Location = new Point(200, 266);
            label5.Name = "label5";
            label5.Size = new Size(58, 24);
            label5.TabIndex = 41;
            label5.Text = "库存";
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Font = new Font("仿宋", 12F);
            textBox4.Location = new Point(331, 199);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(351, 35);
            textBox4.TabIndex = 40;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("仿宋", 12F);
            label6.Location = new Point(191, 205);
            label6.Name = "label6";
            label6.Size = new Size(82, 24);
            label6.TabIndex = 39;
            label6.Text = "出版社";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Font = new Font("仿宋", 12F);
            textBox2.Location = new Point(331, 94);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(351, 35);
            textBox2.TabIndex = 38;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("仿宋", 12F);
            label7.Location = new Point(200, 100);
            label7.Name = "label7";
            label7.Size = new Size(58, 24);
            label7.TabIndex = 37;
            label7.Text = "书名";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Font = new Font("仿宋", 12F);
            textBox3.Location = new Point(331, 146);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(351, 35);
            textBox3.TabIndex = 36;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("仿宋", 12F);
            label8.Location = new Point(200, 152);
            label8.Name = "label8";
            label8.Size = new Size(58, 24);
            label8.TabIndex = 35;
            label8.Text = "作者";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("仿宋", 12F);
            textBox1.Location = new Point(331, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(351, 35);
            textBox1.TabIndex = 34;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("仿宋", 12F);
            label9.Location = new Point(200, 43);
            label9.Name = "label9";
            label9.Size = new Size(58, 24);
            label9.TabIndex = 33;
            label9.Text = "书号";
            // 
            // ModifyBook
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 456);
            Controls.Add(button2);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(label8);
            Controls.Add(textBox1);
            Controls.Add(label9);
            Name = "ModifyBook";
            Text = "ModifyBook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox2;
        private Label label7;
        private TextBox textBox3;
        private Label label8;
        private TextBox textBox1;
        private Label label9;
    }
}
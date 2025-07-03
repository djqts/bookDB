namespace bookMS
{
    partial class MyVB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyVB));
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            label9 = new Label();
            button5 = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Colum2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Colum2, Column3, Column4, Column5, Column6, Column2 });
            dataGridView1.Dock = DockStyle.Left;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(849, 563);
            dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            button1.ImageAlign = ContentAlignment.BottomRight;
            button1.Location = new Point(932, 55);
            button1.Name = "button1";
            button1.Size = new Size(157, 64);
            button1.TabIndex = 2;
            button1.Text = " 还书";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(932, 458);
            button2.Name = "button2";
            button2.Size = new Size(157, 80);
            button2.TabIndex = 3;
            button2.Text = "返回";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(932, 138);
            button3.Name = "button3";
            button3.Size = new Size(157, 72);
            button3.TabIndex = 4;
            button3.Text = "续借";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(932, 277);
            button4.Name = "button4";
            button4.Size = new Size(157, 87);
            button4.TabIndex = 5;
            button4.Text = "提交罚款";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("仿宋", 12F);
            textBox1.Location = new Point(974, 222);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(162, 35);
            textBox1.TabIndex = 36;
            textBox1.Click += textBox1_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("仿宋", 12F);
            label9.Location = new Point(855, 225);
            label9.Name = "label9";
            label9.Size = new Size(106, 24);
            label9.TabIndex = 35;
            label9.Text = "验证码：";
            // 
            // button5
            // 
            button5.Location = new Point(959, 398);
            button5.Name = "button5";
            button5.Size = new Size(112, 34);
            button5.TabIndex = 37;
            button5.Text = "刷新";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Column1
            // 
            Column1.HeaderText = "no";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Visible = false;
            // 
            // Colum2
            // 
            Colum2.HeaderText = "书号";
            Colum2.MinimumWidth = 8;
            Colum2.Name = "Colum2";
            // 
            // Column3
            // 
            Column3.HeaderText = "书名";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "借阅时间";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "是否逾期";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "罚款金额";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            // 
            // Column2
            // 
            Column2.HeaderText = "code";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Visible = false;
            // 
            // MyVB
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 563);
            Controls.Add(button5);
            Controls.Add(textBox1);
            Controls.Add(label9);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "MyVB";
            Text = resources.GetString("$this.Text");
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private Label label9;
        private Button button5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Colum2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column2;
    }
}
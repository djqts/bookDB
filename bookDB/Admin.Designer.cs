namespace bookMS
{
    partial class Admin
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
            menuStrip1 = new MenuStrip();
            系统ToolStripMenuItem = new ToolStripMenuItem();
            图书管理ToolStripMenuItem = new ToolStripMenuItem();
            罚款管理ToolStripMenuItem = new ToolStripMenuItem();
            借阅记录ToolStripMenuItem = new ToolStripMenuItem();
            读者管理ToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip2 = new MenuStrip();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 系统ToolStripMenuItem, 图书管理ToolStripMenuItem, 罚款管理ToolStripMenuItem, 借阅记录ToolStripMenuItem, 读者管理ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 24);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 32);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 系统ToolStripMenuItem
            // 
            系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            系统ToolStripMenuItem.Size = new Size(62, 28);
            系统ToolStripMenuItem.Text = "系统";
            // 
            // 图书管理ToolStripMenuItem
            // 
            图书管理ToolStripMenuItem.Name = "图书管理ToolStripMenuItem";
            图书管理ToolStripMenuItem.Size = new Size(98, 28);
            图书管理ToolStripMenuItem.Text = "图书管理";
            图书管理ToolStripMenuItem.Click += 图书管理ToolStripMenuItem_Click;
            // 
            // 罚款管理ToolStripMenuItem
            // 
            罚款管理ToolStripMenuItem.Name = "罚款管理ToolStripMenuItem";
            罚款管理ToolStripMenuItem.Size = new Size(98, 28);
            罚款管理ToolStripMenuItem.Text = "库存查看";
            罚款管理ToolStripMenuItem.Click += 罚款管理ToolStripMenuItem_Click;
            // 
            // 借阅记录ToolStripMenuItem
            // 
            借阅记录ToolStripMenuItem.Name = "借阅记录ToolStripMenuItem";
            借阅记录ToolStripMenuItem.Size = new Size(98, 28);
            借阅记录ToolStripMenuItem.Text = "借阅记录";
            借阅记录ToolStripMenuItem.Click += 借阅记录ToolStripMenuItem_Click;
            // 
            // 读者管理ToolStripMenuItem
            // 
            读者管理ToolStripMenuItem.Name = "读者管理ToolStripMenuItem";
            读者管理ToolStripMenuItem.Size = new Size(98, 28);
            读者管理ToolStripMenuItem.Text = "读者管理";
            读者管理ToolStripMenuItem.Click += 读者管理ToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("楷体", 15F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(263, 208);
            label1.Name = "label1";
            label1.Size = new Size(230, 30);
            label1.TabIndex = 1;
            label1.Text = "欢迎管理员登录";
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(24, 24);
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(800, 24);
            menuStrip2.TabIndex = 2;
            menuStrip2.Text = "menuStrip2";
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Name = "Admin";
            Text = "管理员主界面";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 系统ToolStripMenuItem;
        private ToolStripMenuItem 图书管理ToolStripMenuItem;
        private Label label1;
        private ToolStripMenuItem 罚款管理ToolStripMenuItem;
        private ToolStripMenuItem 借阅记录ToolStripMenuItem;
        private ToolStripMenuItem 读者管理ToolStripMenuItem;
        private MenuStrip menuStrip2;
    }
}
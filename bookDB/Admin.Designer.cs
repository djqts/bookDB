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
            帮助ToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 系统ToolStripMenuItem, 图书管理ToolStripMenuItem, 帮助ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
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
            // 帮助ToolStripMenuItem
            // 
            帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            帮助ToolStripMenuItem.Size = new Size(62, 28);
            帮助ToolStripMenuItem.Text = "帮助";
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
            // Admin
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
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
        private ToolStripMenuItem 帮助ToolStripMenuItem;
        private Label label1;
    }
}
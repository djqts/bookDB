﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookMS
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //健壮性检查
            //1.正则表达式判断一下内容是否符合要求
            //2.待改为主键不为空

            if (!(string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text)))
            {
                //添加到数据库
                Dao dao = new Dao();
                string sql = "insert into book values('" + textBox1.Text + "', '" + textBox3.Text + "', '" + textBox2.Text + "', '" + textBox4.Text + "', " + textBox5.Text + ")";
                if (dao.Execute(sql) > 0)
                {
                    MessageBox.Show("添加成功！");

                }
                else
                {
                    MessageBox.Show("添加失败！");
                }
                for (int i = 0; i < this.Controls.Count; i++)
                {
                    if (this.Controls[i] is TextBox)
                    {
                        this.Controls[i].Text = "";
                    }
                }
                //确认无需添加
                //关闭数据库连接
                dao.DaoClose();
                this.Close();

                //跳转到主界面
                this.Hide();
                Admin2 mainForm = new Admin2();
                mainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("请填写完整信息！");
                this.Owner?.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

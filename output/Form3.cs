using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace output
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button_register_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
            
        }

        private void button_register_register_Click(object sender, EventArgs e)
        {
            
               // NpgsqlConnection SqlConn;
                String username, password, repassword;
                username = textBox_register_name.Text;
                password = textBox_register_secret.Text;
                repassword = textBox_register_confirm.Text;
                if (textBox_register_name.Text == "")
                {
                    MessageBox.Show("请输入用户名", "注册失败");
                textBox_register_name.Focus();
                }
                else if (textBox_register_secret.Text == "")
                {
                    MessageBox.Show("请输入密码", "注册失败");
                textBox_register_secret.Focus();
                }
                else if (textBox_register_confirm.Text == "")
                    MessageBox.Show("请确认密码", "注册失败");
                else
                {
                Dao dao = new Dao();//实例化数据库对象
                string sql = "select * from cs.users where id_name='" + textBox_register_name.Text +  "'";
                IDataReader dc = dao.read(sql);

                if (dc.Read())
                    {
                    dao.DaoClose();
                        MessageBox.Show("该用户名已存在，请重新注册", "注册失败");
                    textBox_register_name.Text = "";
                    textBox_register_secret.Text = "";
                    textBox_register_confirm.Text = "";
                    textBox_register_name.Focus();     //指定光标在哪个textBox处闪烁
                    }
                    else
                    {
                        if (password == repassword)//两次输入的密码一致  
                        {
                        Dao dao1 = new Dao();//实例化数据库对象
                        string sql1 = "select * from cs.users where id_name='" + textBox_register_name.Text + "'";
                        IDataReader dc1 = dao1.read(sql1);
                        //password = GetMD5(password);
                        String sql2 = "INSERT INTO cs.users(id_name,secret) VALUES('" + username + "','" + password + "')";//SQL语句向表中写入数据  
                        dao1.Execute(sql2);
                       
                        dao1.DaoClose();
                            DialogResult dr = MessageBox.Show("是否返回登录界面", "注册成功", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dr == DialogResult.Yes)//打开注册界面
                            {

                                Form1 form1 = new Form1();
                                this.Hide();
                                form1.ShowDialog();
                                Application.ExitThread();
                            }
                            else
                            {
                            textBox_register_name.Text = "";
                            textBox_register_secret.Text = "";
                            textBox_register_confirm.Text = "";
                                this.Show();
                            }

                        }
                        else
                        {
                            MessageBox.Show("两次输入密码不一致", "错误信息");
                        textBox_register_name.Text = "";
                        textBox_register_secret.Text = "";
                        textBox_register_confirm.Text = "";
                    }
                    }
                }
            }


        
    }
}

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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1__Click(object sender, EventArgs e)
        {
            this.Close();//调用后关闭窗口
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //让窗体最大化按钮不可用，使窗体边框不可拖动
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            //设置用户名、密码Textbox的属性
            textBox_name.MaxLength = 20;
            textBox_name.MaxLength = 20;
            textBox_secret.PasswordChar = '*';//使密码显现使为“*”


        }

        private void button_comfirm1_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text != "" && textBox_secret.Text != "")
            {
                loginCheck();
            }
            else
            {
                MessageBox.Show("账号和密码不能为空");
            }
        }

        private void loginCheck()
        {
             
                  Dao dao = new Dao();//实例化数据库对象
                  string sql = "select * from cs.users where id_name='" + textBox_name.Text + "' and secret='" + textBox_secret.Text + "'";
                  IDataReader dc = dao.read(sql);
                if (dc.Read())
                {
                    Data.UID = dc["secret"].ToString();
                    Data.UName = dc["id_name"].ToString();

                    MessageBox.Show("用户角色登录成功");
                this.Hide();
           
                Form2 form2 = new Form2();
                form2.ShowDialog();
                Application.ExitThread();
              
            }
                else
                {
                  
                    MessageBox.Show("密码错误，登录失败");
              
                }
                dao.DaoClose();
            

        }

        private void label_register_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Application.ExitThread();
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
    class Data
    {
        public static string UID = "", UName = "";//登录用户的id和姓名
    }

    class Dao
    {
        NpgsqlConnection SqlConn;
        public NpgsqlConnection connect()
        {
            string ConStr = @"PORT=5432;DATABASE=gisc;HOST=192.168.165.128;PASSWORD=123456;USER ID=chinwe";//配置数据库
            SqlConn = new NpgsqlConnection(ConStr);//创建数据库连接对象
            SqlConn.Open();//打开数据库
            return SqlConn;//返回数据库连接对象
        }
        public NpgsqlCommand command(string SqlConn)
        {
            NpgsqlCommand cmd = new NpgsqlCommand(SqlConn, connect());
            return cmd;
        }
        public int Execute(string SqlConn)//更新操作
        {
            return command(SqlConn).ExecuteNonQuery();
        }
        public NpgsqlDataReader read(string SqlConn)//读取操作
        {
            return command(SqlConn).ExecuteReader();
        }
        public void DaoClose()
        {
           SqlConn.Close();//关闭数据库
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceStack.Redis;
namespace k
{
    public partial class sign_in : Form
    {
        public sign_in()
        {
            InitializeComponent();
        }
        RedisClient cli;
        private void button1_Click(object sender, EventArgs e)
        {
            cli = new RedisClient("127.0.0.1",6379);    //127.0.0.1是本机ip地址，6379是默认端口号   
            string s1, s2, s3;
            s1 = username.Text;
            s2 = pwd.Text;
            s3 = pwd1.Text;
            if (s1 == cli.Get<string>("username"))//当用户输入的用户名被注册过
                MessageBox.Show("该用户已存在！");
            else
            {
               
                bool result = String.Equals(s2, s3);
                if (result == false)//两次密码输入不一致
                { 
                    pwd1.Text = "";
                    MessageBox.Show ("密码不一致，请重新输入","无法注册");
                }
                else if (s1 != "" && s1 != "" && s3 != "" && result == true)
                {
                    cli.Set<string>("username", s1);
                    cli.Set<string>("pwd", s2);
                    cli.Set<string>("pwd1", s3);
                    MessageBox.Show("注册成功");
                }
                else
                {

                }
            }
        }     
    }
}

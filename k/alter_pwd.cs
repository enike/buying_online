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
    public partial class alter_pwd : Form
    {
        RedisClient cli = new RedisClient("127.0.0.1",6379);
        public alter_pwd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1, s2;
            s1 = txt_2.Text;
            s2 = txt_3.Text;
            bool is_true = string.Equals(s1,s2);
            if (is_true ==false )
                MessageBox.Show("密码不一致");
            else {
                Login f = new Login();
              cli.Del(f.s2);
                cli.Set<string>("pwd",s1);
                MessageBox.Show("更改成功");
            }
        }
    }
}

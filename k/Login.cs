using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceStack.Redis;//引用驱动
namespace k
{
    public partial class Login : Form
    {
        RedisClient client ;//= new RedisClient("127.0.0.1",6379);     
        public string s1=null, s2=null;
        public string url;
        public Login()
        {
            InitializeComponent();//初始化工作
          //  this.BackgroundImage = Image.FromFile("F:\\source\006.jpg");
            /*
             c#连接到数据库(sql)
             * 先打开两个类库文件
             * SqlConnection con=new SqlConnection();
             * con.ConnectionString="server=;database=;user=;pwd=";
             * con.open();
             *   SqlCommand com=new SqlCommand();       
             * com.Connection=con;
             * com.CommandType=CommandType.Text;
             * com.CommandText="sql语句";
             * SqlDataReader dr=com.ExecuteReader();
             * dr.Close();
             * con.Close();                                      
                     */
        } 
       /* public delegate  void Welcome(string url);//创建委托
        public void Wec(string url)
        { 
        
        }*/
        public string  Getusername()
        {
            return username.Text.ToString();
        }
        private void b1_Click(object sender, EventArgs e)
        {
            client = new RedisClient("127.0.0.1", 6379);
            s1 = username.Text;
            s2 = pwd.Text;
            if (s1 == "")
                MessageBox.Show("用户名不能为空！");
            else
            {
                if (s2 == "")
                    MessageBox.Show("密码不能为空！");
                else if (client.Get<string>(s1) == s2 && client.Exists(s1) == 1)
                {
                    this.Visible = false;
                    Login_in f = new Login_in();
                    url = username.Text;
                    f.user = url;
                    f.ShowDialog();
                }
                else
                    MessageBox.Show("登录失败！");


            }
        
        }

        private void b2_Click(object sender, EventArgs e)
        {
            username.Text = "";
            pwd.Text = "";
        }

        private void username_Enter(object sender, EventArgs e)
        {
              if (this.username.Text == "请输入您的密码：")
            
                this.username.Text = "";
        }

        private void username_Leave(object sender, EventArgs e)
        {

         if (this.username.Text=="")          
                this.username.Text = "请输入您的密码：";
       username.ForeColor = Color.LightGray;
            }
        bool  istrue=false;

        private void pwd_Enter(object sender, EventArgs e)//焦点状态
        {
            if (istrue == true)
            {
                this.pwd.Text = "";
                pwd.ForeColor = Color.LightGray;
            }
        }   
        private void pwd_Leave(object sender, EventArgs e)
        {
            if (this.pwd.Text == "")
            {
                istrue = false;
                this.pwd.Text = "请输入您的密码：";
                pwd.ForeColor = Color.LightGray;
            }
            else { istrue = true; }
        }

        private void l_to_html_Click(object sender, EventArgs e)
        {
            sign_in f3 = new sign_in();
            f3.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
     
    }
}

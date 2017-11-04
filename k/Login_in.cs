using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceStack.Redis;
namespace k
{
    
    public partial class Login_in : Form
    {
        private string enter = null;
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        int pagesize = 5;          //每页显示的记录数
        int Max = 0;        //总记录数
        int pagecount = 0;//总页数
        int pagecurrent = 0;//当前 页数
        int current = 0;//当前记录数
        int start = 0;//每次刷新的起始行
        int end = 0;//每次刷新的末行
        private void setenter(string enter)
        {
            this.enter = enter;
        }
        public void sql()
        {
            SqlConnection coon = new SqlConnection("Server=127.0.0.1;DataBase=网上购书;uid=sa;pwd=1433");
            coon.Open();
            string str = "select * from BookInfor where Bookname like '%"+ enter + "%'";
            SqlCommand sql = new SqlCommand(str);
            SqlDataAdapter da = new SqlDataAdapter(str,coon);
            
            da.Fill(ds,"ds");
            coon.Close();
            dt = ds.Tables[0];

        }
        RedisClient cli=new RedisClient("127.0.0.1",6379);
        public string user = null;
        public Login_in()
        {
            InitializeComponent();
        }
        private void initdata()
        {
            pagecount = Max / pagesize;//获得页数
            if(Max%pagesize != 0) pagecount++;
            pagecurrent = 1;//当前页数
            current = 0;//当前行数
            
        }
        private void printdata()
        {
            loaddata();
            for (int i = start; i < end; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    d_result.Rows.Add();
                    d_result.Rows[i - start].Cells[j].Value = ds.Tables[0].Rows[i][j];
                }
                current++;
            }
            pagecurrent++;
        }
        private void loaddata()
        {
            if (current == Max)
            {
                end = Max;
            }
            else
            {
                end =current+ pagesize;
            }
            if (end >= Max) end = Max;
            start = current;
            

        }
        private void Gettime()
        {       
            this.l_time.Text = "Login Time：" + DateTime.Now.ToString();
        }     
        private void b_search_Click(object sender, EventArgs e)
        {
            this.setenter(t_input.Text);//数据库查询语句赋值
            sql();//连接数据库，将查询到的数据放到dataset
            foreach(DataRow col in ds.Tables[0].Rows) Max++; //最大行数Max
            initdata();//
            printdata();





            /*int flag = 0;//获取数据行数
            foreach (DataRow col in ds.Tables[0].Rows) flag++;
            

           
            for (int i = 0; i < flag; i++)
           {    
                for (int j = 0; j<=4; j++)
               {
                  d_result.Rows.Add();
                  d_result.Rows[i].Cells[j].Value = ds.Tables[0].Rows[i][j].ToString();
               }
            //    current++;
            }*/
            p_1.Visible = true;
           
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            this.Gettime();        
            l_user.Text = "欢迎您" + user;       
        
            p_1.Visible = false;//当用户不检索时不显示p_1面板
        }
        private void tool_2_Click(object sender, EventArgs e)
        {
            alter_pwd f5= new alter_pwd();
            f5.ShowDialog();
        }
        private void tool_3_Click(object sender, EventArgs e)
        {
            shop_address f6 = new shop_address();
            f6.ShowDialog();
        }
        private void tool_5_Click(object sender, EventArgs e)
        {
            Shop_car f4 = new Shop_car();
            f4.ShowDialog();
        }
        private void toolS_6_Click(object sender, EventArgs e)
        {
            My_accont f7 = new My_accont();
            f7.ShowDialog();
        }
        private void tool_7_Click(object sender, EventArgs e)
        {
            My_accont f7 = new My_accont();
            f7.ShowDialog();
        }
        private void t_exit_Click(object sender, EventArgs e)
        {        
            DialogResult s;
            s = MessageBox.Show("是否退出", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);//消息框有返回值
            if (s == DialogResult.OK)
            {              
                Login_in f = new Login_in();
                f.Close();
            }           
        }
        private void t_mora_game_Click(object sender, EventArgs e)
        {
            Game f = new Game();
            f.ShowDialog();
        }

        private void d_result_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Shop_car f = new Shop_car();
            f.b_a =d_result[0,0].Value.ToString () ;
            f.b_n = d_result[1,0].Value.ToString();
            f.b_p = d_result[3,0].Value.ToString();
            f.b_nu=d_result [4,0].Value .ToString ();
            f.un = d_result [2,0].Value .ToString ();
            f.Show();
        }
        private void t_input_Enter(object sender, EventArgs e)
        {
            if (t_input.Text == "")                   
                t_input.Text = "输入书名";

        }
        private void t_input_Leave(object sender, EventArgs e)
        {
            if (t_input.Text == "输入书名")
                t_input.Text = "";
        }

        private void l_link_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("F:/C#/k/k/h_page.html");//从窗体跳转到html页面
        }

        private void First_Click(object sender, EventArgs e)//首页
        {

        }

        private void last_Click(object sender, EventArgs e)//上一页
        {
            

            if (pagecurrent > 1)
            {
                current -=(pagesize+end-start);
                d_result.Rows.Clear();
                pagecurrent-=2;
                printdata();
            }
            

        }

        private void next_Click(object sender, EventArgs e)//下一页
        {
            if (pagecurrent <= pagecount)
            {
                    d_result.Rows.Clear();
                    printdata();
            }
            
        }

        private void finall_Click(object sender, EventArgs e)//尾页
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }     
    }
}

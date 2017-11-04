using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k
{
   // public  delegate  string  Get_Result(string s1,string s2,string s3,string s4);
    public partial class Address : Form
    {      
        public Address()
        {
            InitializeComponent();
        }
        //写一个代理，传递文本框的值
     /*   public string get(string s1, string s2, string s3, string s4)
        {
            return null ;
        }*/
        private void b_sure_Click(object sender, EventArgs e)
        {
            //将t_1,t_2,t_3,t_4的值传递到Form6
            shop_address f = new shop_address();
            f.s1 = t_1.Text;
            f.s2 = t_2.Text;
            f.s3 = t_3.Text;
            f.s4 = t_4.Text;
            f.Show();
            this.Close();       //保存成功后关闭窗口
        }
    }
}

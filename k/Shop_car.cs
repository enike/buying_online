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
    public partial class Shop_car : Form
    {

        public double sum,price;//price是我的账户里的余额，sun是买书所需的钱
      public string un; //单价
     
        public string s1;
        public Shop_car()
        {
            InitializeComponent();
            t_1.ReadOnly = true;
        }
     
        public string  b_n,b_a,b_p,b_nu;//分别是书名，作者，出版社，书的库存量
        private void Shop_car_Load(object sender, EventArgs e)
        {
            buy_book_num.SelectedIndex = 0;
            t_1.Text = "你的宝贝:" + b_n + "  出版社:" + b_p + "  作者:" + b_a+"  当前的库存量:"+b_nu+"单价"+un;
        }

        private void b_buy_Click(object sender, EventArgs e)
        {         
            if (Convert .ToInt32 (b_nu )< Convert.ToInt32(buy_book_num))//库存量不够，无法购买  
                MessageBox.Show("当前库存不足");
            else
            {
                if (Convert.ToDouble(price) < Convert.ToDouble(un) * Convert.ToInt32(b_nu))//获取余额,金额不足充值
                    MessageBox.Show("您的余额不足，无法购买，请先充值");
                else
                {
                    MessageBox.Show("购买成功");//提示购买成功,(做三件事)在My_account里显示购买记录，在Login_in里修改库存，在My_account里修改我的余额             
                    My_accont f = new My_accont();
                    f.history_of_buy = t_1.Text;
                    Login_in f1 = new Login_in();                 
                }
            }
        }
        private void b_cancel_Click(object sender, EventArgs e)
        {
            t_1.Text = ""; 
        }    
    }
}

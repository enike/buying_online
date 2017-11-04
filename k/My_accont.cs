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
    public partial class My_accont : Form
    {
        RedisClient cli = new RedisClient("127.0.0.1",6379);
        public My_accont()
        {
            InitializeComponent();
        }
        public string history_of_buy;
        private void My_accont_Load(object sender, EventArgs e)
        {
            s_money.Text = cli.Get<string>("my_account").ToString ();
            //在我的消费清单里显示买的书，花的钱，剩余的钱
          Shop_car f=new Shop_car ();
          f.price = Convert.ToDouble(s_money.Text);
          s_log.Text = history_of_buy;
        }

        private void b_1_Click(object sender, EventArgs e)
        {
            Label l_1 = new Label();
            TextBox bank_id = new TextBox();
            l_1.Text = "输入银行卡号";
            this.Controls.Add(l_1);
            this.Controls.Add(bank_id );
          if(bank_id.Text ==cli.Get<string>("bank").ToString ())//卡号一致
              s_money .Text+=t_recharge.Text;//充值     
          s_log.Text = "银行卡充值"+t_recharge.Text;
        }
    }
}

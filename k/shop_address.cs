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
    public partial class shop_address : Form
    {
        public string s1, s2, s3, s4;
        public shop_address()
        {
            InitializeComponent();
        }

        private void b_1_Click(object sender, EventArgs e)
        {
            Address f = new Address();
            this.Close ();
            f.ShowDialog();       
        }

        private void shop_address_Load(object sender, EventArgs e)
        {
            get_values.Text ="您的详细地址是：" +s3 + s4;
        }

        private void get_values_TextChanged(object sender, EventArgs e)
        {

        }

     
    }
}

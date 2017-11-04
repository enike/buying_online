namespace k
{
    partial class Shop_car
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buy_book_num = new System.Windows.Forms.ComboBox();
            this.b_num = new System.Windows.Forms.Label();
            this.t_1 = new System.Windows.Forms.TextBox();
            this.b_cancel = new System.Windows.Forms.Button();
            this.b_buy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buy_book_num
            // 
            this.buy_book_num.FormattingEnabled = true;
            this.buy_book_num.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.buy_book_num.Location = new System.Drawing.Point(146, 153);
            this.buy_book_num.Name = "buy_book_num";
            this.buy_book_num.Size = new System.Drawing.Size(121, 20);
            this.buy_book_num.TabIndex = 2;
            // 
            // b_num
            // 
            this.b_num.AutoSize = true;
            this.b_num.Location = new System.Drawing.Point(54, 156);
            this.b_num.Name = "b_num";
            this.b_num.Size = new System.Drawing.Size(65, 12);
            this.b_num.TabIndex = 3;
            this.b_num.Text = "购买数量：";
            // 
            // t_1
            // 
            this.t_1.Location = new System.Drawing.Point(1, 12);
            this.t_1.Multiline = true;
            this.t_1.Name = "t_1";
            this.t_1.Size = new System.Drawing.Size(289, 98);
            this.t_1.TabIndex = 6;
            // 
            // b_cancel
            // 
            this.b_cancel.Image = global::k.Properties.Resources.delete;
            this.b_cancel.Location = new System.Drawing.Point(182, 207);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(75, 33);
            this.b_cancel.TabIndex = 8;
            this.b_cancel.UseVisualStyleBackColor = true;
            this.b_cancel.Click += new System.EventHandler(this.b_cancel_Click);
            // 
            // b_buy
            // 
            this.b_buy.Image = global::k.Properties.Resources.buy;
            this.b_buy.Location = new System.Drawing.Point(44, 207);
            this.b_buy.Name = "b_buy";
            this.b_buy.Size = new System.Drawing.Size(75, 33);
            this.b_buy.TabIndex = 7;
            this.b_buy.UseVisualStyleBackColor = true;
            this.b_buy.Click += new System.EventHandler(this.b_buy_Click);
            // 
            // Shop_car
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 262);
            this.Controls.Add(this.b_cancel);
            this.Controls.Add(this.b_buy);
            this.Controls.Add(this.t_1);
            this.Controls.Add(this.b_num);
            this.Controls.Add(this.buy_book_num);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Shop_car";
            this.Text = "我的购物车";
            this.Load += new System.EventHandler(this.Shop_car_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox buy_book_num;
        private System.Windows.Forms.Label b_num;
        private System.Windows.Forms.TextBox t_1;
        private System.Windows.Forms.Button b_buy;
        private System.Windows.Forms.Button b_cancel;
    }
}
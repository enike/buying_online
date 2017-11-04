namespace k
{
    partial class My_accont
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
            this.money = new System.Windows.Forms.Label();
            this.s_money = new System.Windows.Forms.TextBox();
            this.s_log = new System.Windows.Forms.TextBox();
            this.l_1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.t_recharge = new System.Windows.Forms.TextBox();
            this.b_1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // money
            // 
            this.money.AutoSize = true;
            this.money.Location = new System.Drawing.Point(29, 28);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(65, 12);
            this.money.TabIndex = 0;
            this.money.Text = "我的余额：";
            // 
            // s_money
            // 
            this.s_money.Location = new System.Drawing.Point(119, 25);
            this.s_money.Name = "s_money";
            this.s_money.ReadOnly = true;
            this.s_money.Size = new System.Drawing.Size(126, 21);
            this.s_money.TabIndex = 1;
            // 
            // s_log
            // 
            this.s_log.Location = new System.Drawing.Point(-2, 139);
            this.s_log.Multiline = true;
            this.s_log.Name = "s_log";
            this.s_log.Size = new System.Drawing.Size(284, 111);
            this.s_log.TabIndex = 2;
            // 
            // l_1
            // 
            this.l_1.AutoSize = true;
            this.l_1.Location = new System.Drawing.Point(12, 124);
            this.l_1.Name = "l_1";
            this.l_1.Size = new System.Drawing.Size(101, 12);
            this.l_1.TabIndex = 3;
            this.l_1.Text = "我的消费记录清单";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.t_recharge);
            this.panel1.Controls.Add(this.b_1);
            this.panel1.Location = new System.Drawing.Point(-2, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 72);
            this.panel1.TabIndex = 4;
            // 
            // t_recharge
            // 
            this.t_recharge.Location = new System.Drawing.Point(157, 17);
            this.t_recharge.Multiline = true;
            this.t_recharge.Name = "t_recharge";
            this.t_recharge.Size = new System.Drawing.Size(107, 39);
            this.t_recharge.TabIndex = 1;
            // 
            // b_1
            // 
            this.b_1.Image = global::k.Properties.Resources.money;
            this.b_1.Location = new System.Drawing.Point(14, 17);
            this.b_1.Name = "b_1";
            this.b_1.Size = new System.Drawing.Size(99, 39);
            this.b_1.TabIndex = 0;
            this.b_1.Text = "充值";
            this.b_1.UseVisualStyleBackColor = true;
            this.b_1.Click += new System.EventHandler(this.b_1_Click);
            // 
            // My_accont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.l_1);
            this.Controls.Add(this.s_log);
            this.Controls.Add(this.s_money);
            this.Controls.Add(this.money);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "My_accont";
            this.Text = "我的账户";
            this.Load += new System.EventHandler(this.My_accont_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label money;
        private System.Windows.Forms.TextBox s_money;
        private System.Windows.Forms.TextBox s_log;
        private System.Windows.Forms.Label l_1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox t_recharge;
        private System.Windows.Forms.Button b_1;
    }
}
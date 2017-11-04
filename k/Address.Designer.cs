namespace k
{
    partial class Address
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
            this.l_1 = new System.Windows.Forms.Label();
            this.l_2 = new System.Windows.Forms.Label();
            this.l_3 = new System.Windows.Forms.Label();
            this.l_4 = new System.Windows.Forms.Label();
            this.t_4 = new System.Windows.Forms.TextBox();
            this.t_1 = new System.Windows.Forms.TextBox();
            this.t_2 = new System.Windows.Forms.TextBox();
            this.t_3 = new System.Windows.Forms.TextBox();
            this.b_sure = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_1
            // 
            this.l_1.AutoSize = true;
            this.l_1.Location = new System.Drawing.Point(91, 23);
            this.l_1.Name = "l_1";
            this.l_1.Size = new System.Drawing.Size(41, 12);
            this.l_1.TabIndex = 0;
            this.l_1.Text = "收货人";
            // 
            // l_2
            // 
            this.l_2.AutoSize = true;
            this.l_2.Location = new System.Drawing.Point(79, 62);
            this.l_2.Name = "l_2";
            this.l_2.Size = new System.Drawing.Size(53, 12);
            this.l_2.TabIndex = 1;
            this.l_2.Text = "联系方式";
            // 
            // l_3
            // 
            this.l_3.AutoSize = true;
            this.l_3.Location = new System.Drawing.Point(79, 103);
            this.l_3.Name = "l_3";
            this.l_3.Size = new System.Drawing.Size(53, 12);
            this.l_3.TabIndex = 2;
            this.l_3.Text = "所在区域";
            // 
            // l_4
            // 
            this.l_4.AutoSize = true;
            this.l_4.Location = new System.Drawing.Point(79, 147);
            this.l_4.Name = "l_4";
            this.l_4.Size = new System.Drawing.Size(53, 12);
            this.l_4.TabIndex = 3;
            this.l_4.Text = "详细地址";
            // 
            // t_4
            // 
            this.t_4.Location = new System.Drawing.Point(168, 132);
            this.t_4.Multiline = true;
            this.t_4.Name = "t_4";
            this.t_4.Size = new System.Drawing.Size(205, 40);
            this.t_4.TabIndex = 4;
            // 
            // t_1
            // 
            this.t_1.Location = new System.Drawing.Point(168, 23);
            this.t_1.Name = "t_1";
            this.t_1.Size = new System.Drawing.Size(100, 21);
            this.t_1.TabIndex = 5;
            // 
            // t_2
            // 
            this.t_2.Location = new System.Drawing.Point(168, 62);
            this.t_2.Name = "t_2";
            this.t_2.Size = new System.Drawing.Size(100, 21);
            this.t_2.TabIndex = 6;
            // 
            // t_3
            // 
            this.t_3.Location = new System.Drawing.Point(168, 100);
            this.t_3.Name = "t_3";
            this.t_3.Size = new System.Drawing.Size(100, 21);
            this.t_3.TabIndex = 7;
            // 
            // b_sure
            // 
            this.b_sure.Image = global::k.Properties.Resources.address;
            this.b_sure.Location = new System.Drawing.Point(380, 1);
            this.b_sure.Name = "b_sure";
            this.b_sure.Size = new System.Drawing.Size(93, 43);
            this.b_sure.TabIndex = 8;
            this.b_sure.Text = "保存";
            this.b_sure.UseVisualStyleBackColor = true;
            this.b_sure.Click += new System.EventHandler(this.b_sure_Click);
            // 
            // Address
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::k.Properties.Resources.xi_an;
            this.ClientSize = new System.Drawing.Size(472, 234);
            this.Controls.Add(this.b_sure);
            this.Controls.Add(this.t_3);
            this.Controls.Add(this.t_2);
            this.Controls.Add(this.t_1);
            this.Controls.Add(this.t_4);
            this.Controls.Add(this.l_4);
            this.Controls.Add(this.l_3);
            this.Controls.Add(this.l_2);
            this.Controls.Add(this.l_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Address";
            this.Text = "添加新地址";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_1;
        private System.Windows.Forms.Label l_2;
        private System.Windows.Forms.Label l_3;
        private System.Windows.Forms.Label l_4;
        private System.Windows.Forms.TextBox t_4;
        private System.Windows.Forms.TextBox t_1;
        private System.Windows.Forms.TextBox t_2;
        private System.Windows.Forms.TextBox t_3;
        private System.Windows.Forms.Button b_sure;
    }
}
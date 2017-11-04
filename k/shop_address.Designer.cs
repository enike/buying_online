namespace k
{
    partial class shop_address
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
            this.b_1 = new System.Windows.Forms.Button();
            this.get_values = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // b_1
            // 
            this.b_1.Location = new System.Drawing.Point(-6, 258);
            this.b_1.Name = "b_1";
            this.b_1.Size = new System.Drawing.Size(301, 33);
            this.b_1.TabIndex = 0;
            this.b_1.Text = "添加新地址";
            this.b_1.UseVisualStyleBackColor = true;
            this.b_1.Click += new System.EventHandler(this.b_1_Click);
            // 
            // get_values
            // 
            this.get_values.Location = new System.Drawing.Point(12, 12);
            this.get_values.Multiline = true;
            this.get_values.Name = "get_values";
            this.get_values.ReadOnly = true;
            this.get_values.Size = new System.Drawing.Size(271, 240);
            this.get_values.TabIndex = 1;
            this.get_values.TextChanged += new System.EventHandler(this.get_values_TextChanged);
            // 
            // shop_address
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 288);
            this.Controls.Add(this.get_values);
            this.Controls.Add(this.b_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "shop_address";
            this.Text = "地址";
            this.Load += new System.EventHandler(this.shop_address_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_1;
        private System.Windows.Forms.TextBox get_values;
    }
}
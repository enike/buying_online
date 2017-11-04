namespace k
{
    partial class alter_pwd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(alter_pwd));
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.txt_1 = new System.Windows.Forms.TextBox();
            this.txt_2 = new System.Windows.Forms.TextBox();
            this.txt_3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.ForeColor = System.Drawing.Color.Red;
            this.l1.Location = new System.Drawing.Point(82, 53);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(53, 12);
            this.l1.TabIndex = 0;
            this.l1.Text = "旧密码：";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.l2.Location = new System.Drawing.Point(82, 95);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(53, 12);
            this.l2.TabIndex = 1;
            this.l2.Text = "新密码：";
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.l3.Location = new System.Drawing.Point(82, 142);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(53, 12);
            this.l3.TabIndex = 2;
            this.l3.Text = "确认密码";
            // 
            // txt_1
            // 
            this.txt_1.Location = new System.Drawing.Point(188, 44);
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(100, 21);
            this.txt_1.TabIndex = 3;
            // 
            // txt_2
            // 
            this.txt_2.Location = new System.Drawing.Point(188, 92);
            this.txt_2.Name = "txt_2";
            this.txt_2.PasswordChar = '*';
            this.txt_2.Size = new System.Drawing.Size(100, 21);
            this.txt_2.TabIndex = 4;
            // 
            // txt_3
            // 
            this.txt_3.Location = new System.Drawing.Point(188, 142);
            this.txt_3.Name = "txt_3";
            this.txt_3.PasswordChar = '*';
            this.txt_3.Size = new System.Drawing.Size(100, 21);
            this.txt_3.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(124, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "更改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // alter_pwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(377, 264);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_3);
            this.Controls.Add(this.txt_2);
            this.Controls.Add(this.txt_1);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "alter_pwd";
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.TextBox txt_1;
        private System.Windows.Forms.TextBox txt_2;
        private System.Windows.Forms.TextBox txt_3;
        private System.Windows.Forms.Button button1;
    }
}
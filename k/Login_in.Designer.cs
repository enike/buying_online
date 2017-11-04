namespace k
{
    partial class Login_in
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_in));
            this.l_user = new System.Windows.Forms.Label();
            this.t_input = new System.Windows.Forms.TextBox();
            this.b_search = new System.Windows.Forms.Button();
            this.tool_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tool_2 = new System.Windows.Forms.ToolStripTextBox();
            this.tool_3 = new System.Windows.Forms.ToolStripTextBox();
            this.tool_4 = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_5 = new System.Windows.Forms.ToolStripTextBox();
            this.tool_6 = new System.Windows.Forms.ToolStripTextBox();
            this.tool_7 = new System.Windows.Forms.ToolStripTextBox();
            this.t_exit = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.t_game = new System.Windows.Forms.ToolStripMenuItem();
            this.t_mora_game = new System.Windows.Forms.ToolStripTextBox();
            this.l_time = new System.Windows.Forms.Label();
            this.d_result = new System.Windows.Forms.DataGridView();
            this.b_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_publish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_pic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_tobuy = new System.Windows.Forms.DataGridViewButtonColumn();
            this.l_link = new System.Windows.Forms.LinkLabel();
            this.finall = new System.Windows.Forms.Button();
            this.last = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.First = new System.Windows.Forms.Button();
            this.p_1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.d_result)).BeginInit();
            this.p_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // l_user
            // 
            this.l_user.AutoSize = true;
            this.l_user.Location = new System.Drawing.Point(165, 15);
            this.l_user.Name = "l_user";
            this.l_user.Size = new System.Drawing.Size(0, 12);
            this.l_user.TabIndex = 0;
            // 
            // t_input
            // 
            this.t_input.Location = new System.Drawing.Point(137, 29);
            this.t_input.Name = "t_input";
            this.t_input.Size = new System.Drawing.Size(198, 21);
            this.t_input.TabIndex = 1;
            this.t_input.Enter += new System.EventHandler(this.t_input_Enter);
            this.t_input.Leave += new System.EventHandler(this.t_input_Leave);
            // 
            // b_search
            // 
            this.b_search.Location = new System.Drawing.Point(364, 28);
            this.b_search.Name = "b_search";
            this.b_search.Size = new System.Drawing.Size(72, 21);
            this.b_search.TabIndex = 2;
            this.b_search.Text = "检索";
            this.b_search.UseVisualStyleBackColor = true;
            this.b_search.Click += new System.EventHandler(this.b_search_Click);
            // 
            // tool_1
            // 
            this.tool_1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.tool_2,
            this.tool_3});
            this.tool_1.Name = "tool_1";
            this.tool_1.Size = new System.Drawing.Size(44, 21);
            this.tool_1.Text = "设置";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // tool_2
            // 
            this.tool_2.Name = "tool_2";
            this.tool_2.Size = new System.Drawing.Size(100, 23);
            this.tool_2.Text = "修改密码";
            this.tool_2.Click += new System.EventHandler(this.tool_2_Click);
            // 
            // tool_3
            // 
            this.tool_3.Name = "tool_3";
            this.tool_3.Size = new System.Drawing.Size(100, 23);
            this.tool_3.Text = "收货地址";
            this.tool_3.Click += new System.EventHandler(this.tool_3_Click);
            // 
            // tool_4
            // 
            this.tool_4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_5,
            this.tool_6,
            this.tool_7,
            this.t_exit});
            this.tool_4.Name = "tool_4";
            this.tool_4.Size = new System.Drawing.Size(44, 21);
            this.tool_4.Text = "查看";
            // 
            // tool_5
            // 
            this.tool_5.Name = "tool_5";
            this.tool_5.Size = new System.Drawing.Size(100, 23);
            this.tool_5.Text = "购物车";
            this.tool_5.Click += new System.EventHandler(this.tool_5_Click);
            // 
            // tool_6
            // 
            this.tool_6.Name = "tool_6";
            this.tool_6.Size = new System.Drawing.Size(100, 23);
            this.tool_6.Text = "我的账户";
            this.tool_6.Click += new System.EventHandler(this.toolS_6_Click);
            // 
            // tool_7
            // 
            this.tool_7.Name = "tool_7";
            this.tool_7.Size = new System.Drawing.Size(100, 23);
            this.tool_7.Text = "足迹";
            this.tool_7.Click += new System.EventHandler(this.tool_7_Click);
            // 
            // t_exit
            // 
            this.t_exit.Name = "t_exit";
            this.t_exit.Size = new System.Drawing.Size(100, 23);
            this.t_exit.Text = "退出当前账户";
            this.t_exit.Click += new System.EventHandler(this.t_exit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_1,
            this.tool_4,
            this.t_game});
            this.menuStrip1.Location = new System.Drawing.Point(2, 2);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(603, 25);
            this.menuStrip1.TabIndex = 9;
            // 
            // t_game
            // 
            this.t_game.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.t_mora_game});
            this.t_game.Name = "t_game";
            this.t_game.Size = new System.Drawing.Size(44, 21);
            this.t_game.Text = "娱乐";
            // 
            // t_mora_game
            // 
            this.t_mora_game.Name = "t_mora_game";
            this.t_mora_game.Size = new System.Drawing.Size(100, 23);
            this.t_mora_game.Text = "猜拳游戏";
            this.t_mora_game.Click += new System.EventHandler(this.t_mora_game_Click);
            // 
            // l_time
            // 
            this.l_time.AutoSize = true;
            this.l_time.Location = new System.Drawing.Point(320, 6);
            this.l_time.Name = "l_time";
            this.l_time.Size = new System.Drawing.Size(0, 12);
            this.l_time.TabIndex = 10;
            // 
            // d_result
            // 
            this.d_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.d_result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.b_name,
            this.b_author,
            this.b_price,
            this.b_publish,
            this.b_number,
            this.b_pic,
            this.is_tobuy});
            this.d_result.Location = new System.Drawing.Point(2, 5);
            this.d_result.MultiSelect = false;
            this.d_result.Name = "d_result";
            this.d_result.RowTemplate.Height = 23;
            this.d_result.Size = new System.Drawing.Size(592, 215);
            this.d_result.TabIndex = 11;
            this.d_result.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.d_result_CellContentClick);
            // 
            // b_name
            // 
            this.b_name.HeaderText = "书名";
            this.b_name.Name = "b_name";
            this.b_name.Width = 80;
            // 
            // b_author
            // 
            this.b_author.HeaderText = "作者";
            this.b_author.Name = "b_author";
            this.b_author.Width = 80;
            // 
            // b_price
            // 
            this.b_price.HeaderText = "价格";
            this.b_price.Name = "b_price";
            this.b_price.Width = 80;
            // 
            // b_publish
            // 
            this.b_publish.HeaderText = "出版社";
            this.b_publish.Name = "b_publish";
            // 
            // b_number
            // 
            this.b_number.HeaderText = "数量";
            this.b_number.Name = "b_number";
            this.b_number.Width = 80;
            // 
            // b_pic
            // 
            this.b_pic.HeaderText = "书面";
            this.b_pic.Name = "b_pic";
            // 
            // is_tobuy
            // 
            this.is_tobuy.HeaderText = "添加";
            this.is_tobuy.Name = "is_tobuy";
            this.is_tobuy.Width = 30;
            // 
            // l_link
            // 
            this.l_link.AutoSize = true;
            this.l_link.LinkArea = new System.Windows.Forms.LinkArea(2, 2);
            this.l_link.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.l_link.Location = new System.Drawing.Point(562, 33);
            this.l_link.Name = "l_link";
            this.l_link.Size = new System.Drawing.Size(29, 19);
            this.l_link.TabIndex = 12;
            this.l_link.Text = "介绍";
            this.l_link.UseCompatibleTextRendering = true;
            this.l_link.Click += new System.EventHandler(this.l_link_Click);
            // 
            // finall
            // 
            this.finall.Location = new System.Drawing.Point(430, 220);
            this.finall.Name = "finall";
            this.finall.Size = new System.Drawing.Size(45, 20);
            this.finall.TabIndex = 13;
            this.finall.Text = "尾页";
            this.finall.UseVisualStyleBackColor = true;
            this.finall.Click += new System.EventHandler(this.finall_Click);
            // 
            // last
            // 
            this.last.Location = new System.Drawing.Point(199, 220);
            this.last.Name = "last";
            this.last.Size = new System.Drawing.Size(51, 20);
            this.last.TabIndex = 14;
            this.last.Text = "上一页";
            this.last.UseVisualStyleBackColor = true;
            this.last.Click += new System.EventHandler(this.last_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(317, 220);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(51, 20);
            this.next.TabIndex = 15;
            this.next.Text = "下一页";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // First
            // 
            this.First.Location = new System.Drawing.Point(94, 220);
            this.First.Name = "First";
            this.First.Size = new System.Drawing.Size(42, 20);
            this.First.TabIndex = 16;
            this.First.Text = "首页";
            this.First.UseVisualStyleBackColor = true;
            this.First.Click += new System.EventHandler(this.First_Click);
            // 
            // p_1
            // 
            this.p_1.Controls.Add(this.d_result);
            this.p_1.Controls.Add(this.finall);
            this.p_1.Controls.Add(this.next);
            this.p_1.Controls.Add(this.First);
            this.p_1.Controls.Add(this.last);
            this.p_1.Location = new System.Drawing.Point(5, 54);
            this.p_1.Name = "p_1";
            this.p_1.Size = new System.Drawing.Size(597, 243);
            this.p_1.TabIndex = 17;
            // 
            // Login_in
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(605, 300);
            this.Controls.Add(this.p_1);
            this.Controls.Add(this.l_link);
            this.Controls.Add(this.l_time);
            this.Controls.Add(this.b_search);
            this.Controls.Add(this.t_input);
            this.Controls.Add(this.l_user);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Login_in";
            this.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.Text = "在线购书系统";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.d_result)).EndInit();
            this.p_1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_user;
        private System.Windows.Forms.TextBox t_input;
        private System.Windows.Forms.Button b_search;
        private System.Windows.Forms.ToolStripMenuItem tool_1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox tool_2;
        private System.Windows.Forms.ToolStripTextBox tool_3;
        private System.Windows.Forms.ToolStripMenuItem tool_4;
        private System.Windows.Forms.ToolStripTextBox tool_5;
        private System.Windows.Forms.ToolStripTextBox tool_6;
        private System.Windows.Forms.ToolStripTextBox tool_7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label l_time;
        private System.Windows.Forms.ToolStripTextBox t_exit;
        private System.Windows.Forms.ToolStripMenuItem t_game;
        private System.Windows.Forms.ToolStripTextBox t_mora_game;
        private System.Windows.Forms.DataGridView d_result;
        private System.Windows.Forms.LinkLabel l_link;
        private System.Windows.Forms.Button finall;
        private System.Windows.Forms.Button last;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button First;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_author;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_publish;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_pic;
        private System.Windows.Forms.DataGridViewButtonColumn is_tobuy;
        private System.Windows.Forms.Panel p_1;



    }
}
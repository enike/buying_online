namespace k
{
    partial class Game
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
            this.l_player = new System.Windows.Forms.Label();
            this.l_computer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l_player
            // 
            this.l_player.AutoSize = true;
            this.l_player.Location = new System.Drawing.Point(95, 31);
            this.l_player.Name = "l_player";
            this.l_player.Size = new System.Drawing.Size(41, 12);
            this.l_player.TabIndex = 0;
            this.l_player.Text = "玩家：";
            // 
            // l_computer
            // 
            this.l_computer.AutoSize = true;
            this.l_computer.Location = new System.Drawing.Point(354, 31);
            this.l_computer.Name = "l_computer";
            this.l_computer.Size = new System.Drawing.Size(41, 12);
            this.l_computer.TabIndex = 1;
            this.l_computer.Text = "电脑：";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 275);
            this.Controls.Add(this.l_computer);
            this.Controls.Add(this.l_player);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Game";
            this.Text = "猜拳小游戏";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_player;
        private System.Windows.Forms.Label l_computer;
    }
}
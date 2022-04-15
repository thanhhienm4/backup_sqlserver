namespace Backup_Restore
{
    partial class loginForm
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
            this.grDangNhap = new System.Windows.Forms.GroupBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.lblServerName = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.grDangNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // grDangNhap
            // 
            this.grDangNhap.BackColor = System.Drawing.Color.White;
            this.grDangNhap.Controls.Add(this.txtPassWord);
            this.grDangNhap.Controls.Add(this.label2);
            this.grDangNhap.Controls.Add(this.txtLogin);
            this.grDangNhap.Controls.Add(this.label1);
            this.grDangNhap.Controls.Add(this.txtServer);
            this.grDangNhap.Controls.Add(this.lblServerName);
            this.grDangNhap.Controls.Add(this.btnThoat);
            this.grDangNhap.Controls.Add(this.btnDangNhap);
            this.grDangNhap.Location = new System.Drawing.Point(163, 38);
            this.grDangNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grDangNhap.Name = "grDangNhap";
            this.grDangNhap.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grDangNhap.Size = new System.Drawing.Size(491, 292);
            this.grDangNhap.TabIndex = 1;
            this.grDangNhap.TabStop = false;
            this.grDangNhap.Text = "Đăng nhập";
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(204, 154);
            this.txtPassWord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(179, 23);
            this.txtPassWord.TabIndex = 9;
            this.txtPassWord.Text = "123456";
            this.txtPassWord.UseSystemPasswordChar = true;
            this.txtPassWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassWord_KeyPress);
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "PassWord";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(203, 110);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(179, 23);
            this.txtLogin.TabIndex = 7;
            this.txtLogin.Text = "SA";
            this.txtLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLogin_KeyPress);
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Login";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(203, 64);
            this.txtServer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(179, 23);
            this.txtServer.TabIndex = 5;
            this.txtServer.Text = "HIENM4";
            this.txtServer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtServer_KeyPress);
            // 
            // lblServerName
            // 
            this.lblServerName.AllowDrop = true;
            this.lblServerName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerName.Location = new System.Drawing.Point(105, 66);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(91, 26);
            this.lblServerName.TabIndex = 4;
            this.lblServerName.Text = "Server Name";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Transparent;
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::Backup_Restore.Properties.Resources.turn_off_32;
            this.btnThoat.Location = new System.Drawing.Point(268, 209);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(104, 53);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Image = global::Backup_Restore.Properties.Resources.turn_on_24;
            this.btnDangNhap.Location = new System.Drawing.Point(124, 209);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(104, 53);
            this.btnDangNhap.TabIndex = 0;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // loginForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 384);
            this.Controls.Add(this.grDangNhap);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.grDangNhap.ResumeLayout(false);
            this.grDangNhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDangNhap;
        internal System.Windows.Forms.GroupBox grDangNhap;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.Button btnThoat;
    }
}


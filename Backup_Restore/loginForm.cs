using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Backup_Restore
{
    public partial class loginForm : DevExpress.XtraEditors.XtraForm
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            executeLogin();
        }

        private void executeLogin()
        {
            txtLogin.Focus();
            if (txtServer.Text.Trim() == "" || txtLogin.Text.Trim() == "" || txtPassWord.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!\nMời nhập lại.", "Lỗi đăng nhập!", MessageBoxButtons.OK);
                return;
            }
            Program.serverName = txtServer.Text.Trim();
            Program.username = txtLogin.Text.Trim();
            Program.passWord = txtPassWord.Text.Trim();
            if (Program.KetNoi() == 0 )
            {
                return;
            }
            Program.conn.Close();


            try
            {
                Program.formMain = new FormMain();
                Program.formMain.Activate();
                Program.formMain.Show();
                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác" + ex.Message, "Error message", MessageBoxButtons.OK);
                txtLogin.Focus();
                return;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtServer.Text.Trim() != "" || txtPassWord.Text.Trim() != "" || txtLogin.Text.Trim() != "")
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn thoát không?", "Notification", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                executeLogin();
        }

        private void txtPassWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                executeLogin();

        }

        private void txtServer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                executeLogin();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }
    }
}

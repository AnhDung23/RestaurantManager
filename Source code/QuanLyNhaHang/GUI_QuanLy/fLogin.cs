using BUS_QuanLy;
using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QuanLy
{
    public partial class fLogin : Form
    {
        AccountBUS bus = new AccountBUS();
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            AccountDTO dto = bus.checkLogin(username, password);
            if(dto == null)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không hợp lệ");
            }
            else
            {
                fQuanLy form = new fQuanLy(dto);
                this.Hide();
                form.ShowDialog();
                txtPassword.Text = "";
            }
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn thực sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}

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
    public partial class fAccountProfile : Form
    {
        AccountBUS busAccount = new AccountBUS();
        AccountDTO accountLogin;
        public fAccountProfile(AccountDTO account)
        {
            accountLogin = account;
            InitializeComponent();
            showInfomation();
            
        }

        private void showInfomation()
        {
            txtUsername.Text = accountLogin.Username;
            txtFullname.Text = accountLogin.Fullname;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text.Trim();
            string fullname = txtFullname.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();
            string confirmPassword = txtConfirm.Text.Trim();

            string message = busAccount.updateAccount(username, password, fullname, newPassword, confirmPassword);
            MessageBox.Show(message);           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

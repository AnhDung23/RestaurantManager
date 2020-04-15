using DAO_QuanLy;
using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QuanLy
{
    public class AccountBUS
    {
        AccountDAO dao = new AccountDAO();

        public AccountDTO checkLogin(string username, string password)
        {
            AccountDTO dto = null;

            bool check = dao.checkLogin(username, password);
            if (check)
            {
                dto = dao.getUserByUsername(username);
            }
            return dto;
        }

        public AccountDTO getUserByUsername(string userID)
        {
            return dao.getUserByUsername(userID);
        }

        public string updateAccount(string username, string password, string fullname, string newPassword, string confirmPassword)
        {
            string message = "";
            if (password.Equals(""))
            {
                message = "Bạn cần nhập mật khẩu để xác nhận";
            }
            else
            {
                if (fullname.Length < 1 || fullname.Length > 40)
                {
                    message = "Tên yêu cầu phải từ 1 đến 40 ký tự";
                }
                else
                {
                    if (!newPassword.Equals(confirmPassword))
                    {
                        message = "Mật khẩu mới và mật khẩu xác nhận phải trùng nhau";
                    }
                    else
                    {
                        bool check = dao.checkLogin(username, password);
                        if (!check)
                        {
                            message = "Mật khẩu không hợp lệ";
                        }
                        else
                        {
                            if (!newPassword.Equals(""))
                            {
                                password = newPassword;
                            }
                            check = dao.updateAccount(username, password, fullname);
                            if (check)
                            {
                                message = "Cập nhật thành công" ;
                            }
                            else
                            {
                                message = "Cập nhật lỗi";
                            }
                        }

                    }
                }

            }
            return message;
        }

        public DataTable loadListUser()
        {
            return dao.loadListUser();
        }

        public DataTable searchUserByName(string valueSearch)
        {
            return dao.searchUserByName(valueSearch);
        }

        public string deleteAccount(string username)
        {
            string message = "";
            if (username.Equals(""))
            {
                message = "Bạn chưa chọn người dùng";
            }
            else
            {
                string status = "Inactive";
                bool check = dao.deleteAccount(username, status);
                if (check)
                {
                    message = "Xóa người dùng thành công";
                }
                else
                {
                    message = "Xóa người dùng lỗi";
                }
            }
            return message;
        }
    }
}

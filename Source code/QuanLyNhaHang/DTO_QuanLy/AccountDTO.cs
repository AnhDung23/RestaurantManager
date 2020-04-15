using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class AccountDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }

        public AccountDTO()
        {

        }

        public AccountDTO(string username, string password, string fullname, string role, string status)
        {
            Username = username;
            Password = password;
            Fullname = fullname;
            Role = role;
            Status = status;
        }
    }
}

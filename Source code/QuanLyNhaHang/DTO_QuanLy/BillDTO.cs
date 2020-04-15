using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class BillDTO
    {
        public int ID { get; set; }
        public DateTime DateCheckIn { get; set; }
        public DateTime DateCheckOut { get; set; }
        public string NameTable { get; set; }
        public string Status { get; set; }
        public string Staff { get; set; }
        public int Total { get; set; }

        public BillDTO()
        {
        }

        public BillDTO(int iD, DateTime dateCheckIn, string nameTable, string status, string staff)
        {
            ID = iD;
            DateCheckIn = dateCheckIn;
            NameTable = nameTable;
            Status = status;
            Staff = staff;
        }

        public BillDTO(int iD, DateTime dateCheckIn, DateTime dateCheckOut, string nameTable, string status, string staff, int total)
        {
            ID = iD;
            DateCheckIn = dateCheckIn;
            DateCheckOut = dateCheckOut;
            NameTable = nameTable;
            Status = status;
            Staff = staff;
            Total = total;
        }
    }
}

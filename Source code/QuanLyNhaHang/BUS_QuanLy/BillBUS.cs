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
    public class BillBUS
    {
        BillDAO dao = new BillDAO();

        public BillBUS()
        {

        }

        public int getBillUnCheckoutByNameTable(string nameTable)
        {
            string status = "Chưa thanh toán";
            return dao.getBillUnCheckoutByNameTable(nameTable, status);
        }

        public bool insertBill(BillDTO dto)
        {
            return dao.insertBill(dto);
        }

        public int getMaxIDBill()
        {
            return dao.getMaxIDBill();
        }

        public bool updateStatus(int idBill, string status, string staff)
        {
            return dao.updateStatus(idBill, status, staff);
        }

        public bool checkoutBill(TableFoodDTO table, string staff, int total)
        {
            BillBUS busBill = new BillBUS();
            int idBill = busBill.getBillUnCheckoutByNameTable(table.Name);
            DateTime checkOutDate = DateTime.Now;
            string status = "Đã thanh toán";
            bool check = dao.checkoutBill(idBill, staff, total, status, checkOutDate);
            if (check)
            {
                TableFoodBUS busTable = new TableFoodBUS();
                check = busTable.updateStatusTable(table.Name, "Trống");
            }
            return check;
        }

        public DataTable getListBillByDate(DateTime dateFrom, DateTime dateTo)
        {
            string status = "Đã thanh toán";
            return dao.getListBillByDate(dateFrom, dateTo, status);
        }

    }
}

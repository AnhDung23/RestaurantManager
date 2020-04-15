using DAO_QuanLy;
using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QuanLy
{
    public class BillInfoBUS
    {
        BillInfoDAO dao = new BillInfoDAO();
        
        public BillInfoBUS()
        {

        }

        public List<BillInfoDTO> getListBillInfoByIdBill(int idBillLoad)
        {
            return dao.getListBillInfoByIdBill(idBillLoad);
        }

        public int getMaxIDBillInfo()
        {
            return dao.getMaxIDBillInfo();
        }

        public int insertBillInfo(TableFoodDTO table, string food, int quantity)
        {
            bool check = false;
            BillBUS busBill = new BillBUS();
            int idBill = busBill.getBillUnCheckoutByNameTable(table.Name);

            if (idBill == 0)
            {
                idBill = busBill.getMaxIDBill() + 1;
                DateTime currentDate = DateTime.Now;
                string nameTable = table.Name;
                string status = "Chưa thanh toán";
                string staff = null;
                BillDTO dtoBill = new BillDTO(idBill, currentDate, nameTable, status, staff);
                check = busBill.insertBill(dtoBill);
                if (check)
                {
                    int idBillInfo = dao.getMaxIDBillInfo() + 1;
                    BillInfoDTO dtoBillInfo = new BillInfoDTO(idBillInfo, idBill, food, quantity);
                    check = dao.insertBillInfo(dtoBillInfo);
                    if (check)
                    {
                        string statusTable = "Có người";
                        TableFoodBUS busTable = new TableFoodBUS();
                        check = busTable.updateStatusTable(nameTable, statusTable);
                    }
                }
            }
            else
            {
                BillInfoDTO dtoBillInfo = dao.checkExistFoodInBill(idBill, food);
                if (dtoBillInfo != null)
                {
                    check = dao.updateQuantityBillInfo(dtoBillInfo.Id, quantity + dtoBillInfo.Quantity);
                }
                else
                {
                    int idBillInfo = dao.getMaxIDBillInfo() + 1;
                    dtoBillInfo = new BillInfoDTO(idBillInfo, idBill, food, quantity);
                    check = dao.insertBillInfo(dtoBillInfo);
                }
            }

            if (!check)
            {
                idBill = -1;
            }


            return idBill;
        }

        public bool updateQuantityBillInfo(int id, int quantity)
        {
            return dao.updateQuantityBillInfo(id, quantity);
        }

        public BillInfoDTO checkExistFoodInBill(int idBill, string food)
        {
            return dao.checkExistFoodInBill(idBill, food);
        }
    }
}

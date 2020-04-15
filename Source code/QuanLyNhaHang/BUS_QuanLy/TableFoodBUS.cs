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
    public class TableFoodBUS
    {
        TableFoodDAO dao = new TableFoodDAO();

        public List<TableFoodDTO> LoadAllTable()
        {
            return dao.LoadAllTable();
        }

        public bool updateStatusTable(string nameTb, string status)
        {
            return dao.updateStatusTable(nameTb, status);
        }

        public DataTable searchTableByName(string valueSearch)
        {
            return dao.searchTableByName(valueSearch);
        }

        public string addTable(String nameTable)
        {
            string message = "";
            if (nameTable.Equals(""))
            {
                message = "Bạn cần điền thông tin bàn ăn";
            }
            else
            {
                string status = "Trống";
                TableFoodDTO dto = new TableFoodDTO(nameTable, status);
                try
                {
                    bool check = dao.addTable(dto);
                    if (check)
                    {
                        message = "Thêm bàn ăn thành công";
                    }
                    else
                    {
                        message = "Thêm bàn ăn lỗi";
                    }
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("duplicate")) message = "Tên bàn đã tồn tại";
                }
            }
            return message;
        }

        public string deleteTable(String nameTable)
        {
            string message = "";
            if (nameTable.Equals(""))
            {
                message = "Bạn cần điền thông tin bàn ăn";
            }
            else
            {
                string status = "Inactive";
                TableFoodDTO dto = new TableFoodDTO(nameTable, status);
                bool check = dao.deleteTable(dto);
                if (check)
                {
                    message = "Xóa bàn ăn thành công";
                }
                else
                {
                    message = "Xóa bàn ăn lỗi";
                }
            }
            return message;
        }
    }
}

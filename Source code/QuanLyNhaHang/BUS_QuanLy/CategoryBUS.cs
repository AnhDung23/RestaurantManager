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
    public class CategoryBUS
    {
        CategoryDAO dao = new CategoryDAO();

        public CategoryBUS()
        {

        }

        public List<CategoryDTO> getListCategory()
        {
            return dao.getListCategory();
        }

        public CategoryDTO getCateByID(int id)
        {
            return dao.getCateByID(id);
        }

        public string addCate(string idCateTxt, string nameCate)
        {
            string message = "";
            if (idCateTxt.Equals("") || nameCate.Equals(""))
            {
                message = "Bạn cần điền đủ các thông tin danh mục";
            }
            else
            {
                try
                {
                    int id = Convert.ToInt32(idCateTxt.Trim());
                    if (id <= 0)
                    {
                        message = "ID phải là số nguyên lớn hơn 0";
                    }
                    else
                    {
                        string status = "Active";
                        CategoryDTO dto = new CategoryDTO(id, nameCate, status);
                        bool check = dao.addCate(dto);
                        if (check)
                        {
                            message = "Thêm danh mục thành công";
                        }
                        else
                        {
                            message = "Thêm danh mục lỗi";
                        }
                    }
                }
                catch (FormatException)
                {
                    message = "ID phải là số nguyên lớn hơn 0";
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("duplicate")) message = "ID đã tồn tại";
                }
            }
            return message;
        }

        public string deleteCate(string idCateTxt)
        {
            string mesage = "";
            if (idCateTxt.Equals(""))
            {
                mesage = "Bạn chưa chọn danh mục";
            }
            else
            {
                try
                {
                    int id = Convert.ToInt32(idCateTxt.Trim());
                    string status = "Inactive";
                    bool check = dao.deleteCate(id, status);
                    if (check)
                    {
                        mesage = "Xóa danh mục thành công";
                    }
                    else
                    {
                        mesage = "Xóa danh mục lỗi" ;
                    }
                }
                catch (FormatException)
                {
                    mesage = "ID phải là số nguyên lớn hơn 0";
                }
            }
            return mesage;
        }

        public string updateCate(int id, string idTxt, string nameUpdate)
        {
            string message = "";
            try
            {
                if (idTxt.Equals("") || nameUpdate.Equals(""))
                {
                    message = "Chưa điền đủ thông tin";
                }
                else
                {
                    int idTextBox = Convert.ToInt32(idTxt.Trim());
                    if (id != idTextBox)
                    {
                        message = "Không thể cập nhật id";
                    }
                    else
                    {
                        string status = "Active";
                        CategoryDTO dto = new CategoryDTO(idTextBox, nameUpdate, status);
                        bool check = dao.updateCate(dto);
                        if (check)
                        {
                            message = "Cập nhật danh mục thành công";
                        }
                        else
                        {
                            message = "Cập nhật danh mục lỗi";
                        }
                    }
                }
            }
            catch (FormatException)
            {
                message = "Không thể cập nhật id";
            }
            return message;
        }
    }
}

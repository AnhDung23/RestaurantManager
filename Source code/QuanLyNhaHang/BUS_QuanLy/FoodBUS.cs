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
    public class FoodBUS
    {
        FoodDAO dao = new FoodDAO();
         public FoodBUS()
        {

        }

        public FoodDTO getFoodByName(string nameFood)
        {
            return dao.getFoodByName(nameFood);
        }

        public List<FoodDTO> getListFoodByCateID(int idCate)
        {
            return dao.getListFoodByCateID(idCate);
        }

        public DataTable loadFood()
        {
            return dao.loadFood();
        }

        public string addFood(string nameFood, string priceTxt, int idCate) 
        {
            string message = "";
            if (nameFood.Equals("") || priceTxt.Equals(""))
            {
                message = "Bạn cần điền đủ các thông tin món ăn";
            }
            else
            {
                try
                {
                    int price = Convert.ToInt32(priceTxt.Trim());
                    if (price == 0)
                    {
                        message = "Giá phải lớn hơn 0";
                    }
                    else
                    {
                        string status = "Active";
                        FoodDTO dto = new FoodDTO(nameFood, idCate, price, status);
                        try
                        {
                            bool check = dao.addFood(dto);
                            if (check)
                            {
                                message = "Thêm món thành công";
                            }
                            else
                            {
                                message = "Thêm món lỗi";
                            }
                        }
                        catch (Exception ex)
                        {
                            if (ex.Message.Contains("duplicate")) message = "Sản phẩm đã tồn tại";
                        }
                    }
                }
                catch (FormatException)
                {
                    message = "Trường giá không hợp lệ";
                }

            }
            return message;
        }

        public string deleteFood(string nameFood)
        {
            string message = "";
            if (nameFood.Equals(""))
            {
                message = "Bạn chưa chọn món";
            }
            else
            {
                string status = "Inactive";
                bool check = dao.deleteFood(nameFood, status);
                if (check)
                {
                    message = "Xóa món thành công";
                }
                else
                {
                    message = "Xóa món lỗi";
                }
            }
            return message;
        }

        public string updateFood(string name, string nameTextBox, int idCate, string priceTxt)
        {
            string message = "";
            if (!name.Equals(nameTextBox))
            {
                message = "Không thể cập nhật tên";
            }
            else
            {
                if (priceTxt.Equals(""))
                {
                    message = "Bạn cần điền đầy các thông tin";
                }
                else
                {
                    try
                    {
                        int price = Convert.ToInt32(priceTxt.Trim());
                        if (price == 0)
                        {
                            message = "Giá phải lớn hơn 0";
                        }
                        else
                        {
                            bool check = dao.updateFood(name, idCate, price);
                            if (check)
                            {
                                message = "Cập nhật món thành công";
                            }
                            else
                            {
                                message = "Cập nhật món lỗi";
                            }
                        }
                    }
                    catch (FormatException)
                    {
                        message = "Trường giá không hợp lệ";
                    }

                }

            }
            return message;
        }

        public DataTable searchFoodByName(string valueSearch)
        {
            return dao.searchFoodByName(valueSearch);
        }
    }
}

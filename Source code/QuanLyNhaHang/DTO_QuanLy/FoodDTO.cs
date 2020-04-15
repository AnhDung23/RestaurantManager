using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class FoodDTO
    {
        public string Name { get; set; }
        public int IdCategory { get; set; }
        public int Price { get; set; }
        public string Status { get; set; }

        public FoodDTO()
        {
        }

        public FoodDTO(string name, int idCategory, int price, string status)
        {
            Name = name;
            IdCategory = idCategory;
            Price = price;
            Status = status;
        }
    }
}

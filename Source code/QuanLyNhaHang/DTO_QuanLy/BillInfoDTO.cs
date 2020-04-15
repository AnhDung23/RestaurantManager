using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class BillInfoDTO
    {
        public int Id { get; set; }
        public int IdBill { get; set; }
        public string NameFood { get; set; }
        public int Quantity { get; set; }

        public BillInfoDTO()
        {
        }

        public BillInfoDTO(int id, int idBill, string nameFood, int quantity)
        {
            Id = id;
            IdBill = idBill;
            NameFood = nameFood;
            Quantity = quantity;
        }
    }
}

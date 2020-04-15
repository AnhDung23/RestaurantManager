using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class TableFoodDTO
    {
        public string Name { get; set; }
        public string Status { get; set; }

        public TableFoodDTO()
        {

        }

        public TableFoodDTO(string name, string status)
        {
            this.Name = name;
            this.Status = status;
        }

        

    }
}

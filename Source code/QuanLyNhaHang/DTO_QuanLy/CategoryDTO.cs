using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        
        public CategoryDTO()
        {

        }

        public CategoryDTO(int id, string name, string status)
        {
            Id = id;
            Name = name;
            Status = status;
        }
    }
}

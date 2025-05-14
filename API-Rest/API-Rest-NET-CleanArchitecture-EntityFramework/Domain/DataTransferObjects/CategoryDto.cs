using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIRest.Domains.DataTransferObjects
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public string Description { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities;

namespace APIRest.Domains.DataTransferObjects
{
    public class AddProductDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int? CategoryId { get; set; }
    }
}

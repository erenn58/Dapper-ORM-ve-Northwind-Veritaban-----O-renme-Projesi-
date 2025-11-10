using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5_DapperNorthwind.dto.ProductDto
{
    public class CreateProDto
    {
        
        public string ProductName { get; set; }

        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int UCategoryId { get; set; }
    }
}

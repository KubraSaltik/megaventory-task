using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaventoryTask.Dto
{
    public class ProductDto
    {
        public int SKU { get; set; }
        public string Description { get; set; }
        public double SalesPrice { get; set; }
        public double PurchasePrice { get; set; }

    }
}

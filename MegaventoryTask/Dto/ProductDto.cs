using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaventoryTask.Dto
{
    public class ProductDto
    {
        public string APIKEY { get; set; }
        public  MvProduct mvProduct  { get; set; }
        public string mvRecordAction { get; set; }

    }
    public class MvProduct
    {
        public string ProductSKU { get; set; }
        public string ProductDescription { get; set; }
        public double ProductSellingPrice { get; set; }
        public double ProductPurchasePrice { get; set; }
    }
}

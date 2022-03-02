using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaventoryTask.Dto
{
    public class UpdateDto
    {
        public string APIKEY { get; set; }
        public MvUpdateProduct mvProduct { get; set; }
        public string mvRecordAction { get; set; }
    }
    public class MvUpdateProduct
    {
        public int ProductId { get; set; }
        public string ProductDescription { get; set; }
        public double ProductSellingPrice { get; set; }
        public double ProductPurchasePrice { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaventoryTask.Dto
{
    public class DiscountDto
    {
        public string APIKEY { get; set; }
        public string mvRecordAction { get; set; }
        public MvDiscount mvDiscount { get; set; }

    }
    public class MvDiscount
    {
        public string DiscountName { get; set; }
        public double DiscountValue { get; set; }
    }
}

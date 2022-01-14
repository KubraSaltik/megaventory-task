using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaventoryTask.Dto
{
    public class TaxDto
    {
        public string APIKEY { get; set; }
        public MvTax mvTax { get; set; }
        public string mvRecordAction { get; set; }

    }
    public class MvTax
    {
        public string TaxName { get; set; }
        public double TaxValue { get; set; }
        public string Description { get; set; }
    }
}

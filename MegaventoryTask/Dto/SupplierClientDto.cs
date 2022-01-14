using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaventoryTask.Dto
{
    public class SupplierClientDto
    {
        public string APIKEY { get; set; }
        public MvSupplierClient mvSupplierClient { get; set; }
        public string mvRecordAction { get; set; }
    }
    public class MvSupplierClient
    {
        public string SupplierClientName { get; set; }
        public string SupplierClientEmail { get; set; }
        public string SupplierClientShippingAddress1 { get; set; }
        public string SupplierClientPhone1 { get; set; }

    }
}

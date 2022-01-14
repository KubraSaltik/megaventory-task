using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaventoryTask.Dto
{
    public class SalesOrderDto
    {
        public string APIKEY { get; set; }
        public  MvSalesOrder mvSalesOrder  { get; set; }
        public string mvRecordAction { get; set; }
    }
    public class MvSalesOrder
    {
        public string SalesOrderStatus { get; set; }
        public int SalesOrderTypeId { get; set; }
        public List<MvSalesOrderRow> SalesOrderDetails { get; set; }
        public int SalesOrderClientID { get; set; }
        public int SalesOrderInventoryLocationID { get; set; }
    }
    public class MvSalesOrderRow
    {

        public int SalesOrderRowTaxID { get; set; }
        public string SalesOrderRowProductSKU { get; set; }
        public double SalesOrderRowShippedQuantity { get; set; }
        public double SalesOrderRowInvoicedQuantity { get; set; }
        public double SalesOrderRowUnitPriceWithoutTaxOrDiscount { get; set; }
        public int SalesOrderRowDiscountID { get; set; }
        public int SalesOrderRowProductID { get; set; }
        public double SalesOrderRowQuantity { get; set; }

    }
}

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
        public int SalesOrderTypeId { get; set; }
        public int SalesOrderClientID { get; set; }
       // public Array[mvSalesOrderRow] SalesOrderDetails { get; set; }
    }
}

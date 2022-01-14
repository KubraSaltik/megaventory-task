using MegaventoryTask.Dto;
using MegaventoryTask.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaventoryTask.Controllers
{
    public class SalesOrderController : ControllerBase
    {
        private ISalesOrderServices _salesOrderServices;

        public SalesOrderController(ISalesOrderServices salesOrderServices)
        {
            _salesOrderServices = salesOrderServices;
        }
        public IActionResult CreateSalesOrder(MvSalesOrder mvSalesOrder)
        {
            try
            {
                return Ok(_salesOrderServices);
            }
            catch (Exception exp)
            {
                return BadRequest(exp);
            }
        }

    }
}

using MegaventoryTask.Dto;
using MegaventoryTask.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaventoryTask.Controllers
{
    public class SupplierClientController : ControllerBase
    {
        private ISupplierClientServices _supplierClientServices;

        public SupplierClientController(ISupplierClientServices supplierClientServices)
        {
            _supplierClientServices = supplierClientServices;
        }
        public IActionResult CreateSupplierClient(MvSupplierClient mvSupplierClient)
        {
            try
            {
                return Ok(_supplierClientServices);
            }
            catch (Exception exp)
            {
                return BadRequest(exp);
            }
        }
    }
}

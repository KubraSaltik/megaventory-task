using MegaventoryTask.Dto;
using MegaventoryTask.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaventoryTask.Controllers
{
    public class DiscountController : ControllerBase
    {
        private IDiscountServices _discountServices;

        public DiscountController(IDiscountServices discountServices)
        {
            _discountServices = discountServices;
        }
        public IActionResult CreateDiscount(MvDiscount mvDiscount)
        {
            try
            {
                return Ok(_discountServices);
            }
            catch (Exception exp)
            {
                return BadRequest(exp);
            }
        }
    }
}

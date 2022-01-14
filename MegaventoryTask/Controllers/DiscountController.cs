using MegaventoryTask.Dto;
using MegaventoryTask.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaventoryTask.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private IDiscountServices _discountServices;

        public DiscountController(IDiscountServices discountServices)
        {
            _discountServices = discountServices;
        }
        [HttpPost ("CreateDiscount")]
        public IActionResult CreateDiscount(MvDiscount mvDiscount)
        {
            try
            {
                return Ok(_discountServices.CreateDiscount(mvDiscount));
            }
            catch (Exception exp)
            {
                return BadRequest(exp);
            }
        }
    }
}

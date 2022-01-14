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
    public class TaxController : ControllerBase
    {

        private ITaxServices _taxServices;

        public TaxController(ITaxServices taxServices)
        {
            _taxServices = taxServices;
        }
        [HttpPost("CreateTax")]
        public IActionResult CreateTax(MvTax mvTax)
        {
            try
            {
                return Ok(_taxServices.CreateTax(mvTax));
            }
            catch (Exception exp)
            {
                return BadRequest(exp);
            }
        }
    }
}

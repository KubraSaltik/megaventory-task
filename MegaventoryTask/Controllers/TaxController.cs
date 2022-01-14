using MegaventoryTask.Dto;
using MegaventoryTask.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaventoryTask.Controllers
{
    public class TaxController : ControllerBase
    {
        private ITaxServices _taxServices;

        public TaxController(ITaxServices taxServices)
        {
            _taxServices = taxServices;
        }
        public IActionResult CreateTax(MvTax mvTax)
        {
            try
            {
                return Ok(_taxServices);
            }
            catch (Exception exp)
            {
                return BadRequest(exp);
            }
        }
    }
}

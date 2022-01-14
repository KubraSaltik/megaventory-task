using MegaventoryTask.Dto;
using MegaventoryTask.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaventoryTask.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductServices _productServices;

        public ProductController(IProductServices productServices)
        {
            _productServices = productServices;
        }
        [HttpPost("CreateProduct")]
        public IActionResult CreateProduct(MvProduct mvProduct)
        {
            try
            {
                return Ok(_productServices.CreateProduct(mvProduct));
            }
            catch (Exception exp)
            {
                return BadRequest(exp);
            }
        }

    }
}

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
    public class ProductController : ControllerBase
    {
        private IProductServices _productServices;

        public ProductController(IProductServices productServices)
        {
            _productServices = productServices;
        }
        public IActionResult CreateProduct(MvProduct mvProduct)
        {
            try
            {
                return Ok(_productServices);
            }
            catch (Exception exp)
            {
                return BadRequest(exp);
            }
        }

    }
}

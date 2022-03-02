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
    public class UpdateProductController: ControllerBase
    {
        private IUpdateServices _updateServices;

        public UpdateProductController(IUpdateServices updateServices)
        {
            _updateServices = updateServices;
        }
        [HttpPost("UpdateProduct")]
        public IActionResult UpdateProduct(MvUpdateProduct mvProduct)
        {
            try
            {
                return Ok(_updateServices.UpdateProduct(mvProduct));
            }
            catch (Exception exp)
            {
                return BadRequest(exp);
            }
        }
    }
}

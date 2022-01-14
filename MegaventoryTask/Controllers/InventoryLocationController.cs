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
    public class InventoryLocationController : ControllerBase
    {
        private IInventoryLocationServices _inventoryLocationServices;

        public InventoryLocationController(IInventoryLocationServices inventoryLocationServices)
        {
            _inventoryLocationServices = inventoryLocationServices;

        }
        [HttpPost("CreateInventoryLocation")]
        public IActionResult CreateInventoryLocation(MvInventoryLocation mvInventoryLocation)
        {
            try
            {
                return Ok(_inventoryLocationServices.CreateInventoryLocation(mvInventoryLocation));
            }
            catch (Exception exp)
            {
                return BadRequest(exp);
            }
        }
    }
}

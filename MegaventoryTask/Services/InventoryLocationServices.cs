using MegaventoryTask.Helpers;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaventoryTask.Services
{
    public interface IInventoryLocationServices
    {

    }

    public class InventoryLocationServices : IInventoryLocationServices
    {
        public InventoryLocationServices(IOptions<AppSettings> appSettings)
        {

        }
    }
}

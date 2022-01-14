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
        private IRequestService _requestService;
        public InventoryLocationServices(IOptions<AppSettings> appSettings, IRequestService requestService)
        {
            _requestService = requestService;
        }
    }
}

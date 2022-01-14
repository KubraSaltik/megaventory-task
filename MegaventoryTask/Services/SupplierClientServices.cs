using MegaventoryTask.Helpers;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaventoryTask.Services
{
    public interface ISupplierClientServices
    {

    }

    public class SupplierClientServices : ISupplierClientServices
    {
        private IRequestService _requestService;
        public SupplierClientServices(IOptions<AppSettings> appSettings, IRequestService requestService)
        {
            _requestService = requestService;
        }
    }
}

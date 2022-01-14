using MegaventoryTask.Helpers;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaventoryTask.Services
{
    public interface IProductServices
    {

    }

    public class ProductServices : IProductServices
    {
        private IRequestService _requestServices;
        public ProductServices(IOptions<AppSettings> appSettings, IRequestService requestService)
        {
            _requestServices = requestService;
        }
    }
}

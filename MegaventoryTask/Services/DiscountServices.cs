using MegaventoryTask.Helpers;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaventoryTask.Services
{
    public interface IDiscountServices
    {

    }

    public class DiscountServices : IDiscountServices
    {
        private IRequestService _requestService;
        public DiscountServices(IOptions<AppSettings> appSettings,IRequestService requestService)
        {
            _requestService = requestService;
        }
    }

}

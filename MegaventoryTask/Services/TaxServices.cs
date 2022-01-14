using MegaventoryTask.Helpers;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaventoryTask.Services
{
    public interface ITaxServices
    {

    }

    public class TaxServices : ITaxServices
    {
        private IRequestService _requestService;
        public TaxServices(IOptions<AppSettings> appSettings, IRequestService requestService)
        {
            _requestService = requestService;
        }
    }

}

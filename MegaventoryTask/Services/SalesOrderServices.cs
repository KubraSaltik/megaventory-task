using MegaventoryTask.Helpers;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaventoryTask.Services
{
    public interface ISalesOrderServices
    {

    }

    public class SalesOrderServices : ISalesOrderServices
    {
        private IRequestService _requestService;
        public SalesOrderServices(IOptions<AppSettings> appSettings, IRequestService requestService)
        {
            _requestService = requestService;
        }
    }
}

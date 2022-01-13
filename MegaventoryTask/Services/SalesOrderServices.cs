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
        public SalesOrderServices(IOptions<AppSettings> appSettings)
        {

        }
    }
}

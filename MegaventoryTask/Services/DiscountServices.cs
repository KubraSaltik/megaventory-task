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
        public DiscountServices(IOptions<AppSettings> appSettings)
        {

        }
    }

}

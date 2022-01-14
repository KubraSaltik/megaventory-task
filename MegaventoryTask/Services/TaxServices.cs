using MegaventoryTask.Dto;
using MegaventoryTask.Helpers;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MegaventoryTask.Services
{
    public interface ITaxServices
    {
        ResponseResult CreateTax(MvTax mvTax);
    }

    public class TaxServices : ITaxServices
    {
        private IRequestService _requestService;
        private AppSettings _appSettings;
        public TaxServices(IOptions<AppSettings> appSettings, IRequestService requestService)
        {
            _requestService = requestService;
            _appSettings = appSettings.Value;
        }

        public ResponseResult CreateTax(MvTax mvTax)
        {
            TaxDto product = new TaxDto
            {

                APIKEY = _appSettings.ApiKey,
                mvRecordAction = "Insert",
                mvTax = mvTax,
            };

            string requestUrl = string.Concat(_appSettings.BaseURL, "/Tax/TaxUpdate");
            var response = _requestService.Request(product, requestUrl, HttpMethod.Post);
            return response;
        }
    }

}

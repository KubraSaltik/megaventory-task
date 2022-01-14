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
    public interface ISupplierClientServices
    {
        ResponseResult CreateSupplierClient(MvSupplierClient mvSupplierClient);
    }

    public class SupplierClientServices : ISupplierClientServices
    {
        private IRequestService _requestService;
        private AppSettings _appSettings;
        public SupplierClientServices(IOptions<AppSettings> appSettings, IRequestService requestService)
        {
            _requestService = requestService;
            _appSettings = appSettings.Value;
        }

        public ResponseResult CreateSupplierClient(MvSupplierClient mvSupplierClient)
        {
            SupplierClientDto product = new SupplierClientDto
            {

                APIKEY = _appSettings.ApiKey,
                mvRecordAction = "Insert",
                mvSupplierClient= mvSupplierClient,
            };

            string requestUrl = string.Concat(_appSettings.BaseURL, "/SupplierClient/SupplierClientUpdate");
            var response = _requestService.Request(product, requestUrl, HttpMethod.Post);
            return response;
        }
    }
}

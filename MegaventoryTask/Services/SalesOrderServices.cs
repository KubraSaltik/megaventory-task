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
    public interface ISalesOrderServices
    {
        ResponseResult CreateSalesOrder(MvSalesOrder mvSalesOrder);
    }

    public class SalesOrderServices : ISalesOrderServices
    {
        private IRequestService _requestService;
        private AppSettings _appSettings;
        public SalesOrderServices(IOptions<AppSettings> appSettings, IRequestService requestService)
        {
            _requestService = requestService;
            _appSettings = appSettings.Value;
        }


        public ResponseResult CreateSalesOrder(MvSalesOrder mvSalesOrder)
        {
            SalesOrderDto product = new SalesOrderDto
            {

                APIKEY = _appSettings.ApiKey,
                mvRecordAction = "Insert",
                mvSalesOrder= mvSalesOrder,
            };

            string requestUrl = string.Concat(_appSettings.BaseURL, "/SalesOrder/SalesOrderUpdate");
            var response = _requestService.Request(product, requestUrl, HttpMethod.Post);
            return response;
        }
    }


}

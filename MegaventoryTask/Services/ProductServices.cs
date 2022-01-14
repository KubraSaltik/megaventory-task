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
    public interface IProductServices
    {
        ResponseResult CreateProduct(MvProduct mvProduct);
    }

    public class ProductServices : IProductServices
    {
        private IRequestService _requestService;
        private AppSettings _appSettings;
        public ProductServices(IOptions<AppSettings> appSettings, IRequestService requestService)
        {
            _requestService = requestService;
            _appSettings = appSettings.Value;
        }


        public ResponseResult CreateProduct(MvProduct mvProduct)
        {
            ProductDto product = new ProductDto
            {

                APIKEY = _appSettings.ApiKey,
                mvRecordAction = "Insert",
               mvProduct= mvProduct,
            };

            string requestUrl = string.Concat(_appSettings.BaseURL, "/Product/ProductUpdate");
            var response = _requestService.Request(product, requestUrl, HttpMethod.Post);
            return response;
        }
    }
}

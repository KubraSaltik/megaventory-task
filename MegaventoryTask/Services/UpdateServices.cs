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
    public interface IUpdateServices
    {
        ResponseResult UpdateProduct(MvUpdateProduct mvUpdateProduct);
    }

    public class UpdateServices : IUpdateServices
    {
        private IRequestService _requestService;
        private AppSettings _appSettings;
        public UpdateServices(IOptions<AppSettings> appSettings, IRequestService requestService)
        {
            _requestService = requestService;
            _appSettings = appSettings.Value;
        }


        public ResponseResult UpdateProduct(MvUpdateProduct mvUpdateProduct)
        {
            UpdateDto updateProduct = new UpdateDto
            {

                APIKEY = _appSettings.ApiKey,
                mvRecordAction = "Update",
                mvProduct = mvUpdateProduct,
            };

            string requestUrl = string.Concat(_appSettings.BaseURL, "/Product/ProductUpdate");
            var response = _requestService.Request(updateProduct, requestUrl, HttpMethod.Post);
            return response;
        }
    }
}

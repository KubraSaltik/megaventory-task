using MegaventoryTask.Dto;
using MegaventoryTask.Helpers;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace MegaventoryTask.Services
{
    public interface IDiscountServices
    {
        ResponseResult CreateDiscount(MvDiscount mvDiscount);
    }

    public class DiscountServices : IDiscountServices
    {
        private IRequestService _requestService;
        private AppSettings _appSettings;
        
        public DiscountServices(IOptions<AppSettings> appSettings,IRequestService requestService)
        {
            _requestService = requestService;
            _appSettings = appSettings.Value;
        }

        public ResponseResult CreateDiscount(MvDiscount mvDiscount)
        {
            DiscountDto discountDto = new DiscountDto {

                APIKEY = _appSettings.ApiKey,
                mvRecordAction="Insert",
                mvDiscount= mvDiscount
            };
            
            string requestUrl = string.Concat(_appSettings.BaseURL,"/Discount/DiscountUpdate");
            var response = _requestService.Request(discountDto, requestUrl,HttpMethod.Post);
            return response;
        }
    }

}

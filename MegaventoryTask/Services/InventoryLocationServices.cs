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
    public interface IInventoryLocationServices
    {
        ResponseResult CreateInventoryLocation(MvInventoryLocation mvInventoryLocation);
    }

    public class InventoryLocationServices : IInventoryLocationServices
    {
        private IRequestService _requestService;
        private AppSettings _appSettings;
        public InventoryLocationServices(IOptions<AppSettings> appSettings, IRequestService requestService)
        {
            _requestService = requestService;
            _appSettings = appSettings.Value;
        }
       

        public ResponseResult CreateInventoryLocation(MvInventoryLocation mvInventoryLocation)
        {
            InventoryLocationDto inventoryLocationDto = new InventoryLocationDto
            {

                APIKEY = _appSettings.ApiKey,
                mvRecordAction = "Insert",
                mvInventoryLocation= mvInventoryLocation,
            };

            string requestUrl = string.Concat(_appSettings.BaseURL, "/InventoryLocation/InventoryLocationUpdate");
            var response = _requestService.Request(inventoryLocationDto, requestUrl, HttpMethod.Post);
            return response;
        }
    }
}

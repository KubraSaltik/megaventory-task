using MegaventoryTask.Dto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MegaventoryTask.Services
{
    public interface IRequestService
    {
        public ResponseResult Request(object data, string requestURI, HttpMethod method, List<KeyValuePair<string, string>> contentData = null);

    }
    public class RequestService : IRequestService
    {
        private Task<HttpResponseMessage> result { get; set; }
        private HttpClient _httpClient = new HttpClient();
        public ResponseResult Request(object data, string requestURI, HttpMethod method, List<KeyValuePair<string, string>> contentData = null)
        {
            string contentSerialized = string.Empty;
            StringContent content = new StringContent("");
            ResponseResult response = new ResponseResult();
            if (data != null && contentData == null)
            {
                contentSerialized = JsonConvert.SerializeObject(data);
                content = new StringContent(
                        contentSerialized,
                        Encoding.UTF8, "application/json");
            }
            switch (method)
            {
                case HttpMethod m when m == HttpMethod.Post:
                    if (contentData == null)
                    {
                        result = _httpClient.PostAsync(requestURI, content);
                    }
                    else
                    {
                        result = _httpClient.SendAsync(new HttpRequestMessage(System.Net.Http.HttpMethod.Post, requestURI) { Content = new FormUrlEncodedContent(contentData) });
                    }
                    break;
                case HttpMethod m when m == HttpMethod.Get:
                    result = _httpClient.GetAsync(requestURI);
                    break;
                case HttpMethod m when m == HttpMethod.Put:
                    result = _httpClient.PutAsync(requestURI, content);
                    break;
                case HttpMethod m when m == HttpMethod.Delete:
                    result = _httpClient.DeleteAsync(requestURI);
                    break;
                default:
                    break;
            }

            try
            {
                Task<string> responseResultValue = result.Result.Content.ReadAsStringAsync();

                response.Code = (HttpStatusCode)result.Result.StatusCode;

                if (response.Code != HttpStatusCode.OK)
                {
                    return response;
                }

                response.Data = responseResultValue.Result;
                return response;
            }
            catch
            {
                
                return response;
            }
        }
    }
}

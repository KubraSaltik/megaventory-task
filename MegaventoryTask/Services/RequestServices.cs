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
        ResponseResult<TResponse> Request<TResponse>(object data, string requestURI, HttpClient httpClient, List<KeyValuePair<string, string>> contentData = null) where TResponse : new();

        ResponseResult<TResponse> Get<TResponse>(string uri, HttpClient httpClient, List<KeyValuePair<string, string>> contentData = null) where TResponse : new();
    }
    public class RequestService : IRequestService
    {
        private Task<HttpResponseMessage> result { get; set; }

        public ResponseResult<TResponse> Request<TResponse>(object data, string requestURI, HttpClient httpClient, List<KeyValuePair<string, string>> contentData = null) where TResponse : new()
        {

            return Request<TResponse>(data, requestURI, HttpMethod.Post, httpClient, contentData);
        }

        public ResponseResult<TResponse> Get<TResponse>(string uri, HttpClient httpClient, List<KeyValuePair<string, string>> contentData = null) where TResponse : new()
        {
            return Request<TResponse>(null, uri, HttpMethod.Get, httpClient, contentData);
        }

        public ResponseResult<TModel> Request<TModel>(object data, string requestURI, HttpMethod method, HttpClient client, List<KeyValuePair<string, string>> contentData = null) where TModel : new()
        {
            string contentSerialized = string.Empty;
            StringContent content = new StringContent("");
            ResponseResult<TModel> response = new ResponseResult<TModel>();
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
                        result = client.PostAsync(requestURI, content);
                    }
                    else
                    {
                        result = client.SendAsync(new HttpRequestMessage(System.Net.Http.HttpMethod.Post, requestURI) { Content = new FormUrlEncodedContent(contentData) });
                    }
                    break;
                case HttpMethod m when m == HttpMethod.Get:
                    result = client.GetAsync(requestURI);
                    break;
                case HttpMethod m when m == HttpMethod.Put:
                    result = client.PutAsync(requestURI, content);
                    break;
                case HttpMethod m when m == HttpMethod.Delete:
                    result = client.DeleteAsync(requestURI);
                    break;
                default:
                    break;
            }

            try
            {
                Task<string> responseResultValue = result.Result.Content.ReadAsStringAsync();

                //casting status code to service code
                response.Code = (HttpStatusCode)result.Result.StatusCode;

                //if service code not equal OK,new instante for T type.
                if (response.Code != HttpStatusCode.OK)
                {
                    response.Data = new TModel();
                    return response;
                }

                //deserializing result body
                response.Data = JsonConvert.DeserializeObject<TModel>(responseResultValue.Result);
                return response;
            }
            catch
            {
                response.Data = new TModel();
                return response;
            }
        }
    }
}

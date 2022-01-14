﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace MegaventoryTask.Dto
{
    public class ResponseResult<T>
    {
        private HttpStatusCode code;
        public HttpStatusCode Code
        {
            get { return code; }
            set
            {
                code = value;
            }
        }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public T Data { get; set; }

        public ResponseResult()
        {
            Code = HttpStatusCode.Forbidden;
        }

        public ResponseResult(HttpStatusCode code)
        {
            Code = code;
        }
    }
}

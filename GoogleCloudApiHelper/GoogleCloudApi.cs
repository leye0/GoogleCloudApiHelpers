using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Net;
using System.Net.Http;

namespace GoogleCloudApiHelper
{
    public class GoogleCloudApi
    {
        internal string _apiKey;

        internal HttpClient _httpClient;

        internal JsonSerializerSettings JsonSettings => new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };

        internal string UseProxyIfPossible(string url)
        {
            if (!string.IsNullOrWhiteSpace(ProxyUrl))
            {
                // return string.Format(ProxyUrl, WebUtility.UrlEncode(url));
                return string.Format(ProxyUrl, url);
            }

            return url;
        }

        public string ProxyUrl { get; set; }
        
        public GoogleCloudApi(HttpClient httpClient, string apiKey, string proxyUrl = null)
        {
            _apiKey = apiKey;
            _httpClient = httpClient;
            ProxyUrl = proxyUrl;
        }
    }
}

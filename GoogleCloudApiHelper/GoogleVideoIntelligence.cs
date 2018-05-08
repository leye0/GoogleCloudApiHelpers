using GoogleCloudApiHelper.VideoIntelligenceApi;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace GoogleCloudApiHelper
{
    public class VideoIntelligence: GoogleCloudApi
    {
        public VideoIntelligence(HttpClient client, string apiKey): base(client, apiKey) {}

        private string OperationsBaseUrl = "https://videointelligence.googleapis.com/v1/operations";
        private string BaseUrl = "https://videointelligence.googleapis.com/v1/videos:";

        private VideoIntelligenceOperationsUri Request(string videoSourceUrl, string endpointUrl)
        {
            var request = new VideoIntelligenceRequest(videoSourceUrl);
            var jsonRequest = JsonConvert.SerializeObject(request, JsonSettings);
            var requestContent = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

            if (!string.IsNullOrWhiteSpace(_apiKey))
            {
                _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_apiKey}");
            }

            var requestUrl = UseProxyIfPossible($"{BaseUrl}{endpointUrl}");
            var result = _httpClient.PostAsync(requestUrl, requestContent).Result;
            var response = result.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<VideoIntelligenceOperationsUri>(response);
        }

        public VideoIntelligenceOperationsUri Annotate(string videoSourceUrl) => Request(videoSourceUrl, "annotate");

        public VideoIntelligenceResponse GetResponse(string operationName)
        {
            if (!string.IsNullOrWhiteSpace(_apiKey))
            {
                _httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", $"Bearer {_apiKey}");
            }

            var requestUrl = UseProxyIfPossible($"{OperationsBaseUrl}/{operationName}");
            var result = _httpClient.GetAsync(requestUrl).Result;
            var response = result.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<VideoIntelligenceResponse>(response);
        }
    }
}

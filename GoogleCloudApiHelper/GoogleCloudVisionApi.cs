using GoogleCloudApiHelper.VisionApi;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace GoogleCloudApiHelper
{
    public class Vision: GoogleCloudApi
    {
        public Vision(HttpClient client, string apiKey): base(client, apiKey) {}

        private string BaseUrl = "https://vision.googleapis.com/v1/images:";

        private VisionResponse Request(string[] imagesAsBase64, string url)
        {
            var request = new VisionRequest(imagesAsBase64);
            var jsonRequest = JsonConvert.SerializeObject(request, JsonSettings);
            var requestContent = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

            if (!string.IsNullOrWhiteSpace(_apiKey))
            {
                _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_apiKey}");
            }

            var requestUrl = UseProxyIfPossible(BaseUrl + url);
            var response = _httpClient.PostAsync(requestUrl, requestContent).Result;
            var result = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<VisionResponse>(result);
        }

        public VisionResponse Annotate(string[] imagesAsBase64) => Request(imagesAsBase64, "annotate");
    }
}

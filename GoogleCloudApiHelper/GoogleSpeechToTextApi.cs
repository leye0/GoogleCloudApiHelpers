using GoogleCloudApiHelper.SpeechToTextApi;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace GoogleCloudApiHelper
{
    public class SpeechToText: GoogleCloudApi
    {
        public SpeechToText(HttpClient client, string apiKey): base(client, apiKey) {}

        private string BaseUrl = "https://speech.googleapis.com/v1p1beta1/speech:";

        private SpeechToTextResponse Request(string linear16AudioAsBase64, string url)
        {
            var request = new SpeechToTextRequest(linear16AudioAsBase64);
            var jsonRequest = JsonConvert.SerializeObject(request, JsonSettings);
            var requestContent = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

            if (!string.IsNullOrWhiteSpace(_apiKey))
            {
                _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_apiKey}");
            }

            var requestUrl = UseProxyIfPossible(BaseUrl + url);
            var result = _httpClient.PostAsync(requestUrl, requestContent).Result;
            var response = result.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<SpeechToTextResponse>(response);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="linear16AudioAsBase64"></param>
        /// <returns></returns>
        public SpeechToTextResponse Recognize(string linear16AudioAsBase64) => Request(linear16AudioAsBase64, "recognize");
    }
}

using GoogleCloudApiHelper.TextToSpeechApi;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace GoogleCloudApiHelper
{
    public class TextToSpeech: GoogleCloudApi
    {
        public TextToSpeech(HttpClient client, string apiKey): base(client, apiKey) {}

        private string BaseUrl = "https://texttospeech.googleapis.com/v1beta1/text:";

        private TextToSpeechResponse Request(string text, string url)
        {
            var request = new TextToSpeechRequest(text);
            var jsonRequest = JsonConvert.SerializeObject(request, JsonSettings);
            var requestContent = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

            if (!string.IsNullOrWhiteSpace(_apiKey))
            {
                _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_apiKey}");
            }

            var requestUrl = UseProxyIfPossible(BaseUrl + url);
            var result = _httpClient.PostAsync(requestUrl, requestContent).Result;
            var response = result.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<TextToSpeechResponse>(response);
        }

        public TextToSpeechResponse Synthesize(string text) => Request(text, "synthesize");
    }
}

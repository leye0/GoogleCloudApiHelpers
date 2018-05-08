using GoogleCloudApiHelper.TranslateApi;
using Newtonsoft.Json;
using System.Net.Http;

namespace GoogleCloudApiHelper
{
    public class Translate: GoogleCloudApi
    {
        public Translate(HttpClient client, string apiKey): base(client, apiKey) {}

        private string BaseUrl = "https://translation.googleapis.com/language/translate/v2";

        private TranslateResponse Request(string text, string sourceLanguage = "", string destinationLanguage = "")
        {
            var detect = string.IsNullOrWhiteSpace(sourceLanguage) || string.IsNullOrWhiteSpace(destinationLanguage);

            if (!string.IsNullOrWhiteSpace(_apiKey))
            {
                _httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", $"Bearer {_apiKey}");
            }

            var languages = !detect ? $"%26source%3D{sourceLanguage}%26target%3D{destinationLanguage}" : "";
            var detectEndpoint = detect ? "%2Fdetect" : "";

            var requestUrl = UseProxyIfPossible($"{BaseUrl}{detectEndpoint}%2F%3Fq={text}%26format=text" + languages);
            var result = _httpClient.GetAsync(requestUrl).Result;
            var response = result.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<TranslateResponse>(response);
        }

        public TranslateResponse Detect(string text) => Request(text);

        public TranslateResponse Do(string text, string sourceLanguage, string destinationLanguage) => Request(text, sourceLanguage, destinationLanguage);
    }
}

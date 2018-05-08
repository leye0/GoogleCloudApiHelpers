using System.Net.Http;

namespace GoogleCloudApiHelper
{
    /// <summary>
    /// A very light library to consume Google Cloud APIs
    /// </summary>
    public class Client
    {
        public NaturalLanguage NaturalLanguage { get; set; }

        public Vision Vision { get; set; }

        public SpeechToText SpeechToText { get; set; }

        public TextToSpeech TextToSpeech { get; set; }

        public VideoIntelligence VideoIntelligence { get; set; }

        public Translate Translate { get; set; }

        /// <summary>
        /// Create an instance of my Google Natural Language Api Helper
        /// </summary>
        public Client(string apiKey, string proxyUrl = null)
        {
            var httpClient = new HttpClient();
            NaturalLanguage = new NaturalLanguage(httpClient, apiKey) { ProxyUrl = proxyUrl };
            Vision = new Vision(httpClient, apiKey) { ProxyUrl = proxyUrl };
            SpeechToText = new SpeechToText(httpClient, apiKey) { ProxyUrl = proxyUrl };
            TextToSpeech = new TextToSpeech(httpClient, apiKey) { ProxyUrl = proxyUrl };
            VideoIntelligence = new VideoIntelligence(httpClient, apiKey) { ProxyUrl = proxyUrl };
            Translate = new Translate(httpClient, apiKey) { ProxyUrl = proxyUrl };
        }
    }
}

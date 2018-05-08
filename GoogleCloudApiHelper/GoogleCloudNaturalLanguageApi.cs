using GoogleCloudApiHelper.NaturalLanguageApi;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

// About DependencyEdge, dependencies between words, PartsOfSpeech:
// Older: http://robotics.usc.edu/~gkoch/DependencyManual.pdf
// Current: http://universaldependencies.org/docs/en/dep/index.html

namespace GoogleCloudApiHelper
{
    public class NaturalLanguage: GoogleCloudApi
    {
        public NaturalLanguage(HttpClient client, string apiKey): base(client, apiKey) {}

        private string BaseUrl = "https://language.googleapis.com/v1beta2/documents:";

        private NaturalLanguageResult Request(string text, string url, NaturalLanguageRequestFeatures features = null)
        {
            var document = new NaturalLanguageRequestDocument(text);
            var request = url == "classifyText" ? new NaturalLanguageRequest(document) : new NaturalLanguageRequestWithEncodingType(document, features);
            var jsonRequest = JsonConvert.SerializeObject(request, JsonSettings);
            var requestContent = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

            if (!string.IsNullOrWhiteSpace(_apiKey))
            {
                _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_apiKey}");
            }

            var requestUrl = UseProxyIfPossible(BaseUrl + url);
            var result = _httpClient.PostAsync(requestUrl, requestContent).Result.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<NaturalLanguageResult>(result);
        }
        
        /// <summary>
        /// Entity analysis inspects the given text for known entities (Proper nouns such as public
        /// figures, landmarks, and so on. Common nouns such as restaurant, stadium, and so on.)
        /// and returns information about those entities. Entity analysis is performed with the 
        /// analyzeEntities method.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public NaturalLanguageResult AnalyzeEntities(string text) => Request(text, "analyzeEntities");

        /// <summary>
        /// Entity sentiment analysis inspects the given text for known entities (proper nouns 
        /// and common nouns), returns information about those entities, and identifies the 
        /// prevailing emotional opinion of the entity within the text, especially to 
        /// determine a writer's attitude toward the entity as positive, negative, or neutral. 
        /// Entity analysis is performed with the analyzeEntitySentiment method.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public NaturalLanguageResult AnalyzeEntitySentiment(string text) => Request(text, "analyzeEntitySentiment");

        /// <summary>
        /// Syntactic analysis extracts linguistic information, breaking up the given text 
        /// into a series of sentences and tokens (generally, word boundaries), providing 
        /// further analysis on those tokens. Syntactic Analysis is performed with the 
        /// analyzeSyntax method.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public NaturalLanguageResult AnalyzeSyntax(string text) => Request(text, "analyzeSyntax");

        /// <summary>
        /// Sentiment analysis inspects the given text and identifies the prevailing emotional 
        /// opinion within the text, especially to determine a writer's attitude as positive, 
        /// negative, or neutral. Sentiment analysis is performed through the analyzeSentiment 
        /// method.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public NaturalLanguageResult AnalyzeSentiment(string text) => Request(text, "analyzeSentiment");

        /// <summary>
        /// Content classification analyzes text content and returns a content category for
        /// the content. Content classification is performed by using the classifyText method.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public NaturalLanguageResult ClassifyText(string text) => Request(text, "classifyText");

        /// <summary>
        /// A convenience method that provides all the features that analyzeSentiment, analyzeEntities, 
        /// and analyzeSyntax provide in one call.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="features"></param>
        /// <returns></returns>
        public NaturalLanguageResult AnnotateText(string text, NaturalLanguageRequestFeatures features) => Request(text, "annotateText", features);

    }
}

using GoogleCloudApiHelper.NaturalLanguageApi;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace GoogleCloudApiHelper
{
    class Program
    {
        static Client _client;

        static string ApiKey = "";

        static string ProxyUrl = "";

        static void Main(string[] args)
        {
            if (string.IsNullOrWhiteSpace(ApiKey + ProxyUrl))
            {
                throw new Exception("You need use to configure either an api key or a proxy url");
            }

            _client = new Client(ApiKey, ProxyUrl);

            TestNaturalLanguageApi();

            TestVisionApi();

            TestSpeechToTextApi();

            TestTextToSpeechApi();

            TestTranslateApi();

            TestVideoIntelligenceApi();
        }

        private static void TestNaturalLanguageApi()
        {
            var text = "Google, headquartered in Mountain View, unveiled the new Android phone at the Consumer Electronic Show. Sundar Pichai said in his keynote that users love their new Android phones!";
            
            // This method does all in one call:
            var annotateText = _client.NaturalLanguage.AnnotateText(text, new NaturalLanguageRequestFeatures(true, true, true, true, true));

            var docSentiments = annotateText.DocumentSentiment;
            var detectedEntities = annotateText.Entities;
            var detectedCategories = annotateText.Categories;
            var put_a_breakpoint_here = true;
        }

        private static void TestVisionApi()
        {
            var image = GetSampleFile("jpg");
            var result = _client.Vision.Annotate(new string[] { image });

            var detectedStuff = result.Responses.FirstOrDefault()?.LabelAnnotations.Select(label => label.Description).ToArray();
            var put_a_breakpoint_here = true;
        }

        private static void TestSpeechToTextApi()
        {
            var sound = GetSampleFile("raw");
            var result = _client.SpeechToText.Recognize(sound);

            var detectedSentence = result.Results.FirstOrDefault()?.Alternatives.FirstOrDefault()?.Transcript;
            var put_a_breakpoint_here = true;
        }

        private static void TestTextToSpeechApi()
        {
            var result = _client.TextToSpeech.Synthesize("Hello, this is me.");

            if (!string.IsNullOrWhiteSpace(result.AudioContent))
            {
                File.WriteAllBytes("result.mp3", result.GetAudioContentAsBytes());
            }

            var put_a_breakpoint_here = true;
        }

        private static void TestTranslateApi()
        {
            var text = "古代書面汉语称为文言文，现代书面汉语一般指使用現代標準漢語語法、詞彙的中文通行文体（又称白话文）。";
            var detectResponse = _client.Translate.Detect(text);
            var detectedLanguage = detectResponse.Data.Detections.First().First().Language;
            var translateResponse = _client.Translate.Do(text, detectedLanguage, "fr");

            Console.WriteLine(translateResponse.Data?.Translations?.FirstOrDefault()?.TranslatedText);

            var put_a_breakpoint_here = true;
        }

        private static void TestVideoIntelligenceApi()
        {
            var videoSourceUrl = "gs://cloudmleap/video/next/JaneGoodall.mp4"; // Google sample
            var operation = _client.VideoIntelligence.Annotate(videoSourceUrl);
            var response = _client.VideoIntelligence.GetResponse(operation.Name);

            var detectedStuff = new string[0];

            while (!response.Done)
            {
                response = _client.VideoIntelligence.GetResponse(operation.Name);
                Task.Delay(TimeSpan.FromSeconds(10)).Wait();
                detectedStuff = response.Response?.AnnotationResults?.FirstOrDefault()?.ShotLabelAnnotations?.Select(l => l.Entity.Description)?.ToArray();
            }

            var put_a_breakpoint_here = true;
        }

        public static string GetSampleFile(string fileHint, bool toBase64 = true)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = assembly.GetManifestResourceNames().FirstOrDefault(name => name.ToLower().Contains(fileHint));
            using (var fileStream = assembly.GetManifestResourceStream(resourceName))
            {
                if (fileStream == null) { return null; }

                if (!toBase64)
                {
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        return reader.ReadToEnd();
                    }
                }

                var bytes = new byte[fileStream.Length];
                fileStream.Read(bytes, 0, bytes.Length);
                return Convert.ToBase64String(bytes);
            }
        }
    }
}

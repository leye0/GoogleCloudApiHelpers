namespace GoogleCloudApiHelper.NaturalLanguageApi
{
    public class Mention
    {
        public TextSpan Text { get; set; }
        public string Type { get; set; }
        public Sentiment Sentiment { get; set; }
    }
}

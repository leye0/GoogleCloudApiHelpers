namespace GoogleCloudApiHelper.NaturalLanguageApi
{
    public class NaturalLanguageResult
    {
        public Sentence[] Sentences { get; set; }
        public Token[] Tokens { get; set; }
        public Entity[] Entities { get; set; }
        public Category[] Categories { get; set; }
        public string Language { get; set; }
        public Sentiment DocumentSentiment { get; set; }
    }

}

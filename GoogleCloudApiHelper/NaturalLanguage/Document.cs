namespace GoogleCloudApiHelper.NaturalLanguageApi
{
    public class NaturalLanguageRequestDocument
    {
        public NaturalLanguageRequestDocument(string content)
        {
            Content = content;
            Type = "PLAIN_TEXT";
        }
        public string Type { get; set; }
        public string Content { get; set; }
    }
}

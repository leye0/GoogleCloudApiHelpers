namespace GoogleCloudApiHelper.NaturalLanguageApi
{
    public class NaturalLanguageRequestFeatures
    {
        public NaturalLanguageRequestFeatures(bool extractSyntax, bool extractEntities, bool extractDocumentSentiment, bool extractEntitySentiment, bool classifyText)
        {
            ExtractSyntax = extractSyntax;
            ExtractEntities = extractEntities;
            ExtractDocumentSentiment = extractDocumentSentiment;
            ExtractEntitySentiment = extractEntitySentiment;
            ClassifyText = classifyText;
        }

        public bool ExtractSyntax { get; set; }
        public bool ExtractEntities { get; set; }
        public bool ExtractDocumentSentiment { get; set; }
        public bool ExtractEntitySentiment { get; set; }
        public bool ClassifyText { get; set; }
    }
}

namespace GoogleCloudApiHelper.NaturalLanguageApi
{
    public class NaturalLanguageRequest
    {
        public NaturalLanguageRequest(NaturalLanguageRequestDocument document)
        {
            Document = document;
        }

        public NaturalLanguageRequestDocument Document { get; set; }
    }

    public class NaturalLanguageRequestWithEncodingType : NaturalLanguageRequest
    {
        public NaturalLanguageRequestWithEncodingType(NaturalLanguageRequestDocument document, NaturalLanguageRequestFeatures features) : base(document)
        {
            Features = features;
        }
        public NaturalLanguageRequestFeatures Features { get; set; }
        public string EncodingType { get; set; } = "UTF16";
    }
}

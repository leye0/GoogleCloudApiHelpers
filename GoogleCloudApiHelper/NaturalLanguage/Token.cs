namespace GoogleCloudApiHelper.NaturalLanguageApi
{
    public class Token
    {
        public PartOfSpeech PartOfSpeech { get; set; }
        public TextSpan Text { get; set; }
        public string Lemma { get; set; }
        public DependencyEdge DependencyEdge { get; set; }
    }
}

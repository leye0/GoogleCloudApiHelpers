namespace GoogleCloudApiHelper.NaturalLanguageApi
{
    public class Entity
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public Metadata Metadata { get; set; }
        public float Salience { get; set; }
        public Mention[] Mentions { get; set; }
        public Sentiment Sentiment { get; set; }
    }

}

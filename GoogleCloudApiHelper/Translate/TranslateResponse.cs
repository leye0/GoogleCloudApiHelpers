namespace GoogleCloudApiHelper.TranslateApi
{
    public partial class TranslateResponse
    {
        public Data Data { get; set; }
    }

    public partial class Data
    {
        public Detection[][] Detections { get; set; }
        public Translation[] Translations { get; set; }
    }

    public partial class Translation
    {
        public string TranslatedText { get; set; }
    }


    public partial class Detection
    {
        public bool IsReliable { get; set; }
        public string Language { get; set; }
        public long Confidence { get; set; }
    }

}

namespace GoogleCloudApiHelper.SpeechToTextApi

{
    public partial class SpeechToTextResponse
    {
        public Result[] Results { get; set; }
    }

    public partial class Result
    {
        public Alternative[] Alternatives { get; set; }
    }

    public partial class Alternative
    {
        public string Transcript { get; set; }
        public double Confidence { get; set; }
    }

}

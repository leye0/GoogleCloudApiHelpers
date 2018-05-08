namespace GoogleCloudApiHelper.SpeechToTextApi

{
    public partial class SpeechToTextRequest
    {
        public SpeechToTextRequest(string linear16AudioAsBase64)
        {
            Config = new SpeechToTextConfig();
            Audio = new Audio { Content = linear16AudioAsBase64 };
        }

        public SpeechToTextConfig Config { get; set; }

        public Audio Audio { get; set; }
    }

    public partial class Audio
    {
        public string Content { get; set; }
    }

    public partial class SpeechToTextConfig
    {
        public SpeechToTextConfig()
        {
            // For now, use Linear16 default
            // sox myfile --channels=1 --rate 16k --bits 16 audio.raw
            Encoding = "LINEAR16";
            LanguageCode = "en-US";
            // SampleRateHertz = 48000;
            EnableWordTimeOffsets = true;
            SampleRateHertz = 16000;
            EnableAutomaticPunctuation = true;

            // command_and_search
            // Best for short queries such as voice commands or voice search.

            // phone_call
            // Best for audio that originated from a phone call (typically recorded at an 8khz sampling rate)

            // video
            // Best for audio that originated from video or includes multiple speakers. Ideally the audio is recorded at a 16khz or greater sampling rate. This is a premium model that costs more than the standard rate.

            // default
            // Best for audio that is not one of the specific audio models. For example, long-form audio. Ideally the audio is high-fidelity, recorded at a 16khz or greater sampling rate.

            Model = "default";

        }
        public string Encoding { get; set; }
        public string LanguageCode { get; set; }
        public long SampleRateHertz { get; set; }
        public bool EnableWordTimeOffsets { get; set; }
        public bool EnableAutomaticPunctuation { get; set; }
        public string Model { get; set; }
    }

}

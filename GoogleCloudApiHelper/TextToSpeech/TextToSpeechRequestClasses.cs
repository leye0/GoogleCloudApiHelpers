namespace GoogleCloudApiHelper.TextToSpeechApi
{
    public class Input
    {
        public Input(string text)
        {
            Text = text;
        }
        public string Text { get; set; }
    }

    public class Voice
    {
        public string LanguageCode { get; set; }
        public string Name { get; set; }
        public string SsmlGender { get; set; }
    }

    public class AudioConfig
    {
        public string AudioEncoding { get; set; }
    }

    public class TextToSpeechRequest
    {
        public TextToSpeechRequest(string text)
        {
            Input = new Input(text);

            // For now, hardcoded to:
            Voice = new Voice
            {
                LanguageCode = "en-gb",
                Name = "en-GB-Standard-A",
                SsmlGender = "FEMALE"
            };

            AudioConfig = new AudioConfig
            {
                AudioEncoding = "MP3"
            };
        }
        public Input Input { get; set; }
        public Voice Voice { get; set; }
        public AudioConfig AudioConfig { get; set; }
    }
}

using System;

namespace GoogleCloudApiHelper.TextToSpeechApi
{
    public class TextToSpeechResponse
    {
        public string AudioContent { get; set; }
        public byte[] GetAudioContentAsBytes()
        {
            return Convert.FromBase64String(AudioContent);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace GoogleCloudApiHelper.VideoIntelligenceApi
{
    public partial class VideoIntelligenceRequest
    {
        public VideoIntelligenceRequest(string videoSourceUrl)
        {
            InputUri = videoSourceUrl;

            // For now, hardcoded:
            Features = new string[] { "EXPLICIT_CONTENT_DETECTION", "LABEL_DETECTION", "SHOT_CHANGE_DETECTION" };
        }
        public string InputUri { get; set; }
        public string[] Features { get; set; }
    }
}

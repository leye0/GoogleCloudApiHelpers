using System.Linq;

namespace GoogleCloudApiHelper.VisionApi
{

    public class VisionRequestItem
    {
        public VisionRequestItem(string image)
        {
            // Include all features for now:
            var features = new string[]
            {
                "TYPE_UNSPECIFIED",
                "LANDMARK_DETECTION",
                "FACE_DETECTION",
                "LOGO_DETECTION",
                "LABEL_DETECTION",
                "TEXT_DETECTION",
                "DOCUMENT_TEXT_DETECTION",
                "SAFE_SEARCH_DETECTION",
                "IMAGE_PROPERTIES",
                "CROP_HINTS",
                "WEB_DETECTION"
            };

            Features = features
                .Select(feature => new VisionFeature { Type = feature, MaxResults = 50 })
                .ToArray();

            Image = new Image
            {
                Content = image,
            };

            // For now, just provide the default aspect ratio
            ImageContext = new ImageContext
            {
                CropHintsParams = new CropHintsParams { AspectRatios = new float[] { 0.8f, 1f, 1.2f } }
            };
        }
    
        public Image Image { get; set; }
        public ImageContext ImageContext { get; set; }
        public VisionFeature[] Features { get; set; }
    }
}

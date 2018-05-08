namespace GoogleCloudApiHelper.VisionApi
{
    public partial class VisionResponseItem
    {
        public Annotation[] LogoAnnotations { get; set; }
        public Annotation[] LabelAnnotations { get; set; }
        public SafeSearchAnnotation SafeSearchAnnotation { get; set; }
        public ImagePropertiesAnnotation ImagePropertiesAnnotation { get; set; }
        public CropHintsAnnotation CropHintsAnnotation { get; set; }
        public WebDetection WebDetection { get; set; }
    }

    public partial class CropHintsAnnotation
    {
        public CropHint[] CropHints { get; set; }
    }

    public partial class CropHint
    {
        public BoundingPoly BoundingPoly { get; set; }
        public double Confidence { get; set; }
        public double ImportanceFraction { get; set; }
    }

    public partial class BoundingPoly
    {
        public Vertex[] Vertices { get; set; }
    }

    public partial class Vertex
    {
        public long? X { get; set; }
        public long? Y { get; set; }
    }

    public partial class ImagePropertiesAnnotation
    {
        public DominantColors DominantColors { get; set; }
    }

    public partial class DominantColors
    {
        public ColorElement[] Colors { get; set; }
    }

    public partial class ColorElement
    {
        public Color Color { get; set; }
        public double Score { get; set; }
        public double PixelFraction { get; set; }
    }

    public partial class Color
    {
        public long Red { get; set; }
        public long Green { get; set; }
        public long Blue { get; set; }
    }

    public partial class Annotation
    {
        public string Mid { get; set; }
        public string Description { get; set; }
        public double Score { get; set; }
        public double? Topicality { get; set; }
        public BoundingPoly BoundingPoly { get; set; }
    }

    public partial class SafeSearchAnnotation
    {
        public string Adult { get; set; }
        public string Spoof { get; set; }
        public string Medical { get; set; }
        public string Violence { get; set; }
        public string Racy { get; set; }
    }

    public partial class WebDetection
    {
        public WebEntity[] WebEntities { get; set; }
        public ImageSource[] PartialMatchingImages { get; set; }
        public PagesWithMatchingImage[] PagesWithMatchingImages { get; set; }
        public ImageSource[] VisuallySimilarImages { get; set; }
        public BestGuessLabel[] BestGuessLabels { get; set; }
    }

    public partial class BestGuessLabel
    {
        public string Label { get; set; }
        public string LanguageCode { get; set; }
    }

    public partial class PagesWithMatchingImage
    {
        public string Url { get; set; }
        public string PageTitle { get; set; }
        public ImageSource[] PartialMatchingImages { get; set; }
    }

    public partial class ImageSource
    {
        public string Url { get; set; }
    }

    public partial class WebEntity
    {
        public string EntityId { get; set; }
        public double Score { get; set; }
        public string Description { get; set; }
    }
}

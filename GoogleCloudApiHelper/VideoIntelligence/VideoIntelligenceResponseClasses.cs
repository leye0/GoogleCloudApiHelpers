using System;

namespace GoogleCloudApiHelper.VideoIntelligenceApi
{
    public partial class VideoIntelligenceOperationsUri
    {
        public string Name { get; set; }
    }

    public partial class VideoIntelligenceResponse
    {
        public string Name { get; set; }
        public Metadata Metadata { get; set; }
        public bool Done { get; set; }
        public Response Response { get; set; }
    }

    public partial class Metadata
    {
        public string Type { get; set; }
        public AnnotationProgress[] AnnotationProgress { get; set; }
    }

    public partial class AnnotationProgress
    {
        public string InputUri { get; set; }
        public long ProgressPercent { get; set; }
        public DateTimeOffset StartTime { get; set; }
        public DateTimeOffset UpdateTime { get; set; }
    }

    public partial class Response
    {
        public string Type { get; set; }
        public AnnotationResult[] AnnotationResults { get; set; }
    }

    public partial class AnnotationResult
    {
        public string InputUri { get; set; }
        public TLabelAnnotation[] SegmentLabelAnnotations { get; set; }
        public TLabelAnnotation[] ShotLabelAnnotations { get; set; }
        public ShotAnnotation[] ShotAnnotations { get; set; }
        public ExplicitAnnotation ExplicitAnnotation { get; set; }
    }

    public partial class ExplicitAnnotation
    {
        public Frame[] Frames { get; set; }
    }

    public partial class Frame
    {
        public string TimeOffset { get; set; }
        public string PornographyLikelihood { get; set; }
    }

    public partial class TLabelAnnotation
    {
        public Entity Entity { get; set; }
        public SegmentItem[] Segments { get; set; }
        public Entity[] CategoryEntities { get; set; }
    }

    public partial class Entity
    {
        public string EntityId { get; set; }
        public string Description { get; set; }
        public string LanguageCode { get; set; }
    }

    public partial class SegmentItem
    {
        public ShotAnnotation Segment { get; set; }
        public double Confidence { get; set; }
    }

    public partial class ShotAnnotation
    {
        public string StartTimeOffset { get; set; }
        public string EndTimeOffset { get; set; }
    }
}
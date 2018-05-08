using System.Linq;

namespace GoogleCloudApiHelper.VisionApi
{
    public class VisionRequest
    {
        public VisionRequest(string[] images)
        {
            Requests = images.Select(image => new VisionRequestItem(image)).ToArray();
        }

        public VisionRequestItem[] Requests { get; set; }
    }
}

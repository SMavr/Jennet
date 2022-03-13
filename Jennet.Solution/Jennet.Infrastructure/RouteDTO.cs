namespace Jennet.Infrastructure
{
    public class RouteDTO
    {
        public string UpstreamPathTemplate { get; set; }
        public string DownstreamPathTemplate { get; set; }
        public string DownstreamScheme { get; set; }
        public List<DownstreamHostAndPorts> DownstreamHostAndPorts { get; set; }
    }
}
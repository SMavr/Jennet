namespace Jennet.Infrastructure
{
    public class RouteDTO
    {
        public string UpstreamPathTemplate { get; init; }
        public string DownstreamPathTemplate { get; init; }
        public string DownstreamScheme { get; init; }
        public List<DownstreamHostAndPorts> DownstreamHostAndPorts { get; init; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jennet.Infrastructure
{
    public class RouteDTO
    {
        public string UpstreamPathTemplate { get; set; }
        public string DownstreamPathTemplate { get; set; }
        public string DownstreamScheme { get; set; }
        public List<DownstreamHostAndPorts> DownstreamHostAndPorts { get; set; }
    }

    public class DownstreamHostAndPorts
    {
        public string Host { get; set; }

        public int Port { get; set; }
    }
}
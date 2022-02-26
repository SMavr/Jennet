using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jennet.UI
{
    public class RouteDTO
    {
        public int UpstreamPathTemplate { get; set; }
        public int DownstreamPathTemplate { get; set; }
        public int DownstreamScheme { get; set; }
        public int DownstreamHostAndPorts { get; set; }
    }
}
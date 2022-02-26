using System.Collections.Generic;
using System.Text.Json;
using Xunit;

namespace Jennet.Tests
{
    public class UnitTest1
    {
        string jsonString =
@"
{
  ""ReRoutes"":[
   {
      ""UpstreamPathTemplate"":""test"", 
     ""DownstreamPathTemplate"": ""test""
    },
    {
          ""UpstreamPathTemplate"":""test1"", 
          ""DownstreamPathTemplate"": ""test1""
    }
]

}
";

        [Fact]
        public void Test1()
        {
            var test =  JsonSerializer.Deserialize<OcelotResult>(jsonString);
        }

        private class Route
        {
            public string UpstreamPathTemplate { get; set; }
            public string DownstreamPathTemplate { get; set; }
        }

        private class OcelotResult
        {
            public List<Route> ReRoutes { get; set; }
        }

    }

    
}
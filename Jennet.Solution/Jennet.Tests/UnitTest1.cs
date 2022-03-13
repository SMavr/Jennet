using Jennet.Infrastructure;
using Jennet.UI;
using System;
using System.Collections.Generic;
using System.IO;
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
            string text = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,  @"..\..\..\..\Test.json"));

            var test =  JsonSerializer.Deserialize<OcelotDTO>(text);
        }

     

    }

    
}
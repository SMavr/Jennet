using Jennet.Infrastructure;
using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using Xunit;

namespace Jennet.Tests
{
    public class JSONTests
    {
        [Fact]
        public void Test1()
        {
            string text = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,  @"..\..\..\..\Test.json"));

            
            var test =  JsonSerializer.Deserialize<OcelotDTO>(text);
        }

    }
}
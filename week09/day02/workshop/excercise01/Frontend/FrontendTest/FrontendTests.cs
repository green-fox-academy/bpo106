using Frontend;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Frontend.Models;

namespace FrontendTest
{
    public class FrontendTests
    {
        private readonly TestServer Server;
        private readonly HttpClient Client;

        public FrontendTests()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task DoublingReturnOkStatus()
        {
            var response = await Client.GetAsync("/doubling?input=5");
            string responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task DoublingReturnRight()
        {
            var response = await Client.GetAsync("/doubling?input=5");
            string responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"received\":5,\"result\":10}", responseJson);
        }

        [Fact]
        public async Task DoublingReturnError()
        {
            var response = await Client.GetAsync("/doubling");
            string responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"error\":\"Please provide an input!\"}", responseJson);
        }

        [Fact]
        public async Task GreeterReturnOkStatus()
        {
            var response = await Client.GetAsync("/greeter?name=Petike&title=student");
            string responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task GreeterReturnRight()
        {
            var response = await Client.GetAsync("/greeter?name=Petike&title=student");
            string responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"welcome_message\":\"Oh, hi there Petike, my dear student!\"}", responseJson);
        }

        [Fact]
        public async Task GreeterReturnNamelessError()
        {
            var response = await Client.GetAsync("/greeter?title=student");
            string responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"error\":\"Please provide a name!\"}", responseJson);
        }

        [Fact]
        public async Task GreeterReturnTitlelessError()
        {
            var response = await Client.GetAsync("/greeter?name=Petike");
            string responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"error\":\"Please provide a title!\"}", responseJson);
        }

        [Fact]
        public async Task AppendaReturnOkStatus()
        {
            var response = await Client.GetAsync("/appenda/kuty");
            string responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task AppendaReturnNotFound()
        {
            var response = await Client.GetAsync("/appenda");
            string responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }

        [Fact]
        public async Task AppendaReturnRight()
        {
            var response = await Client.GetAsync("/appenda/kuty");
            string responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"appended\":\"kutya\"}", responseJson);
        }

        [Fact]
        public async Task DountilReturnOkStatus()
        {
            var data = new { result = "120" };
            var content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
            var response = await Client.PostAsync("/dountil/factor", content);

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task DountilReturnSum()
        {
            var data = new BasicClass { until = 5 };
            var content = new StringContent(JsonConvert.SerializeObject(data).ToString(), encoding: Encoding.UTF8, mediaType: "application/json");
            var response = await Client.PostAsync("/dountil/sum", content);
            string responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"result\":\"15\"}", responseJson);
        }

        [Fact]
        public async Task DountilReturnFactor()
        {
            var data = new BasicClass { until = 5 };
            var content = new StringContent(JsonConvert.SerializeObject(data).ToString(), encoding: Encoding.UTF8, mediaType: "application/json");
            var response = await Client.PostAsync("/dountil/factor", content);
            string responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"result\":\"120\"}", responseJson);
        }

        [Fact]
        public async Task DountilReturnNumberlessError()
        {
            var data = new BasicClass();
            var content = new StringContent(JsonConvert.SerializeObject(data).ToString(), encoding: Encoding.UTF8, mediaType: "application/json");
            var response = await Client.PostAsync("/dountil/sum", content);
            string responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"error\":\"Please provide a number!\"}", responseJson);
        }

        [Fact]
        public async Task DountilReturnInputlessError()
        {
            var data = new BasicClass { until = 5 };
            var content = new StringContent(JsonConvert.SerializeObject(data).ToString(), encoding: Encoding.UTF8, mediaType: "application/json");
            var response = await Client.PostAsync("/dountil", content);
            string responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"error\":\"Please provide an input!\"}", responseJson);
        }
    }
}

using Frontend;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using System;
using System.Collections.Generic;

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
    }
}

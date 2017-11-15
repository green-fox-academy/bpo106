using BusListManager;
using BusListTest.TestFixtures;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
namespace BusListTest
{
    public class ListTests
    {
        private HttpClient Client;
        private TestServer Server;

        public ListTests()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        //Mock server and other issues

        //[Fact]
        //public async Task TestStatusCode()
        //{
        //   var response = await Client.GetAsync("/");
        //   Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        //}

        [Fact]
        public async Task MyRandomTest()
        {
            var response = await Client.GetAsync("/list");
            string responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"error\":\"I am Groot!\"}", responseJson);
        }
    }
}

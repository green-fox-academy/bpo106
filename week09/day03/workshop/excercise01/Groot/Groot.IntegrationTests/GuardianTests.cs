using Groot.IntegrationTests.TestFixtures;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Groot.IntegrationTests
{
    public class GuardianTests
    {
        private HttpClient Client;
        private TestServer Server;

        public GuardianTests()
        {
            //arrange
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task IndexShouldReturnOkStatus()
        {
            //act
            var response = await Client.GetAsync("/");

            //assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task RandomTestName()
        {
            var response = await Client.GetAsync("/groot?message=somemessage");
            string responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"received\":\"somemessage\",\"translated\":\"I am Groot!\"}", responseJson);
        }

        [Fact]
        public async Task NamelessError()
        {
            var response = await Client.GetAsync("/groot");
            string responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"error\":\"I am Groot!\"}", responseJson);
        }
    }
}

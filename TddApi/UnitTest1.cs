using Newtonsoft.Json;
using NUnit.Framework;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace TddApi
{
    public class Tests: MultiServerBaseTest
    {
        TestClientFactory cf;
        [SetUp()]
        public override void Setup()
        {
            base.Setup();
            cf = this.GetTestClientFactory();
        }
        [Test]
        public async Task Test1()
        {
            var Client=  cf.CreateClient(null);
            var Response = await Client.GetStringAsync("/Test/fetch");
            Assert.IsNotNull(Response);

            List<string> Data = JsonConvert.DeserializeObject<List<string>>(Response);

            Assert.AreEqual(2, Data.Count);
        }
    }
}
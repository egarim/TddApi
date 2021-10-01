
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BIT.EfCore.Sync.Test.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {


        private readonly ILogger<TestController> _logger;
     
        protected string GetHeader(string HeaderName)
        {
            return this.HttpContext.Request.Headers[HeaderName];
        }


        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
            
        }
        [HttpGet("Fetch")]
        public async Task<IEnumerable<string>> Fetch()
        {
            var data = new List<string>();
            data.Add("Hello");
            data.Add("GoodBye");
            return data;

        }
        

    }
}

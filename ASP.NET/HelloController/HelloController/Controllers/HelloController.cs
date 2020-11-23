using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Docs.Samples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloController.Controllers
{
    public class HelloController : ControllerBase
    {
        [Route("hello/Say")]
        [Route("hello/{action}")]

        public String SayHello()
        {
            return "Hello !";
        }
        [Route("hello/Yell")]
        [Route("hello/{action}")]

        public String YellHello()
        {
            return "HELLO !";
        }

        
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Docs.Samples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloController.Controllers
{

    public class Hello2Controller
    {
        [Route("/Say")]
        public String SayAHello()
        {
            return "Hello via attribut !";
        }

        [Route("/Yell")]
        public String YellAHello()
        {
            return "HELLO VIA ATTRIBUT !";
        }
    }
}

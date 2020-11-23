using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloController.Controllers
{
    public class HelloController : ControllerBase
    {
        public String SayHello()
        {
            return "Hello via conventionel !";
        }

        public String YellHello()
        {
            return "HELLO VIA CONVENTIONEL!";
        }
    }
}

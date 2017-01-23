using Microsoft.Azure.Mobile.Server.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TPTwo.Controllers
{
    [MobileAppController]
    public class IdentityController : ApiController
    {
        // GET api/values
        public string Get()
        {
            return "Hello World!";
        }

        // POST api/values
        public string Post()
        {
            return "Hello World!";
        }




    }
}

using System.Web.Http;
using Microsoft.Azure.Mobile.Server.Config;

namespace TPTwo.Controllers
{
    // Use the MobileAppController attribute for each ApiController you want to use  
    // from your mobile clients 
    [MobileAppController]
    public class ValuesController : ApiController
    {
        // GET api/values
        public string Get()
        {
            return "Get: Hello World!";
        }

        // POST api/values
        public string Post()
        {
            return "Post: Hello World!";
        }
    }
}

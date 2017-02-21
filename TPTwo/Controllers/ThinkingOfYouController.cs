using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.Azure.Mobile.Server;
using TPTwo.DataObjects;
using TPTwo.Models;

namespace TPTwo.Controllers
{
    public class ThinkingOfYouController : TableController<ThinkingOfYou>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            MobileServiceContext context = new MobileServiceContext();
            DomainManager = new EntityDomainManager<ThinkingOfYou>(context, Request);
        }

        // GET tables/ThinkingOfYou
        public IQueryable<ThinkingOfYou> GetAllThinkingOfYou()
        {
            return Query(); 
        }

        // GET tables/ThinkingOfYou/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<ThinkingOfYou> GetThinkingOfYou(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/ThinkingOfYou/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<ThinkingOfYou> PatchThinkingOfYou(string id, Delta<ThinkingOfYou> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/ThinkingOfYou
        public async Task<IHttpActionResult> PostThinkingOfYou(ThinkingOfYou item)
        {
            ThinkingOfYou current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/ThinkingOfYou/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteThinkingOfYou(string id)
        {
             return DeleteAsync(id);
        }
    }
}

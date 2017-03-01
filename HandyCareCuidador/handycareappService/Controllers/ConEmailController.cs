using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.Azure.Mobile.Server;
using handycareappService.DataObjects;
using handycareappService.Models;

namespace handycareappService.Controllers
{
    public class ConEmailController : TableController<ConEmail>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            handycareappContext context = new handycareappContext();
            DomainManager = new EntityDomainManager<ConEmail>(context, Request);
        }

        // GET tables/ConEmail
        public IQueryable<ConEmail> GetAllConEmail()
        {
            return Query(); 
        }

        // GET tables/ConEmail/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<ConEmail> GetConEmail(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/ConEmail/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<ConEmail> PatchConEmail(string id, Delta<ConEmail> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/ConEmail
        public async Task<IHttpActionResult> PostConEmail(ConEmail item)
        {
            ConEmail current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/ConEmail/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteConEmail(string id)
        {
             return DeleteAsync(id);
        }
    }
}

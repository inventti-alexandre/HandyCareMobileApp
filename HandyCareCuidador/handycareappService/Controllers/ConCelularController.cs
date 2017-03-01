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
    public class ConCelularController : TableController<ConCelular>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            handycareappContext context = new handycareappContext();
            DomainManager = new EntityDomainManager<ConCelular>(context, Request);
        }

        // GET tables/ConCelular
        public IQueryable<ConCelular> GetAllConCelular()
        {
            return Query(); 
        }

        // GET tables/ConCelular/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<ConCelular> GetConCelular(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/ConCelular/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<ConCelular> PatchConCelular(string id, Delta<ConCelular> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/ConCelular
        public async Task<IHttpActionResult> PostConCelular(ConCelular item)
        {
            ConCelular current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/ConCelular/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteConCelular(string id)
        {
             return DeleteAsync(id);
        }
    }
}

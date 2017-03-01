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
    public class ConTelefoneController : TableController<ConTelefone>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            handycareappContext context = new handycareappContext();
            DomainManager = new EntityDomainManager<ConTelefone>(context, Request);
        }

        // GET tables/ConTelefone
        public IQueryable<ConTelefone> GetAllConTelefone()
        {
            return Query(); 
        }

        // GET tables/ConTelefone/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<ConTelefone> GetConTelefone(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/ConTelefone/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<ConTelefone> PatchConTelefone(string id, Delta<ConTelefone> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/ConTelefone
        public async Task<IHttpActionResult> PostConTelefone(ConTelefone item)
        {
            ConTelefone current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/ConTelefone/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteConTelefone(string id)
        {
             return DeleteAsync(id);
        }
    }
}

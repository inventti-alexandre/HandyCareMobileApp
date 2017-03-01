using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.Azure.Mobile.Server;
using handycareappService.DataObjects;
using handycareappService.Models;
using Microsoft.Azure.Mobile.Server.Config;

namespace handycareappService.Controllers
{
    [Authorize]
    [MobileAppController]
    public class CuidadorController : TableController<Cuidador>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            handycareappContext context = new handycareappContext();
            DomainManager = new EntityDomainManager<Cuidador>(context, Request);
        }

        // GET tables/Cuidador
        public IQueryable<Cuidador> GetAllCuidador()
        {
            return Query(); 
        }

        // GET tables/Cuidador/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Cuidador> GetCuidador(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Cuidador/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Cuidador> PatchCuidador(string id, Delta<Cuidador> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/Cuidador
        public async Task<IHttpActionResult> PostCuidador(Cuidador item)
        {
            Cuidador current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Cuidador/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteCuidador(string id)
        {
             return DeleteAsync(id);
        }
    }
}

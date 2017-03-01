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
    public class ContatoEmergenciaController : TableController<ContatoEmergencia>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            handycareappContext context = new handycareappContext();
            DomainManager = new EntityDomainManager<ContatoEmergencia>(context, Request);
        }

        // GET tables/ContatoEmergencia
        public IQueryable<ContatoEmergencia> GetAllContatoEmergencia()
        {
            return Query(); 
        }

        // GET tables/ContatoEmergencia/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<ContatoEmergencia> GetContatoEmergencia(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/ContatoEmergencia/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<ContatoEmergencia> PatchContatoEmergencia(string id, Delta<ContatoEmergencia> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/ContatoEmergencia
        public async Task<IHttpActionResult> PostContatoEmergencia(ContatoEmergencia item)
        {
            ContatoEmergencia current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/ContatoEmergencia/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteContatoEmergencia(string id)
        {
             return DeleteAsync(id);
        }
    }
}

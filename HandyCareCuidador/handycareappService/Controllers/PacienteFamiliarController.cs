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
    public class PacienteFamiliarController : TableController<PacienteFamiliar>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            handycareappContext context = new handycareappContext();
            DomainManager = new EntityDomainManager<PacienteFamiliar>(context, Request);
        }

        // GET tables/PacienteFamiliar
        public IQueryable<PacienteFamiliar> GetAllPacienteFamiliar()
        {
            return Query(); 
        }

        // GET tables/PacienteFamiliar/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<PacienteFamiliar> GetPacienteFamiliar(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/PacienteFamiliar/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<PacienteFamiliar> PatchPacienteFamiliar(string id, Delta<PacienteFamiliar> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/PacienteFamiliar
        public async Task<IHttpActionResult> PostPacienteFamiliar(PacienteFamiliar item)
        {
            PacienteFamiliar current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/PacienteFamiliar/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeletePacienteFamiliar(string id)
        {
             return DeleteAsync(id);
        }
    }
}

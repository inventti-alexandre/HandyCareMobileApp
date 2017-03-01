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
    public class CuidadorPacienteController : TableController<CuidadorPaciente>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            handycareappContext context = new handycareappContext();
            DomainManager = new EntityDomainManager<CuidadorPaciente>(context, Request);
        }

        // GET tables/CuidadorPaciente
        public IQueryable<CuidadorPaciente> GetAllCuidadorPaciente()
        {
            return Query(); 
        }

        // GET tables/CuidadorPaciente/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<CuidadorPaciente> GetCuidadorPaciente(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/CuidadorPaciente/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<CuidadorPaciente> PatchCuidadorPaciente(string id, Delta<CuidadorPaciente> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/CuidadorPaciente
        public async Task<IHttpActionResult> PostCuidadorPaciente(CuidadorPaciente item)
        {
            CuidadorPaciente current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/CuidadorPaciente/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteCuidadorPaciente(string id)
        {
             return DeleteAsync(id);
        }
    }
}

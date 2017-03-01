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
    public class PacienteController : TableController<Paciente>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            handycareappContext context = new handycareappContext();
            DomainManager = new EntityDomainManager<Paciente>(context, Request);
        }

        // GET tables/Paciente
        public IQueryable<Paciente> GetAllPaciente()
        {
            return Query(); 
        }

        // GET tables/Paciente/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Paciente> GetPaciente(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Paciente/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Paciente> PatchPaciente(string id, Delta<Paciente> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/Paciente
        public async Task<IHttpActionResult> PostPaciente(Paciente item)
        {
            Paciente current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Paciente/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeletePaciente(string id)
        {
             return DeleteAsync(id);
        }
    }
}

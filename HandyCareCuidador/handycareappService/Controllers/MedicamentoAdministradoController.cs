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
    public class MedicamentoAdministradoController : TableController<MedicamentoAdministrado>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            handycareappContext context = new handycareappContext();
            DomainManager = new EntityDomainManager<MedicamentoAdministrado>(context, Request);
        }

        // GET tables/MedicamentoAdministrado
        public IQueryable<MedicamentoAdministrado> GetAllMedicamentoAdministrado()
        {
            return Query(); 
        }

        // GET tables/MedicamentoAdministrado/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<MedicamentoAdministrado> GetMedicamentoAdministrado(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/MedicamentoAdministrado/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<MedicamentoAdministrado> PatchMedicamentoAdministrado(string id, Delta<MedicamentoAdministrado> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/MedicamentoAdministrado
        public async Task<IHttpActionResult> PostMedicamentoAdministrado(MedicamentoAdministrado item)
        {
            MedicamentoAdministrado current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/MedicamentoAdministrado/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteMedicamentoAdministrado(string id)
        {
             return DeleteAsync(id);
        }
    }
}

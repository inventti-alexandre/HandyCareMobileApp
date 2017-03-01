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
    public class SubtipoFormaAdministracaoMedicamentoController : TableController<SubtipoFormaAdministracaoMedicamento>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            handycareappContext context = new handycareappContext();
            DomainManager = new EntityDomainManager<SubtipoFormaAdministracaoMedicamento>(context, Request);
        }

        // GET tables/SubtipoFormaAdministracaoMedicamento
        public IQueryable<SubtipoFormaAdministracaoMedicamento> GetAllSubtipoFormaAdministracaoMedicamento()
        {
            return Query(); 
        }

        // GET tables/SubtipoFormaAdministracaoMedicamento/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<SubtipoFormaAdministracaoMedicamento> GetSubtipoFormaAdministracaoMedicamento(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/SubtipoFormaAdministracaoMedicamento/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<SubtipoFormaAdministracaoMedicamento> PatchSubtipoFormaAdministracaoMedicamento(string id, Delta<SubtipoFormaAdministracaoMedicamento> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/SubtipoFormaAdministracaoMedicamento
        public async Task<IHttpActionResult> PostSubtipoFormaAdministracaoMedicamento(SubtipoFormaAdministracaoMedicamento item)
        {
            SubtipoFormaAdministracaoMedicamento current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/SubtipoFormaAdministracaoMedicamento/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteSubtipoFormaAdministracaoMedicamento(string id)
        {
             return DeleteAsync(id);
        }
    }
}

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
    public class SubtipoViaAdministracaoMedicamentoController : TableController<SubtipoViaAdministracaoMedicamento>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            handycareappContext context = new handycareappContext();
            DomainManager = new EntityDomainManager<SubtipoViaAdministracaoMedicamento>(context, Request);
        }

        // GET tables/SubtipoViaAdministracaoMedicamento
        public IQueryable<SubtipoViaAdministracaoMedicamento> GetAllSubtipoViaAdministracaoMedicamento()
        {
            return Query(); 
        }

        // GET tables/SubtipoViaAdministracaoMedicamento/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<SubtipoViaAdministracaoMedicamento> GetSubtipoViaAdministracaoMedicamento(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/SubtipoViaAdministracaoMedicamento/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<SubtipoViaAdministracaoMedicamento> PatchSubtipoViaAdministracaoMedicamento(string id, Delta<SubtipoViaAdministracaoMedicamento> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/SubtipoViaAdministracaoMedicamento
        public async Task<IHttpActionResult> PostSubtipoViaAdministracaoMedicamento(SubtipoViaAdministracaoMedicamento item)
        {
            SubtipoViaAdministracaoMedicamento current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/SubtipoViaAdministracaoMedicamento/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteSubtipoViaAdministracaoMedicamento(string id)
        {
             return DeleteAsync(id);
        }
    }
}

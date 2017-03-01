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
    public class ViaAdministracaoMedicamentoController : TableController<ViaAdministracaoMedicamento>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            handycareappContext context = new handycareappContext();
            DomainManager = new EntityDomainManager<ViaAdministracaoMedicamento>(context, Request);
        }

        // GET tables/ViaAdministracaoMedicamento
        public IQueryable<ViaAdministracaoMedicamento> GetAllViaAdministracaoMedicamento()
        {
            return Query(); 
        }

        // GET tables/ViaAdministracaoMedicamento/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<ViaAdministracaoMedicamento> GetViaAdministracaoMedicamento(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/ViaAdministracaoMedicamento/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<ViaAdministracaoMedicamento> PatchViaAdministracaoMedicamento(string id, Delta<ViaAdministracaoMedicamento> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/ViaAdministracaoMedicamento
        public async Task<IHttpActionResult> PostViaAdministracaoMedicamento(ViaAdministracaoMedicamento item)
        {
            ViaAdministracaoMedicamento current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/ViaAdministracaoMedicamento/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteViaAdministracaoMedicamento(string id)
        {
             return DeleteAsync(id);
        }
    }
}

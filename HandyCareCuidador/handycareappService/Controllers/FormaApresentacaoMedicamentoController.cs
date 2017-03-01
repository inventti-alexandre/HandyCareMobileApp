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
    public class FormaApresentacaoMedicamentoController : TableController<FormaApresentacaoMedicamento>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            handycareappContext context = new handycareappContext();
            DomainManager = new EntityDomainManager<FormaApresentacaoMedicamento>(context, Request);
        }

        // GET tables/FormaApresentacaoMedicamento
        public IQueryable<FormaApresentacaoMedicamento> GetAllFormaApresentacaoMedicamento()
        {
            return Query(); 
        }

        // GET tables/FormaApresentacaoMedicamento/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<FormaApresentacaoMedicamento> GetFormaApresentacaoMedicamento(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/FormaApresentacaoMedicamento/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<FormaApresentacaoMedicamento> PatchFormaApresentacaoMedicamento(string id, Delta<FormaApresentacaoMedicamento> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/FormaApresentacaoMedicamento
        public async Task<IHttpActionResult> PostFormaApresentacaoMedicamento(FormaApresentacaoMedicamento item)
        {
            FormaApresentacaoMedicamento current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/FormaApresentacaoMedicamento/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteFormaApresentacaoMedicamento(string id)
        {
             return DeleteAsync(id);
        }
    }
}

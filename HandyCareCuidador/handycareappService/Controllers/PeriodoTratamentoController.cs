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
    public class PeriodoTratamentoController : TableController<PeriodoTratamento>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            handycareappContext context = new handycareappContext();
            DomainManager = new EntityDomainManager<PeriodoTratamento>(context, Request);
        }

        // GET tables/PeriodoTratamento
        public IQueryable<PeriodoTratamento> GetAllPeriodoTratamento()
        {
            return Query(); 
        }

        // GET tables/PeriodoTratamento/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<PeriodoTratamento> GetPeriodoTratamento(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/PeriodoTratamento/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<PeriodoTratamento> PatchPeriodoTratamento(string id, Delta<PeriodoTratamento> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/PeriodoTratamento
        public async Task<IHttpActionResult> PostPeriodoTratamento(PeriodoTratamento item)
        {
            PeriodoTratamento current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/PeriodoTratamento/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeletePeriodoTratamento(string id)
        {
             return DeleteAsync(id);
        }
    }
}

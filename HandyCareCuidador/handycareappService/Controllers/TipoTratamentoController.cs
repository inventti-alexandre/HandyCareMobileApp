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
    public class TipoTratamentoController : TableController<TipoTratamento>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            handycareappContext context = new handycareappContext();
            DomainManager = new EntityDomainManager<TipoTratamento>(context, Request);
        }

        // GET tables/TipoTratamento
        public IQueryable<TipoTratamento> GetAllTipoTratamento()
        {
            return Query(); 
        }

        // GET tables/TipoTratamento/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<TipoTratamento> GetTipoTratamento(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/TipoTratamento/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<TipoTratamento> PatchTipoTratamento(string id, Delta<TipoTratamento> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/TipoTratamento
        public async Task<IHttpActionResult> PostTipoTratamento(TipoTratamento item)
        {
            TipoTratamento current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/TipoTratamento/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteTipoTratamento(string id)
        {
             return DeleteAsync(id);
        }
    }
}

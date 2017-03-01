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
    public class AvaliacaoController : TableController<Avaliacao>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            handycareappContext context = new handycareappContext();
            DomainManager = new EntityDomainManager<Avaliacao>(context, Request);
        }

        // GET tables/Avaliacao
        public IQueryable<Avaliacao> GetAllAvaliacao()
        {
            return Query(); 
        }

        // GET tables/Avaliacao/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Avaliacao> GetAvaliacao(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Avaliacao/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Avaliacao> PatchAvaliacao(string id, Delta<Avaliacao> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/Avaliacao
        public async Task<IHttpActionResult> PostAvaliacao(Avaliacao item)
        {
            Avaliacao current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Avaliacao/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteAvaliacao(string id)
        {
             return DeleteAsync(id);
        }
    }
}

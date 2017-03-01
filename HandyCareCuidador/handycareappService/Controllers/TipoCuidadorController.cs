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
    public class TipoCuidadorController : TableController<TipoCuidador>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            handycareappContext context = new handycareappContext();
            DomainManager = new EntityDomainManager<TipoCuidador>(context, Request);
        }

        // GET tables/TipoCuidador
        public IQueryable<TipoCuidador> GetAllTipoCuidador()
        {
            return Query(); 
        }

        // GET tables/TipoCuidador/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<TipoCuidador> GetTipoCuidador(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/TipoCuidador/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<TipoCuidador> PatchTipoCuidador(string id, Delta<TipoCuidador> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/TipoCuidador
        public async Task<IHttpActionResult> PostTipoCuidador(TipoCuidador item)
        {
            TipoCuidador current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/TipoCuidador/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteTipoCuidador(string id)
        {
             return DeleteAsync(id);
        }
    }
}

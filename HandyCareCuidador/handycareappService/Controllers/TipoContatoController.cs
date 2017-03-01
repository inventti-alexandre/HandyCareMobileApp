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
    public class TipoContatoController : TableController<TipoContato>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            handycareappContext context = new handycareappContext();
            DomainManager = new EntityDomainManager<TipoContato>(context, Request);
        }

        // GET tables/TipoContato
        public IQueryable<TipoContato> GetAllTipoContato()
        {
            return Query(); 
        }

        // GET tables/TipoContato/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<TipoContato> GetTipoContato(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/TipoContato/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<TipoContato> PatchTipoContato(string id, Delta<TipoContato> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/TipoContato
        public async Task<IHttpActionResult> PostTipoContato(TipoContato item)
        {
            TipoContato current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/TipoContato/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteTipoContato(string id)
        {
             return DeleteAsync(id);
        }
    }
}

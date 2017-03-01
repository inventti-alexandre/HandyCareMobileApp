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
    public class FotoFamiliarController : TableController<FotoFamiliar>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            handycareappContext context = new handycareappContext();
            DomainManager = new EntityDomainManager<FotoFamiliar>(context, Request);
        }

        // GET tables/FotoFamiliar
        public IQueryable<FotoFamiliar> GetAllFotoFamiliar()
        {
            return Query(); 
        }

        // GET tables/FotoFamiliar/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<FotoFamiliar> GetFotoFamiliar(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/FotoFamiliar/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<FotoFamiliar> PatchFotoFamiliar(string id, Delta<FotoFamiliar> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/FotoFamiliar
        public async Task<IHttpActionResult> PostFotoFamiliar(FotoFamiliar item)
        {
            FotoFamiliar current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/FotoFamiliar/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteFotoFamiliar(string id)
        {
             return DeleteAsync(id);
        }
    }
}

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
    public class FamiliarController : TableController<Familiar>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            handycareappContext context = new handycareappContext();
            DomainManager = new EntityDomainManager<Familiar>(context, Request);
        }

        // GET tables/Familiar
        public IQueryable<Familiar> GetAllFamiliar()
        {
            return Query(); 
        }

        // GET tables/Familiar/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Familiar> GetFamiliar(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Familiar/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Familiar> PatchFamiliar(string id, Delta<Familiar> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/Familiar
        public async Task<IHttpActionResult> PostFamiliar(Familiar item)
        {
            Familiar current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Familiar/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteFamiliar(string id)
        {
             return DeleteAsync(id);
        }
    }
}

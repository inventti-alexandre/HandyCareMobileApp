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
    public class MotivoCuidadoController : TableController<MotivoCuidado>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            handycareappContext context = new handycareappContext();
            DomainManager = new EntityDomainManager<MotivoCuidado>(context, Request);
        }

        // GET tables/MotivoCuidado
        public IQueryable<MotivoCuidado> GetAllMotivoCuidado()
        {
            return Query(); 
        }

        // GET tables/MotivoCuidado/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<MotivoCuidado> GetMotivoCuidado(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/MotivoCuidado/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<MotivoCuidado> PatchMotivoCuidado(string id, Delta<MotivoCuidado> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/MotivoCuidado
        public async Task<IHttpActionResult> PostMotivoCuidado(MotivoCuidado item)
        {
            MotivoCuidado current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/MotivoCuidado/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteMotivoCuidado(string id)
        {
             return DeleteAsync(id);
        }
    }
}

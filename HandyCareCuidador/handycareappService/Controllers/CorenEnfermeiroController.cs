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
    public class CorenEnfermeiroController : TableController<CorenEnfermeiro>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            handycareappContext context = new handycareappContext();
            DomainManager = new EntityDomainManager<CorenEnfermeiro>(context, Request);
        }

        // GET tables/CorenEnfermeiro
        public IQueryable<CorenEnfermeiro> GetAllCorenEnfermeiro()
        {
            return Query(); 
        }

        // GET tables/CorenEnfermeiro/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<CorenEnfermeiro> GetCorenEnfermeiro(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/CorenEnfermeiro/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<CorenEnfermeiro> PatchCorenEnfermeiro(string id, Delta<CorenEnfermeiro> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/CorenEnfermeiro
        public async Task<IHttpActionResult> PostCorenEnfermeiro(CorenEnfermeiro item)
        {
            CorenEnfermeiro current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/CorenEnfermeiro/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteCorenEnfermeiro(string id)
        {
             return DeleteAsync(id);
        }
    }
}

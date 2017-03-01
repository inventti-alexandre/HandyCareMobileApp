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
    public class ParentescoController : TableController<Parentesco>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            handycareappContext context = new handycareappContext();
            DomainManager = new EntityDomainManager<Parentesco>(context, Request);
        }

        // GET tables/Parentesco
        public IQueryable<Parentesco> GetAllParentesco()
        {
            return Query(); 
        }

        // GET tables/Parentesco/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Parentesco> GetParentesco(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Parentesco/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Parentesco> PatchParentesco(string id, Delta<Parentesco> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/Parentesco
        public async Task<IHttpActionResult> PostParentesco(Parentesco item)
        {
            Parentesco current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Parentesco/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteParentesco(string id)
        {
             return DeleteAsync(id);
        }
    }
}

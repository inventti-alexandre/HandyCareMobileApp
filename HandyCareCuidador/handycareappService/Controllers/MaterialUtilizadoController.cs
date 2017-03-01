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
    public class MaterialUtilizadoController : TableController<MaterialUtilizado>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            handycareappContext context = new handycareappContext();
            DomainManager = new EntityDomainManager<MaterialUtilizado>(context, Request);
        }

        // GET tables/MaterialUtilizado
        public IQueryable<MaterialUtilizado> GetAllMaterialUtilizado()
        {
            return Query(); 
        }

        // GET tables/MaterialUtilizado/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<MaterialUtilizado> GetMaterialUtilizado(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/MaterialUtilizado/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<MaterialUtilizado> PatchMaterialUtilizado(string id, Delta<MaterialUtilizado> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/MaterialUtilizado
        public async Task<IHttpActionResult> PostMaterialUtilizado(MaterialUtilizado item)
        {
            MaterialUtilizado current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/MaterialUtilizado/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteMaterialUtilizado(string id)
        {
             return DeleteAsync(id);
        }
    }
}

using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.Azure.Mobile.Server;
using handycareappService.DataObjects;
using handycareappService.Models;
using System;
using System.Net.Http;

namespace handycareappService.Controllers
{
    public class MaterialController : TableController<Material>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            handycareappContext context = new handycareappContext();
            DomainManager = new EntityDomainManager<Material>(context, Request);
        }

        // GET tables/Material
        public IQueryable<Material> GetAllMaterial()
        {
            return Query(); 
        }

        // GET tables/Material/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Material> GetMaterial(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Material/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Material> PatchMaterial(string id, Delta<Material> patch)
        {
            return UpdateAsync(id, patch);
        }

        // POST tables/Material
        public async Task<IHttpActionResult> PostMaterial(Material item)
        {
            Material current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Material/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteMaterial(string id)
        {
             return DeleteAsync(id);
        }
    }
}

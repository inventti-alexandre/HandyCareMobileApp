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
    public class CameraController : TableController<Camera>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            handycareappContext context = new handycareappContext();
            DomainManager = new EntityDomainManager<Camera>(context, Request);
        }

        // GET tables/Camera
        public IQueryable<Camera> GetAllCamera()
        {
            return Query(); 
        }

        // GET tables/Camera/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Camera> GetCamera(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Camera/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Camera> PatchCamera(string id, Delta<Camera> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/Camera
        public async Task<IHttpActionResult> PostCamera(Camera item)
        {
            Camera current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Camera/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteCamera(string id)
        {
             return DeleteAsync(id);
        }
    }
}

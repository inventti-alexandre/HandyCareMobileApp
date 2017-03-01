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
    public class VideoFamiliarController : TableController<VideoFamiliar>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            handycareappContext context = new handycareappContext();
            DomainManager = new EntityDomainManager<VideoFamiliar>(context, Request);
        }

        // GET tables/VideoFamiliar
        public IQueryable<VideoFamiliar> GetAllVideoFamiliar()
        {
            return Query(); 
        }

        // GET tables/VideoFamiliar/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<VideoFamiliar> GetVideoFamiliar(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/VideoFamiliar/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<VideoFamiliar> PatchVideoFamiliar(string id, Delta<VideoFamiliar> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/VideoFamiliar
        public async Task<IHttpActionResult> PostVideoFamiliar(VideoFamiliar item)
        {
            VideoFamiliar current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/VideoFamiliar/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteVideoFamiliar(string id)
        {
             return DeleteAsync(id);
        }
    }
}

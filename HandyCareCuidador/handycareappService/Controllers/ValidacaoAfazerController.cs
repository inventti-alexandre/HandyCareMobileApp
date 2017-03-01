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
    public class ValidacaoAfazerController : TableController<ValidacaoAfazer>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            handycareappContext context = new handycareappContext();
            DomainManager = new EntityDomainManager<ValidacaoAfazer>(context, Request);
        }

        // GET tables/ValidacaoAfazer
        public IQueryable<ValidacaoAfazer> GetAllValidacaoAfazer()
        {
            return Query(); 
        }

        // GET tables/ValidacaoAfazer/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<ValidacaoAfazer> GetValidacaoAfazer(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/ValidacaoAfazer/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<ValidacaoAfazer> PatchValidacaoAfazer(string id, Delta<ValidacaoAfazer> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/ValidacaoAfazer
        public async Task<IHttpActionResult> PostValidacaoAfazer(ValidacaoAfazer item)
        {
            ValidacaoAfazer current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/ValidacaoAfazer/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteValidacaoAfazer(string id)
        {
             return DeleteAsync(id);
        }
    }
}

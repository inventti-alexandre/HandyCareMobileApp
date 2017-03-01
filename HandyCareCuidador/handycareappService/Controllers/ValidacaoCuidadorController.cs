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
    public class ValidacaoCuidadorController : TableController<ValidacaoCuidador>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            handycareappContext context = new handycareappContext();
            DomainManager = new EntityDomainManager<ValidacaoCuidador>(context, Request);
        }

        // GET tables/ValidacaoCuidador
        public IQueryable<ValidacaoCuidador> GetAllValidacaoCuidador()
        {
            return Query();
        }

        // GET tables/ValidacaoCuidador/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<ValidacaoCuidador> GetValidacaoCuidador(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/ValidacaoCuidador/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<ValidacaoCuidador> PatchValidacaoCuidador(string id, Delta<ValidacaoCuidador> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/ValidacaoCuidador
        public async Task<IHttpActionResult> PostValidacaoCuidador(ValidacaoCuidador item)
        {
            ValidacaoCuidador current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/ValidacaoCuidador/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteValidacaoCuidador(string id)
        {
             return DeleteAsync(id);
        }
    }
}

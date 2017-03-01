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
    public class MotivoNaoValidacaoConclusaoAfazerController : TableController<MotivoNaoValidacaoConclusaoAfazer>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            handycareappContext context = new handycareappContext();
            DomainManager = new EntityDomainManager<MotivoNaoValidacaoConclusaoAfazer>(context, Request);
        }

        // GET tables/MotivoNaoValidacaoConclusaoAfazer
        public IQueryable<MotivoNaoValidacaoConclusaoAfazer> GetAllMotivoNaoValidacaoConclusaoAfazer()
        {
            return Query(); 
        }

        // GET tables/MotivoNaoValidacaoConclusaoAfazer/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<MotivoNaoValidacaoConclusaoAfazer> GetMotivoNaoValidacaoConclusaoAfazer(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/MotivoNaoValidacaoConclusaoAfazer/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<MotivoNaoValidacaoConclusaoAfazer> PatchMotivoNaoValidacaoConclusaoAfazer(string id, Delta<MotivoNaoValidacaoConclusaoAfazer> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/MotivoNaoValidacaoConclusaoAfazer
        public async Task<IHttpActionResult> PostMotivoNaoValidacaoConclusaoAfazer(MotivoNaoValidacaoConclusaoAfazer item)
        {
            MotivoNaoValidacaoConclusaoAfazer current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/MotivoNaoValidacaoConclusaoAfazer/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteMotivoNaoValidacaoConclusaoAfazer(string id)
        {
             return DeleteAsync(id);
        }
    }
}

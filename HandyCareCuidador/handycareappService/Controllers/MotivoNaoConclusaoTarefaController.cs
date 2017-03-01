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
    public class MotivoNaoConclusaoTarefaController : TableController<MotivoNaoConclusaoTarefa>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            handycareappContext context = new handycareappContext();
            DomainManager = new EntityDomainManager<MotivoNaoConclusaoTarefa>(context, Request);
        }

        // GET tables/MotivoNaoConclusaoTarefa
        public IQueryable<MotivoNaoConclusaoTarefa> GetAllMotivoNaoConclusaoTarefa()
        {
            return Query(); 
        }

        // GET tables/MotivoNaoConclusaoTarefa/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<MotivoNaoConclusaoTarefa> GetMotivoNaoConclusaoTarefa(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/MotivoNaoConclusaoTarefa/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<MotivoNaoConclusaoTarefa> PatchMotivoNaoConclusaoTarefa(string id, Delta<MotivoNaoConclusaoTarefa> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/MotivoNaoConclusaoTarefa
        public async Task<IHttpActionResult> PostMotivoNaoConclusaoTarefa(MotivoNaoConclusaoTarefa item)
        {
            MotivoNaoConclusaoTarefa current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/MotivoNaoConclusaoTarefa/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteMotivoNaoConclusaoTarefa(string id)
        {
             return DeleteAsync(id);
        }
    }
}

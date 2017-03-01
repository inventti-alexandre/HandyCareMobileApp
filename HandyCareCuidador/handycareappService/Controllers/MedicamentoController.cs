using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.Azure.Mobile.Server;
using handycareappService.DataObjects;
using handycareappService.Models;
using System.Diagnostics;
using System.Reflection;

namespace handycareappService.Controllers
{
    public class MedicamentoController : TableController<Medicamento>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            handycareappContext context = new handycareappContext();
            DomainManager = new EntityDomainManager<Medicamento>(context, Request);
        }

        // GET tables/Medicamento
        public IQueryable<Medicamento> GetAllMedicamento()
        {
            return Query(); 
        }

        // GET tables/Medicamento/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Medicamento> GetMedicamento(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Medicamento/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Medicamento> PatchMedicamento(string id, Delta<Medicamento> patch)
        {
            try
            {
                return UpdateAsync(id, patch);
            }
            catch (ReflectionTypeLoadException e)
            {
                Debug.WriteLine(e.Message);
            }
            return null;
        }

        // POST tables/Medicamento
        public async Task<IHttpActionResult> PostMedicamento(Medicamento item)
        {
            Medicamento current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Medicamento/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteMedicamento(string id)
        {
            try
            {
                return DeleteAsync(id);
            }
            catch (ReflectionTypeLoadException e)
            {
                Debug.WriteLine(e.Message);
            }
            return null;
        }
    }
}

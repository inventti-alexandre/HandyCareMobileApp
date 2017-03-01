using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.Azure.Mobile.Server;
using handycareappService.DataObjects;
using handycareappService.Models;
using Microsoft.Azure.Mobile.Server.Config;
using Microsoft.Azure.NotificationHubs;

namespace handycareappService.Controllers
{
    public class AfazerController : TableController<Afazer>
    {
        public handycareappContext context;
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            context = new handycareappContext();
            DomainManager = new EntityDomainManager<Afazer>(context, Request);
        }

        // GET tables/Afazer
        public IQueryable<Afazer> GetAllAfazer()
        {
            return Query(); 
        }

        // GET tables/Afazer/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Afazer> GetAfazer(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Afazer/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Afazer> PatchAfazer(string id, Delta<Afazer> patch)
        {
            return UpdateAsync(id, patch);
        }

        // POST tables/Afazer
        public async Task<IHttpActionResult> PostAfazer(Afazer item)
        {
            Afazer current = await InsertAsync(item);
            //var a = context.P
            // Get the settings for the server project.
            var config = this.Configuration;
            var settings =
                this.Configuration.GetMobileAppSettingsProvider().GetMobileAppSettings();

            // Get the Notification Hubs credentials for the Mobile App.
            var notificationHubName = settings.NotificationHubName;
            var notificationHubConnection = settings
                .Connections[MobileAppSettingsKeys.NotificationHubConnectionString].ConnectionString;

            // Create a new Notification Hub client.
            var hub = NotificationHubClient
            .CreateClientFromConnectionString(notificationHubConnection, notificationHubName);

            // Sending the message so that all template registrations that contain "messageParam"
            // will receive the notifications. This includes APNS, GCM, WNS, and MPNS template registrations.
            var templateParams = new Dictionary<string, string>
            {
                ["messageParam"] = "Novo afazer "+item.AfaObservacao+" registrado para às " + item.AfaHorarioPrevisto
            };

            try
            {
                // Send the push notification and log the results.
                var result = await hub.SendTemplateNotificationAsync(templateParams);

                // Write the success result to the logs.
                config.Services.GetTraceWriter().Info(result.State.ToString());
            }
            catch (System.Exception ex)
            {
                // Write the failure result to the logs.
                config.Services.GetTraceWriter()
                    .Error(ex.Message, null, "Push.SendAsync Error");
            }

            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Afazer/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteAfazer(string id)
        {
             return DeleteAsync(id);
        }
    }
}

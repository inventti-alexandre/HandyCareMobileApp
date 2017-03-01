using System;
using System.Collections.Generic;
using System.Globalization;
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
    public class ConclusaoAfazerController : TableController<ConclusaoAfazer>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            handycareappContext context = new handycareappContext();
            DomainManager = new EntityDomainManager<ConclusaoAfazer>(context, Request);
        }

        // GET tables/ConclusaoAfazer
        public IQueryable<ConclusaoAfazer> GetAllConclusaoAfazer()
        {
            return Query(); 
        }

        // GET tables/ConclusaoAfazer/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<ConclusaoAfazer> GetConclusaoAfazer(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/ConclusaoAfazer/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<ConclusaoAfazer> PatchConclusaoAfazer(string id, Delta<ConclusaoAfazer> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/ConclusaoAfazer
        public async Task<IHttpActionResult> PostConclusaoAfazer(ConclusaoAfazer item)
        {
            ConclusaoAfazer current = await InsertAsync(item);
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
                ["messageParam"] = "Novo afazer realizado às" +DateTime.Now.ToString(CultureInfo.CurrentCulture)+ ". Verifique a realização."
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

        // DELETE tables/ConclusaoAfazer/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteConclusaoAfazer(string id)
        {
             return DeleteAsync(id);
        }
    }
}

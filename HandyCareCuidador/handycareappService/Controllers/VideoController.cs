﻿using System.Collections.Generic;
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
    public class VideoController : TableController<Video>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            handycareappContext context = new handycareappContext();
            DomainManager = new EntityDomainManager<Video>(context, Request);
        }

        // GET tables/Video
        public IQueryable<Video> GetAllVideo()
        {
            return Query(); 
        }

        // GET tables/Video/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Video> GetVideo(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Video/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Video> PatchVideo(string id, Delta<Video> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/Video
        public async Task<IHttpActionResult> PostVideo(Video item)
        {
            Video current = await InsertAsync(item);
            // Get the settings for the server project.
            HttpConfiguration config = this.Configuration;
            MobileAppSettingsDictionary settings =
                this.Configuration.GetMobileAppSettingsProvider().GetMobileAppSettings();

            // Get the Notification Hubs credentials for the Mobile App.
            string notificationHubName = settings.NotificationHubName;
            string notificationHubConnection = settings
                .Connections[MobileAppSettingsKeys.NotificationHubConnectionString].ConnectionString;

            // Create a new Notification Hub client.
            NotificationHubClient hub = NotificationHubClient
            .CreateClientFromConnectionString(notificationHubConnection, notificationHubName);

            // Sending the message so that all template registrations that contain "messageParam"
            // will receive the notifications. This includes APNS, GCM, WNS, and MPNS template registrations.
            Dictionary<string, string> templateParams = new Dictionary<string, string>
            {
                ["messageParam"] = "Um novo vídeo sobre " + item.VidDescricao + " foi enviado"
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

        // DELETE tables/Video/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteVideo(string id)
        {
             return DeleteAsync(id);
        }
    }
}

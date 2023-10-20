using Clean.Site.NotificationHandlers;
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.Notifications;

namespace Clean.Site.Composing
{
    internal class StartupComposer : IComposer
    {
        public void Compose(IUmbracoBuilder builder)
        {
            builder
                .AddNotificationHandler<ServerVariablesParsingNotification,
                    ServerVariablesParsingNotificationHandler>();
        }
    }
}

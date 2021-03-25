using Microsoft.Extensions.DependencyInjection;

namespace BlazorNotifications
{
    public static class NotificationExtensions
    {
        public static IServiceCollection AddBlazorNotification(this IServiceCollection services)
        {
            return services.AddScoped<IBlazorNotificationService, BlazorNotificationService>();
        }
    }
}

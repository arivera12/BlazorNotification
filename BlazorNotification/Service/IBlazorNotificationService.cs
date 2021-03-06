using System.Threading.Tasks;

namespace BlazorNotification
{
    public interface IBlazorNotificationService
    {
        /// <summary>
        /// Checks if the Notifications' API is Support by the browser.
        /// </summary>
        /// <returns></returns>
        ValueTask<bool> IsSupportedByBrowserAsync();
        /// <summary>
        /// Request the user for his permission to send notifications.
        /// </summary>
        /// <returns></returns>
        ValueTask<NotificationPermissionType> RequestPermissionAsync();
        /// <summary>
        /// Send a Notification with <seealso cref="NotificationOptions"/>
        /// </summary>
        /// <param name="title"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        ValueTask SendAsync(string title, NotificationOptions options);
        /// <summary>
        /// Send a Notification with <paramref name="title"/>, <paramref name="body"/> and <paramref name="iconUrl"/>
        /// </summary>
        /// <param name="title"></param>
        /// <param name="body"></param>
        /// <param name="iconUrl"></param>
        /// <returns></returns>
        ValueTask SendAsync(string title, string body, string iconUrl);
    }
}
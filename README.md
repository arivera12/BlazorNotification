# BlazorNotification
<p>
	<a href="https://www.nuget.org/packages/BlazorNotification">
	    <img src="https://buildstats.info/nuget/BlazorNotification?v=1.0.1" />
	</a>
</p>

Blazor browser notifications from c# without any JavaScript library or dependency.

## Installation

```csharp
Install-Package BlazorNotification -Version 1.0.1
```

## Register the service in your services method

```csharp
services.AddBlazorNotification();
```

## No javascript library reference dependency

## Usage

```csharp
[Inject] IBlazorNotificationService BlazorNotificationService { get; set; }
```

### Send a notification
#### Using a Function (basic)
```csharp
await NotificationService.SendAsync("Title", "Description", "images/github.png");
```

#### Using NotificationOptions (advanced)
```csharp
NotificationOptions options = new NotificationOptions
{
    Body = body,
    Icon = icon,
};

await NotificationService.SendAsync(title, options);
```
 ### Browser Support
```csharp
bool IsSupportedByBrowser = await NotificationService.IsSupportedByBrowserAsync()
```
### Request Permission
```csharp
PermissionType permission = await NotificationService.RequestPermissionAsync();
```

## License
MIT

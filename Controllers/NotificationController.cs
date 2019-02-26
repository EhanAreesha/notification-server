using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

[Route("api/[controller]")]
[ApiController]
public class NotificationController : ControllerBase
{
    private IHubContext<NotificationHub> _hub;
 
    public NotificationController(IHubContext<NotificationHub> hub)
    {
        _hub = hub;
    }
 
    public IActionResult Get()
    {
        var timerManager = new TimerManager(() => _hub.Clients.All.SendAsync("transferNotificationData", DataManager.GetData()));
 
        return Ok(new { Message = "Request Completed" });
     }
}
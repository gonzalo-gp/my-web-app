using Microsoft.AspNetCore.Mvc;
using MyWebApp.Services;

namespace MyWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly NotificationService _notificationService;

        public HomeController(NotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public IActionResult Index()
        {
            return View("~/Views/Home/Index.cshtml"); ;
        }

        [HttpPost]
        public IActionResult Notify()
        {
            var message = _notificationService.GetNotificationMessage();
            return Content(message);
        }

    }
}
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
using ServiceStation.Models;

namespace ServiceStation.Controllers
{
    public class ServicesController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}

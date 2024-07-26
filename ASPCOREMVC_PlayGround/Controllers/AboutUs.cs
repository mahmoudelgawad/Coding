using Microsoft.AspNetCore.Mvc;

namespace ASPCOREMVC_PlayGround.Controllers
{
    public class AboutUs : Controller
    {
        public IActionResult Index()
        {
            //var val = TempData.Peek("td");
            //ViewData["val"] = val;
            return View();
        }


    }
}

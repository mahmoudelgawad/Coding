using ASPCOREMVC_PlayGround.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPCOREMVC_PlayGround.Controllers
{
    public class AboutUs : Controller
    {
        public IActionResult Index()
        {
            var errorModel = new ErrorViewModel
            {
                RequestId = "mahmoud"
            };

            //var val = TempData.Peek("td");
            //ViewData["val"] = val;
            return View(errorModel);
        }


    }
}

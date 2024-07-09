using Microsoft.AspNetCore.Mvc;

namespace ASPCOREMVC_PlayGround.Controllers
{
    public class AboutUs : Controller
    {
        public IActionResult Index()
        {
           // TempData["td"] = "cocowawa";
            //TempData.Keep();
            return View();
        }


    }
}

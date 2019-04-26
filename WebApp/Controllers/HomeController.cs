using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //inMemory mem = new inMemory();
            //mem.ID = 0; mem.NAME = "teste";
            ViewData["TESTE"] = "--VIEW_DATA--";
            return View();
        }
    }
}
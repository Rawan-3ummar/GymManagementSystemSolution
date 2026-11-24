using Microsoft.AspNetCore.Mvc;

namespace GymManagementSystem.Controllers
{
    public class TestController1 : Controller
    {
        public IActionResult Index()
        {
          int Data = 10;
            return View(Data);
        }
        public IActionResult Hamada(int id)
        {
            return View(id);
        }
    }
}

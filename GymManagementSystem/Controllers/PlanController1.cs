using GymManagementSystem.Context;
using Microsoft.AspNetCore.Mvc;

namespace GymManagementSystem.Controllers
{
    public class PlanController1 : Controller
    {
        private GymDbContext dbContext = new GymDbContext();

        public async Task<IActionResult> Index()
        {
            var Plans = await dbContext.Plans.ToListAsync();
            return View(Plans);
        }
    }
}

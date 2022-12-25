using Microsoft.AspNetCore.Mvc;

namespace VacationReservationProject.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

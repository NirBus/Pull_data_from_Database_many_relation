using Microsoft.AspNetCore.Mvc;

namespace Pull_data_from_Database_many_relation.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    }
}

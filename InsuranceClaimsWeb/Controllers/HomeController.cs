using AspNetCoreSample.Model;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreSample.Controllers
{
    public class HomeController : Controller
    {
        private readonly AspNetSampleDbContext dbContext;

        public HomeController(AspNetSampleDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        public IActionResult Index()
        {
            return View(this.dbContext.Claims.ToList());
        }


        public IActionResult Privacy()
        {
            return View();
        }
    }
}

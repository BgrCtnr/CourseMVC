using Microsoft.AspNetCore.Mvc;
using btkbgr.Models;

namespace btkbgr.Controllers
{
    
    public class CourseController : Controller
    {


        public IActionResult Index()
        {
            var model = Repository.Applications;
            return View(model);

        }

        public IActionResult Goruntule()
        {
            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Goruntule([FromForm]Student model)
        {
            Repository.Add(model);
            return View("Feedback",model);

        }



    }


}
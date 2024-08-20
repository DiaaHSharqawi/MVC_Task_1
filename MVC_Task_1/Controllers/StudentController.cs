using Microsoft.AspNetCore.Mvc;

namespace MVC_Task_1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index() // get all
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Update()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }
      
    }
}

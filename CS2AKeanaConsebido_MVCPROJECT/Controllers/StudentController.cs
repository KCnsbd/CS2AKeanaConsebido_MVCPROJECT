using CS2AKeanaConsebido_MVCPROJECT.BusLogic.Model;
using CS2AKeanaConsebido_MVCPROJECT.BusLogic.Service;
using Microsoft.AspNetCore.Mvc;

namespace CS2AKeanaConsebido_MVCPROJECT.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentService _studentService = new StudentService();
     
        public IActionResult Index()
        {
            var students = _studentService.GetAll();
            return View(students);
        }

        public IActionResult AddNewStudent()
        {
            return View();
        }

        [HttpPost]

        public IActionResult AddStudent(tblStudent student)
        {
            try
            {
                bool result = _studentService.Add(student);
                return Json(new { success = result, message = result });
            }
            catch (Exception ex)
            {
                return Json(new { error = ex, message = ex });
            }

        }

        [HttpGet]

        public IActionResult EditStudent(tblStudent student) {
                return View();
        }
    }
}

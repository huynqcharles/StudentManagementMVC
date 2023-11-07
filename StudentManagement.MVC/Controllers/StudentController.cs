using Microsoft.AspNetCore.Mvc;
using StudentManagement.MVC.Services;

namespace StudentManagement.MVC.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public IActionResult Index()
        {
            var students = _studentService.GetAllStudents();
            return View(students);
        }
    }
}

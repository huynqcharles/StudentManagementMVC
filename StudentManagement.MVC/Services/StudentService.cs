using StudentManagement.MVC.Models;
using StudentManagement.MVC.Repositories;

namespace StudentManagement.MVC.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepo _studentRepo;

        public StudentService(IStudentRepo studentRepo)
        {
            _studentRepo = studentRepo;
        }
        public IEnumerable<Student> GetAllStudents()
        {
            return _studentRepo.GetAllStudents();
        }
    }
}

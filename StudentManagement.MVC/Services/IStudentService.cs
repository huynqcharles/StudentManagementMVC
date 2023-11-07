using StudentManagement.MVC.Models;

namespace StudentManagement.MVC.Services
{
    public interface IStudentService
    {
        IEnumerable<Student> GetAllStudents();
    }
}

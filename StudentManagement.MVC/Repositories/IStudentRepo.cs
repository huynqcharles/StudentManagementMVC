using StudentManagement.MVC.Models;

namespace StudentManagement.MVC.Repositories
{
    public interface IStudentRepo
    {
        IEnumerable<Student> GetAllStudents();
    }
}

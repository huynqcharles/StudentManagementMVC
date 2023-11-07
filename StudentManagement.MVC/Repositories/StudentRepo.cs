using StudentManagement.MVC.Context;
using StudentManagement.MVC.Models;

namespace StudentManagement.MVC.Repositories
{
    public class StudentRepo : IStudentRepo
    {
        private readonly ApplicationDbContext _dbContext;

        public StudentRepo(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Student> GetAllStudents()
        {
            return _dbContext.Students.ToList();
        }
    }
}

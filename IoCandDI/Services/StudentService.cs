using IoCandDI.Repositories;
using IoCandDI.Models;
namespace IoCandDI.Services
{
    public class StudentService
    {
        private readonly IStudentRepo _studentRepo;
        public StudentService(IStudentRepo studentRepo)
        {
            _studentRepo = studentRepo;
        }

        public void CreateStudent()
        {
            _studentRepo.AddStudent(new Student { Id = 1, Name = "John Doe", Description = "A sample student" });
        }

        public void UpdateStudent()
        {
            // Implementation for updating a student
        }

    }
}
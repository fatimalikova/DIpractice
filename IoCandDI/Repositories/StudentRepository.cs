using IoCandDI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace IoCandDI.Repositories
{
    public class StudentRepository : IStudentRepo
    {
        public void AddStudent(Student student)
        {
            Console.WriteLine(student.Id + " Id-li " + "telebe elave edildi!");
        }

        public void DeleteStudent(int id)
        {
            if(id <= 0)
            {
                throw new ArgumentException("Id must be greater than zero.");
            }

            Console.WriteLine(id + " Id-li telebe silindi!");
        }

        public Student GetStudent(int id)
        {
            throw new NotImplementedException();
        }

        public Student GetStudent(int id, string name)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetStudents()
        {
            throw new NotImplementedException();
        }

        public void UpdateStudent(Student student)
        {
            throw new NotImplementedException();
        }
    }
}

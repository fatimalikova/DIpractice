using IoCandDI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace IoCandDI.Repositories
{
    public interface IStudentRepo
    {
        void AddStudent(Student student);
        List<Student> GetStudents();
        Student GetStudent(int id);
        Student GetStudent(int id, string name);
        void UpdateStudent(Student student);
        void DeleteStudent(int id);

    }
}

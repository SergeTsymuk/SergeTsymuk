using System;
using System.Linq;

namespace EntityFrameWorkNew
{
    static class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var stud = new Student()
                {
                    StudentName = "Mark",
                    Grade = new Grade() { GradeName = "Second", Section = "Low" }
                };

                ctx.Students.Add(stud);
                ctx.SaveChanges();

                var students = ctx.Students.Include("Grade").ToList();

                foreach (var student in students)
                {
                    Console.WriteLine($"Student name: {student.StudentName}, Grade = {student.Grade.GradeName}, Grade section = {student.Grade.Section}");
                }
            }

        }
    }
}

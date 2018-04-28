using System;
using System.Linq;
using FluentApi.SampleApp.Fluent;
using FluentApi.SampleApp.Models;


namespace FluentApi.SampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task: enroll registered students in an orientation class
            EnrollStudents();
        }

        static void EnrollStudents()
        {
            var studentRepository = RepositoryFactory.CreateStudentRepository();
            var courseRepository = RepositoryFactory.CreateCourseRepository();

            var course = courseRepository.GetCourseById("Orientation");
            var students = studentRepository.GetStudents();
            foreach (var student in students)
            {
                if (!student.IsRegistered)
                {
                    var enrollment = new Enrollment
                    {
                        Student = student,
                        Course = course
                    };
                    courseRepository.Save(enrollment);
                }
            }
        }

        static void EnrollStudentsViaFluentApi()
        {
            new FluentEnroll()
                        .Enroll()
                            .WithStudents(students => students.Where(s => !s.IsRegistered))
                            .WithCourse(courses => courses.First(c => c.Id == "Orientation"))
                        .Apply();
        }

    }
}

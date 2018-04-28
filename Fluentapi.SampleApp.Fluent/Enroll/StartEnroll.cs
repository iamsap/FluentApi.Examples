using System;
using System.Collections.Generic;
using FluentApi.SampleApp.Fluent.Framework;
using FluentApi.SampleApp.Fluent.Lib.Enroll;
using FluentApi.SampleApp;
using FluentApi.SampleApp.Models;

namespace FluentApi.SampleApp.Fluent.Enroll
{
    public class StartEnroll : IWithStudents, IWithCourse, IApplyable
    {
        public Course SelectedCourse { get; private set; }
        public IEnumerable<Student> SelectedStudents { get; private set; }

        public void Apply()
        {
            var courseRepository = RepositoryFactory.CreateCourseRepository();
            foreach(var student in SelectedStudents){
                var enrollment = new Enrollment
                {
                    Student = student,
                    Course = SelectedCourse
                };
                courseRepository.Save(enrollment);
            }
        }

        public IApplyable WithCourse(Func<IEnumerable<Course>, Course> func)
        {
            var courseRepository = RepositoryFactory.CreateCourseRepository();
            SelectedCourse = func.Invoke(courseRepository.GetCourses());
            return this as IApplyable;
        }

        public IWithCourse WithStudents(Func<IEnumerable<Student>, IEnumerable<Student>> func)
        {
            var studentRepository = RepositoryFactory.CreateStudentRepository();
            SelectedStudents = func.Invoke(studentRepository.GetStudents());
            return this as IWithCourse;
        }
    }
}

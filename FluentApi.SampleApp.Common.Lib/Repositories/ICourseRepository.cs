using System;
using System.Collections.Generic;
using FluentApi.SampleApp.Models;

namespace FluentApi.SampleApp.Repositories
{
    public interface ICourseRepository
    {
        Course GetCourseById(string courseId);
        IEnumerable<Course> GetCourses();
        void Save(Enrollment enrollment);
    }
}

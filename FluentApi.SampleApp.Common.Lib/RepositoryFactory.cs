using System;
using FluentApi.SampleApp.Repositories;

namespace FluentApi.SampleApp
{
    public class RepositoryFactory
    {
        // Should return a concrete implementation
        public static IStudentRepository CreateStudentRepository() => null;
        public static ICourseRepository CreateCourseRepository() => null;
    }
}

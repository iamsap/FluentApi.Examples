using System;
using FluentApi.SampleApp.Fluent.Enroll;

namespace FluentApi.SampleApp.Fluent
{
    public class FluentEnroll
    {
        // Paths
        public IWithStudents Enroll() => new StartEnroll();
    }
}

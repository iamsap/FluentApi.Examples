using System;
using System.Collections.Generic;
using FluentApi.SampleApp.Fluent.Framework;
using FluentApi.SampleApp.Fluent.Lib.Enroll;
using FluentApi.SampleApp.Models;

namespace FluentApi.SampleApp.Fluent.Enroll
{
    public interface IWithStudents : IApplyable
    {
        IWithCourse WithStudents(Func<IEnumerable<Student>, IEnumerable<Student>> students);
    }
}

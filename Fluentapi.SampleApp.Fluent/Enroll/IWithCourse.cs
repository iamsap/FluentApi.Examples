using System;
using System.Collections.Generic;
using FluentApi.SampleApp.Fluent.Framework;
using FluentApi.SampleApp.Models;

namespace FluentApi.SampleApp.Fluent.Lib.Enroll
{
    public interface IWithCourse
    {
        IApplyable WithCourse(Func<IEnumerable<Course>,Course> func);
    }
}

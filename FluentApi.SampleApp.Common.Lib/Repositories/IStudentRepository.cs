using System;
using System.Collections.Generic;
using FluentApi.SampleApp.Models;

namespace FluentApi.SampleApp.Repositories
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetStudents();
    }
}

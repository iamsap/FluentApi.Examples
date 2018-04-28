using System;
namespace FluentApi.Chaining.LinkedIn
{
    public class Select : ISelect
    {
        public ICourses Courses { get; } = new Courses();
    }
}

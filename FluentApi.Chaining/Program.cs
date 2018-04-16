using System;
using FluentApi.Chaining.LinkedIn;

namespace FluentApi.Chaining
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedInLearning
              .Select()
              .Courses
                .WithTopic(t => Topics.Fluent)
            .Start();

        }
    }
}

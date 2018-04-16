using System;
using FluentApi.Chaining.LinkedIn;

namespace FluentApi.Conjuctions
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedInLearning
              .Select()
              .Courses
                .WithTopic(t => Topics.Fluent)
                .And
                .WithTopic(t => Topics.Art)
            .Start();
        }
    }
}

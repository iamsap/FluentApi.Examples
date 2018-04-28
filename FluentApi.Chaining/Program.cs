using System;
using FluentApi.Chaining.LinkedIn;

namespace FluentApi.Chaining
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedInLearning
              .Select()                     // ISelect
              .Courses                      // ICourses
                .WithTopic(Topic.Fluent)    // IPlayer
            .Start();   

        }
    }
}

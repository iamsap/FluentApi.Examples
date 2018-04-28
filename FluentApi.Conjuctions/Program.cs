using System;
using FluentApi.Conjuctions.LinkedIn;

namespace FluentApi.Conjuctions
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedInLearning
                .Courses
                    .Select()
                        .WithTopic(Topic.Art)
                    .And
                    .Select()
                        .WithTopic(Topic.Math)
                        .WithoutTests()
                    .Not
                    .Select()
                        .WithHomework()
                    .Attach()
                .Enroll();
        }
    }
}

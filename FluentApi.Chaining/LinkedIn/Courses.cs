using System;
namespace FluentApi.Chaining.LinkedIn
{
    
    public class Courses : ICourses
    {
        public Topic Topic { get; set; }

        public IPlayer WithTopic(Topic topic)
        {
            Topic = topic;
            return new Player(this);
        }
    }
}

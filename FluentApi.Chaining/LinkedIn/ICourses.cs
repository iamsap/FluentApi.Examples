using System;
namespace FluentApi.Chaining.LinkedIn
{
    public interface ICourses
    {
        IPlayer WithTopic(Topic topic);
    }
}

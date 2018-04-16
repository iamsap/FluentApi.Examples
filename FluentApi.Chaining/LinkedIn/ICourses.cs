using System;
namespace FluentApi.Chaining.LinkedIn
{
    public interface ICourses
    {
        IPlayable WithTopic(Func<Topics, Topics> topics);
    }
}

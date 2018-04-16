using System;
namespace FluentApi.Chaining.LinkedIn
{
    public interface IPlayable
    {
        ICourses And { get; }
        void Start();
    }
}

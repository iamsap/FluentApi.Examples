using System;

namespace FluentApi.Conjuctions.LinkedIn
{
    public interface ISelect
    {
        // Context
        ISelect WithTopic(Topic topic);
        ISelect WithoutTests();
        ISelect WithHomework();

        // Exit
        ICourses Attach();

        // Exit Conjunctions
        ICourses And { get; }
        ICourses Not { get; }
    }
}

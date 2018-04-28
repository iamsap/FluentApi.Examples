using System;

namespace FluentApi.Conjuctions.LinkedIn
{
    public interface ICourses
    {
        // Start
        ISelect Select();

        // Exit
        void Enroll();
    }

    public class Courses : ICourses
    {
        public ICourses And => throw new NotImplementedException();

        public ICourses Not => throw new NotImplementedException();

        public void Enroll()
        {
            throw new NotImplementedException();
        }

        public ISelect Select()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using FluentApi.Generics.Framework;

namespace FluentApi.Generics.Students
{
    public interface ISelectStudents : IAttachable<IStudentCollection>
    {
        ISelectStudents WithoutRegistration();
        ISelectStudents WithTuitionDue();
    }
}

using System;
using FluentApi.Generics.Framework;
using FluentApi.Generics.Models;

namespace FluentApi.Generics.Students
{
    public interface IStudents : IApplyable, ISupportsSelect<ISelectStudents>
    {

    }
}

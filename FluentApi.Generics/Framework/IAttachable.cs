using System;
namespace FluentApi.Generics.Framework
{
    public interface IAttachable<T>
    {
        T Attach();
    }
}

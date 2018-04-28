using System;
namespace FluentApi.Generics.Framework
{
    public interface ISupportsSelect<T> 
    {
        T Select();
        T Select<P>(Func<P, bool> func);
    }
}

using System;
using FluentApi.LinkingChains.Pipeline.Source.QueryDb;

namespace FluentApi.LinkingChains.Pipeline.Source
{
    public interface ISource
    {
        IQueryDb QueryDb(string sql);
    }
}

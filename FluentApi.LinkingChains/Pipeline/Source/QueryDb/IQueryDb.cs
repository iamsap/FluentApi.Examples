using System;
namespace FluentApi.LinkingChains.Pipeline.Source.QueryDb
{
    public interface IQueryDb
    {
        IQueryDb WithMaxRows(int maxRows);
        IPipeline Attach();
    }
}

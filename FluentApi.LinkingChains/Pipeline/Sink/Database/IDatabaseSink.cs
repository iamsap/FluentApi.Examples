using System;
namespace FluentApi.LinkingChains.Pipeline.Sink.Database
{
    public interface IDatabaseSink
    {
        IDatabaseSink WithConnectionString(string connectionString);
        IPipeline Attach();
    }
}

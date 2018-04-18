using System;
using System.Threading.Tasks;
using FluentApi.LinkingChains.Pipeline.Sink;
using FluentApi.LinkingChains.Pipeline.Source;

namespace FluentApi.LinkingChains.Pipeline
{
    public interface IPipeline
    {
        ISource AddSource();
        ISink AddSink();

        Task RunAsync();
    }
}

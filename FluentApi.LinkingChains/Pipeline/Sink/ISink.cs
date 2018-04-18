using System;
using FluentApi.LinkingChains.Pipeline.Sink.Database;
using FluentApi.LinkingChains.Pipeline.Sink.FileWriter;

namespace FluentApi.LinkingChains.Pipeline.Sink
{
    public interface ISink
    {
        IFileWriterSink FileWriter();
        IDatabaseSink Database();
    }
}

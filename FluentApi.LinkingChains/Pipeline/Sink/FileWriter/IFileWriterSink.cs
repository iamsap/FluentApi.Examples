using System;
namespace FluentApi.LinkingChains.Pipeline.Sink.FileWriter
{
    public interface IFileWriterSink
    {
        IFileWriterSink WithCsv();
        IFileWriterSink WithPathToFile(string pathToFile);
        IPipeline Attach();
    }
}

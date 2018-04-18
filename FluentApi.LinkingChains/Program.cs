using System;

namespace FluentApi.LinkingChains
{
    class Program
    {
        static void Main(string[] args)
        {
            var etl = new Etl()
                .Pipeline()
                    .AddSource()
                        .QueryDb("select * from orders")
                            .WithMaxRows(100)
                        .Attach()
                    .AddSink()
                        .FileWriter()
                            .WithCsv()
                            .WithPathToFile("/path/to/file.csv")
                    .Attach()
                    .AddSink()
                        .Database()
                            .WithConnectionString("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;")
                        .Attach()
                .RunAsync();
                    
        }
    }
}

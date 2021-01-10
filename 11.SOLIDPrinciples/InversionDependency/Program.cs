using Microsoft.Extensions.DependencyInjection;
using System;

namespace InversionDependency
{
    class Program
    {
        static void Main(string[] args)
        {
            IServiceProvider service = new ServiceCollection()
                .AddScoped<IReader, Reader>()
                //.AddScoped<IWriter, SuperWriter>()
                .AddScoped<IWriter, Writer>()
                .AddScoped<Copy, Copy>()
                .BuildServiceProvider();


            Copy cp = service.GetService<Copy>();

            cp.CopyAllChars();
        }
    }
}

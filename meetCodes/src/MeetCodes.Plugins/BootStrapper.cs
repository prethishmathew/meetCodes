using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyModel;

namespace MeetCodes.Plugins
{
    public static class BootStrapper
    {

        public static void InjectDependencies(this IServiceCollection services)
        {
            foreach (var compilationLibrary in DependencyContext.Default.RuntimeLibraries)
            {

               if (compilationLibrary.Name.Contains("meetCode"))
               { 
                   var assembly = Assembly.Load(new AssemblyName(compilationLibrary.Name));
                   var q = assembly.GetTypes().Where(x => x.GetInterfaces().Length > 0 && x.GetTypeInfo().IsClass);

                    foreach (var service in q )
                    {
                        services.AddTransient(Type.GetType(service.FullName), Type.GetType(service.GetInterfaces().FirstOrDefault().FullName));
                    }
                }
               
            }

        }
    }
}

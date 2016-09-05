using System;
using System.Collections;
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
            var meetCodeAssemblies = DependencyContext.Default.RuntimeLibraries.Where(x => x.Name.ToUpper().Contains("MEETCODE"));
            foreach (var compilationLibrary in meetCodeAssemblies)
            {

               if (compilationLibrary.Name.ToUpper().Contains("MEETCODE"))
               { 
                   var assembly = Assembly.Load(new AssemblyName(compilationLibrary.Name));
                   var q = assembly.GetTypes().Where(x => x.GetInterfaces().Length > 0 && x.GetTypeInfo().IsClass && !x.GetTypeInfo().IsAbstract);

                    foreach (var service in q )
                    {
                        foreach (var interfaces in service.GetInterfaces().Where(x => x.FullName.ToUpper().Contains("MEETCODE") ))
                        {
                           
                           services.AddTransient(interfaces, service);
                           
                        }
                        
                    }
                }
               
            }

        }
    }
}

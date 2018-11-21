using Microsoft.Extensions.Configuration;
using MyExampleWebAPI.Interfaces;
using MyExampleWebAPI.Services;
using StructureMap;
using StructureMap.Pipeline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyExampleWebAPI
{
    public class StructureMapRegistry : Registry
    {
        public StructureMapRegistry()
        {
            For<IPersonService>().LifecycleIs(Lifecycles.Container)
                                    .Use<PersonService>();
        }
    }
}

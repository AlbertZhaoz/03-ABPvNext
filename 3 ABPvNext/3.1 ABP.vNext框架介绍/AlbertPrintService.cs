using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.DependencyInjection;

namespace _3._1_ABP.vNext框架介绍
{
    internal class AlbertPrintService:IScopedDependency
    {
        public string ReadFile()
        {
            return File.ReadAllText($"{AppDomain.CurrentDomain.BaseDirectory}3.1 ABP.vNext框架介绍.deps.json");
        }
    }
}

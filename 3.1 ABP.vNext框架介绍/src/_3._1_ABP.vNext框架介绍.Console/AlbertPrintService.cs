using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace _3._1_ABP.vNext框架介绍.Console
{
    public class AlbertPrintService:ITransientDependency
    {
        public async Task<string> ReadFile()
        {
            var content = await File.ReadAllTextAsync(@"E:\Code_Repo\03-ABPvNext\README.md");
            return content;
        }
    }
}

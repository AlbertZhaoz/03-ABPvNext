using System;
using System.Collections.Generic;
using System.Text;
using _3._1_ABP.vNext框架介绍.Localization;
using Volo.Abp.Application.Services;

namespace _3._1_ABP.vNext框架介绍;

/* Inherit your application services from this class.
 */
public abstract class vNext框架介绍AppService : ApplicationService
{
    protected vNext框架介绍AppService()
    {
        LocalizationResource = typeof(vNext框架介绍Resource);
    }
}

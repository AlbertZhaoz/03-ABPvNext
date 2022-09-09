using System;
using System.Collections.Generic;
using System.Text;
using _3._1_ABP.vNext框架介绍_ASPNETCoreApplication.Localization;
using Volo.Abp.Application.Services;

namespace _3._1_ABP.vNext框架介绍_ASPNETCoreApplication;

/* Inherit your application services from this class.
 */
public abstract class vNext框架介绍_ASPNETCoreApplicationAppService : ApplicationService
{
    protected vNext框架介绍_ASPNETCoreApplicationAppService()
    {
        LocalizationResource = typeof(vNext框架介绍_ASPNETCoreApplicationResource);
    }
}

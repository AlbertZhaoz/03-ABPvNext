using System;
using System.Collections.Generic;
using System.Text;
using _3._2_DDD概念和落地.Localization;
using Volo.Abp.Application.Services;

namespace _3._2_DDD概念和落地;

/* Inherit your application services from this class.
 */
public abstract class _2_DDD概念和落地AppService : ApplicationService
{
    protected _2_DDD概念和落地AppService()
    {
        LocalizationResource = typeof(_2_DDD概念和落地Resource);
    }
}

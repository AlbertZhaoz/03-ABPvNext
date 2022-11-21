using Abp.Albert.Bussiness.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Abp.Albert.Bussiness.Blazor;

public abstract class BussinessComponentBase : AbpComponentBase
{
    protected BussinessComponentBase()
    {
        LocalizationResource = typeof(BussinessResource);
    }
}

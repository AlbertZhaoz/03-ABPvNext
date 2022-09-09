using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace _3._1_ABP.vNext框架介绍_ASPNETCoreApplication.Pages;

public class Index_Tests : vNext框架介绍_ASPNETCoreApplicationWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}

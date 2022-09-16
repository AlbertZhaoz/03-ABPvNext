using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace _3._1_ABP.vNext框架介绍.Pages;

public class Index_Tests : vNext框架介绍WebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}

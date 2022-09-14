using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace _3._2_DDD概念和落地.Pages;

public class Index_Tests : _2_DDD概念和落地WebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}

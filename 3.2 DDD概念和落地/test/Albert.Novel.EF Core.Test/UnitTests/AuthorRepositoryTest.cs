using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Albert.Novel.Domain.Author.Entities;
using Shouldly;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Guids;

namespace Albert.Novel.EF_Core.Test.UnitTests
{
    public class AuthorRepositoryTest:AlbertNovelEFCoreTestBase
    {
        private readonly IRepository<Author,Guid> _authorRepository;
        private readonly IGuidGenerator _guidGenerator;

        public AuthorRepositoryTest()
        {
            // 这里不支持依赖注入，需要手动将类型添加进去，来获取服务
            _authorRepository = GetRequiredService<IRepository<Author,Guid>>();
            _guidGenerator = GetRequiredService<IGuidGenerator>();
        }

        [Fact]
        public async Task Should_Insert_A_Valid_Author()
        {
            var result = await  _authorRepository
                .InsertAsync(new Author(_guidGenerator.Create(),"张三","不知名小说作家"));
            result.Id.ShouldNotBe(default);
        }
    }
}

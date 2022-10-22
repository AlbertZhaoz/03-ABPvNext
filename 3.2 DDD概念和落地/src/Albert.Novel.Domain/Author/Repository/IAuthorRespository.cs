using Volo.Abp.Domain.Repositories;

namespace Albert.Novel.Domain.Author.Repository;

public interface IAuthorRepository:IRepository<Entities.Author,Guid>
{
    
}
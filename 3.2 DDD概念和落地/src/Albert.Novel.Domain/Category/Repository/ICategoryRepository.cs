using Volo.Abp.Domain.Repositories;

namespace Albert.Novel.Domain.Category.Repository;

public interface ICategoryRepository:IRepository<Entities.Category,Guid>
{
    
}
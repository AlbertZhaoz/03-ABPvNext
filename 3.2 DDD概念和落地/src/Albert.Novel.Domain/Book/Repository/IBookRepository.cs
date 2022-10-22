using Volo.Abp.Domain.Repositories;

namespace Albert.Novel.Domain.Book.Repository;

public interface IBookRepository:IRepository<Entities.Book,Guid>
{
    
}
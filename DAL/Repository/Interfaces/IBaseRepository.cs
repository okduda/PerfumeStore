using DAL.Entities;

namespace DAL.Repository.Interfaces
{
    public interface IBaseRepository<TEntity>
        where TEntity: BaseEntity
    {
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
        void DeleteById(Guid id);
        void DeleteRangeByIdList(IEnumerable<Guid> entityIdList);
        TEntity GetById(Guid id);
        IEnumerable<TEntity> GetAll();
    }
}

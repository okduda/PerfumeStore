using Microsoft.EntityFrameworkCore;
using DAL.Entities;
using DAL.Configure;

namespace DAL.Repository.Interfaces
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity>
        where TEntity : BaseEntity
    {
        internal PerfumeContext Context { get; set; }
        internal DbSet<TEntity> DbSet { get; set; }

        public BaseRepository(PerfumeContext context)
        {
            this.Context = context;
            this.DbSet = context.Set<TEntity>();
        }
        public void Add(TEntity entity)
        {
            DbSet.Add(entity);
           Context.SaveChanges();
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            DbSet.AddRange(entities);
            Context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            DbSet.Update(entity);
            Context.SaveChanges();
        }

        public void DeleteById(Guid id)
        {
            TEntity entity = DbSet.Where(entity => entity.Id == id).FirstOrDefault();
            if (entity != null)
            {
                DbSet.Remove(entity);
            }
            
            Context.SaveChanges();
        }

        public void DeleteRangeByIdList(IEnumerable<Guid> entityIdList)
        {
            var entities = DbSet.Where(entity => entityIdList.Contains(entity.Id)).ToList();
            DbSet.RemoveRange(entities);
            Context.SaveChanges();
        }

        public TEntity GetById(Guid id)
        {
          return DbSet.Where(entity => entity.Id == id).SingleOrDefault();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return DbSet.ToList();
        }
    }
}
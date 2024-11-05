using IFSPStore.Domain.Base;
using IFSPStore.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace IFSPStore.Repository.Repository
{
    public class BaseRepository<TEntity>
        : IBaseRepository<TEntity> where TEntity
        : BaseEntity<int>
    {
        protected readonly MySqlContext _mySqlcontext;
        public void AtachObjetct(object obj)
        {
            _mySqlcontext.Attach(obj);
        }

        public void ClearChangeTracker()
        {
            _mySqlcontext.ChangeTracker.Clear();
        }

        public void Insert(TEntity entity)
        {
            _mySqlcontext.Set<TEntity>().Add(entity);
            _mySqlcontext.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _mySqlcontext.Entry(entity).State = EntityState.Modified;
            _mySqlcontext.SaveChanges();
        }

        public void Delete(object id)
        {
            _mySqlcontext.Set<TEntity>().Remove(Select(id));
            _mySqlcontext.SaveChanges();
        }
                
        public IList<TEntity> Select(IList<string>? includes = null)
        {
            var dbContext = _mySqlcontext.Set<TEntity>().AsQueryable();
            if (includes != null)
            {
                foreach (var include in includes)
                {
                    dbContext = dbContext.Include(include);
                }
            }
            return dbContext.ToList();
        }

        public TEntity Select(object id, IList<string>? includes = null)
        {
            var dbContext = _mySqlcontext.Set<TEntity>().AsQueryable();
            if (includes != null)
            {
                foreach (var include in includes)
                {
                    dbContext = dbContext.Include(include);
                }
            }
            return dbContext.ToList().Find(x => x.Id == (int)id);
        }        
    }
}

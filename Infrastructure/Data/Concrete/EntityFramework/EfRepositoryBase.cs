using Infrastructure.Data.Abstract;
using Infrastructure.Domain;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infrastructure.Data.Concrete.EntityFramework
{
    public class EfRepositoryBase<TEntity, TContext> : IRepository<TEntity>
         where TEntity : AudiTableEntity, IBaseDomain, new()
        where TContext : DbContext, new()
    {
        public void Insert(TEntity entity)
        {
            using (TContext ctx = new TContext())
            {
                ctx.Set<TEntity>().Add(entity);
                ctx.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext ctx = new TContext())
            {
                ctx.Set<TEntity>().Remove(entity);
                ctx.SaveChanges();
            }
        }

        public void Delete(int Id)
        {
            using (TContext ctx = new TContext())
            {
                TEntity entity = ctx.Set<TEntity>().FirstOrDefault(x => x.Id == Id);
                ctx.Set<TEntity>().Remove(entity);
                ctx.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter = null, params string[] includelist)
        {
            using (TContext ctx = new TContext())
            {
                IQueryable<TEntity> query = ctx.Set<TEntity>();
                if (includelist.Length > 0)
                {
                    foreach (string item in includelist)
                    {
                        query = query.Include(item);
                    }
                }
                return query.SingleOrDefault(filter);
                //return filter == null ? query.ToList().FirstOrDefault() : query.SingleOrDefault();
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null, params string[] includelist)
        {
            using (TContext ctx = new TContext())
            {
                IQueryable<TEntity> query = ctx.Set<TEntity>();
                if (includelist.Length > 0)
                {
                    foreach (var item in includelist)
                    {
                        query = query.Include(item);
                    }
                }
                return filter == null ? query.ToList() : query.Where(filter).ToList();
            }
        }

        public TEntity GetById(int Id, params string[] includelist)
        {
            using (TContext ctx = new TContext())
            {
                IQueryable<TEntity> query = ctx.Set<TEntity>();
                if (includelist.Length > 0)
                {
                    foreach (var item in includelist)
                    {
                        query = query.Include(item);
                    }
                }
                return query.SingleOrDefault(x => x.Id == Id);
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext ctx = new TContext())
            {
                TEntity ent = ctx.Set<TEntity>().Attach(entity).Entity;
                ctx.Entry(entity).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }
    }
}

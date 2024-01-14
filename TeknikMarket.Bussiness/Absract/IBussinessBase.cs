using Infrastructure.Domain;
using System.Linq.Expressions;

namespace TeknikMarket.Bussiness.Absract
{
    public interface IBussinessBase<TEntity>
        where TEntity : AudiTableEntity, IBaseDomain, new()
    {
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void Delete(int Id);
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null, params string[] includelist);

        TEntity Get(Expression<Func<TEntity, bool>> filter = null, params string[] includelist);
        TEntity GetById(int Id, params string[] includelist);
    }
}

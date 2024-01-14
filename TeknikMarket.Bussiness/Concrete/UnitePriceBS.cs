using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TeknikMarket.Bussiness.Absract;
using TeknikMarket.DataAccess.Absract;
using TeknikMarket.Model.Entity;

namespace TeknikMarket.Bussiness.Concrete
{
    public class UnitePriceBS : IUnitePriceBS
    {
        private readonly IUnitePriceRepository _repo;
        public UnitePriceBS(IUnitePriceRepository repo)
        {
            _repo = repo;
        }
        public void Delete(UnitePrice entity)
        {
            _repo.Delete(entity);
        }

        public void Delete(int Id)
        {
            _repo.Delete(Id);
        }

        public UnitePrice Get(Expression<Func<UnitePrice, bool>> filter = null, params string[] includelist)
        {
            return _repo.Get(filter, includelist);
        }

        public List<UnitePrice> GetAll(Expression<Func<UnitePrice, bool>> filter = null, params string[] includelist)
        {
            return _repo.GetAll(filter, includelist);
        }

        public UnitePrice GetById(int Id, params string[] includelist)
        {
            return _repo.GetById(Id, includelist);
        }

        public void Insert(UnitePrice entity)
        {
            _repo.Insert(entity);
        }

        public void Update(UnitePrice entity)
        {
            _repo.Update(entity);
        }
    }
}

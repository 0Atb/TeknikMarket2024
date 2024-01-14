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
    public class CityBS : ICityBS
    {
        private readonly ICityRepository _repo;
        public CityBS(ICityRepository repo)
        {
            _repo = repo;
        }
        public void Delete(City entity)
        {
            _repo.Delete(entity);
        }

        public void Delete(int Id)
        {
            _repo.Delete(Id);
        }

        public City Get(Expression<Func<City, bool>> filter = null, params string[] includelist)
        {
            return _repo.Get(filter, includelist);
        }

        public List<City> GetAll(Expression<Func<City, bool>> filter = null, params string[] includelist)
        {
            return _repo.GetAll(filter, includelist);
        }

        public City GetById(int Id, params string[] includelist)
        {
            return _repo.GetById(Id, includelist);
        }

        public void Insert(City entity)
        {
            _repo.Insert(entity);
        }

        public void Update(City entity)
        {
            _repo.Update(entity);
        }
    }
}

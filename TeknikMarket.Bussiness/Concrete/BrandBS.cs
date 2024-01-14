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
    public class BrandBS : IBrandBS
    {
        private readonly IBrandRepository _repo;
        public BrandBS(IBrandRepository repo)
        {
            _repo = repo;
        }
        public void Delete(Brand entity)
        {
            _repo.Delete(entity);
        }

        public void Delete(int Id)
        {
            _repo.Delete(Id);
        }

        public Brand Get(Expression<Func<Brand, bool>> filter = null, params string[] includelist)
        {
            return _repo.Get(filter, includelist);
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null, params string[] includelist)
        {
            return _repo.GetAll(filter, includelist);
        }

        public Brand GetById(int Id, params string[] includelist)
        {
            return _repo.GetById(Id, includelist);
        }

        public void Insert(Brand entity)
        {
            _repo.Insert(entity);
        }

        public void Update(Brand entity)
        {
            _repo.Update(entity);
        }
    }
}

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
    public class ProductBS : IProductBS
    {
        private readonly IProductRepository _repo;
        public ProductBS(IProductRepository repo)
        {
            _repo = repo;
        }
        public void Delete(Product entity)
        {
            _repo.Delete(entity);
        }

        public void Delete(int Id)
        {
            _repo.Delete(Id);
        }

        public Product Get(Expression<Func<Product, bool>> filter = null, params string[] includelist)
        {
            return _repo.Get(filter, includelist);
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null, params string[] includelist)
        {
            return _repo.GetAll(filter, includelist);
        }

        public Product GetById(int Id, params string[] includelist)
        {
            return _repo.GetById(Id, includelist);
        }

        public void Insert(Product entity)
        {
            _repo.Insert(entity);
        }

        public void Update(Product entity)
        {
            _repo.Update(entity);
        }
    }
}

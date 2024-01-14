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
    public class ProductPriceBS : IProductPriceBS
    {
        private readonly IProductPriceRepository _repo;
        public ProductPriceBS(IProductPriceRepository repo)
        {
            _repo = repo;
        }
        public void Delete(ProductPrice entity)
        {
            _repo.Delete(entity);
        }

        public void Delete(int Id)
        {
            _repo.Delete(Id);
        }

        public ProductPrice Get(Expression<Func<ProductPrice, bool>> filter = null, params string[] includelist)
        {
            return _repo.Get(filter, includelist);
        }

        public List<ProductPrice> GetAll(Expression<Func<ProductPrice, bool>> filter = null, params string[] includelist)
        {
            return _repo.GetAll(filter, includelist);
        }

        public ProductPrice GetById(int Id, params string[] includelist)
        {
            return _repo.GetById(Id, includelist);
        }

        public void Insert(ProductPrice entity)
        {
            _repo.Insert(entity);
        }

        public void Update(ProductPrice entity)
        {
            _repo.Update(entity);
        }
    }
}

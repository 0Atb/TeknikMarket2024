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
    public class ProductImageBS : IProductImageBS
    {
        private readonly IProductImageRepository _repo;
        public ProductImageBS(IProductImageRepository repo)
        {
            _repo = repo;
        }
        public void Delete(ProductImage entity)
        {
            _repo.Delete(entity);
        }

        public void Delete(int Id)
        {
            _repo.Delete(Id);
        }

        public ProductImage Get(Expression<Func<ProductImage, bool>> filter = null, params string[] includelist)
        {
            return _repo.Get(filter, includelist);
        }

        public List<ProductImage> GetAll(Expression<Func<ProductImage, bool>> filter = null, params string[] includelist)
        {
            return _repo.GetAll(filter, includelist);
        }

        public ProductImage GetById(int Id, params string[] includelist)
        {
            return _repo.GetById(Id, includelist);
        }

        public void Insert(ProductImage entity)
        {
            _repo.Insert(entity);
        }

        public void Update(ProductImage entity)
        {
            _repo.Update(entity);
        }
    }
}

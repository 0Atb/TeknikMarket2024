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
    public class CategoryBS : ICategoryBS
    {
        private readonly ICategoryRepository _repo;
        public CategoryBS(ICategoryRepository repo)
        {
            _repo = repo;
        }
        public void Delete(Category entity)
        {
            _repo.Delete(entity);
        }

        public void Delete(int Id)
        {
            _repo.Delete(Id);
        }

        public Category Get(Expression<Func<Category, bool>> filter = null, params string[] includelist)
        {
            return _repo.Get(filter, includelist);
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null, params string[] includelist)
        {
            return _repo.GetAll(filter, includelist);
        }

        public Category GetById(int Id, params string[] includelist)
        {
            return _repo.GetById(Id, includelist);
        }

        public void Insert(Category entity)
        {
            _repo.Insert(entity);
        }

        public void Update(Category entity)
        {
            _repo.Update(entity);
        }
    }
}

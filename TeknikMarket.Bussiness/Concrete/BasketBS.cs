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
    public class BasketBS : IBasketBS
    {
        private readonly IBasketRepository _repo;
        public BasketBS(IBasketRepository repo)
        {
            _repo = repo;
        }
        public void Delete(Basket entity)
        {
            _repo.Delete(entity);
        }

        public void Delete(int Id)
        {
            _repo.Delete(Id);
        }

        public Basket Get(Expression<Func<Basket, bool>> filter = null, params string[] includelist)
        {
            return _repo.Get(filter, includelist);
        }

        public List<Basket> GetAll(Expression<Func<Basket, bool>> filter = null, params string[] includelist)
        {
            return _repo.GetAll(filter, includelist);
        }

        public Basket GetById(int Id, params string[] includelist)
        {
            return _repo.GetById(Id, includelist);
        }

        public void Insert(Basket entity)
        {
            _repo.Insert(entity);
        }

        public void Update(Basket entity)
        {
            _repo.Update(entity);
        }
    }
}

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
    public class OrderBS : IOrderBS
    {
        private readonly IOrderRepository _repo;
        public OrderBS(IOrderRepository repo)
        {
            _repo = repo;
        }
        public void Delete(Order entity)
        {
            _repo.Delete(entity);
        }

        public void Delete(int Id)
        {
            _repo.Delete(Id);
        }

        public Order Get(Expression<Func<Order, bool>> filter = null, params string[] includelist)
        {
            return _repo.Get(filter, includelist);
        }

        public List<Order> GetAll(Expression<Func<Order, bool>> filter = null, params string[] includelist)
        {
            return _repo.GetAll(filter, includelist);
        }

        public Order GetById(int Id, params string[] includelist)
        {
            return _repo.GetById(Id, includelist);
        }

        public void Insert(Order entity)
        {
            _repo.Insert(entity);
        }

        public void Update(Order entity)
        {
            _repo.Update(entity);
        }
    }
}

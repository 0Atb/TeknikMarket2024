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
    public class OrderDetailBS : IOrderDetailBS
    {
        private readonly IOrderDetailRepository _repo;
        public OrderDetailBS(IOrderDetailRepository repo)
        {
            _repo = repo;
        }
        public void Delete(OrderDetail entity)
        {
            _repo.Delete(entity);
        }

        public void Delete(int Id)
        {
            _repo.Delete(Id);
        }

        public OrderDetail Get(Expression<Func<OrderDetail, bool>> filter = null, params string[] includelist)
        {
            return _repo.Get(filter, includelist);
        }

        public List<OrderDetail> GetAll(Expression<Func<OrderDetail, bool>> filter = null, params string[] includelist)
        {
            return _repo.GetAll(filter, includelist);
        }

        public OrderDetail GetById(int Id, params string[] includelist)
        {
            return _repo.GetById(Id, includelist);
        }

        public void Insert(OrderDetail entity)
        {
            _repo.Insert(entity);
        }

        public void Update(OrderDetail entity)
        {
            _repo.Update(entity);
        }
    }
}

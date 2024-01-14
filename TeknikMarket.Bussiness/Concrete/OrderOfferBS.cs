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
    public class OrderOfferBS : IOrderOfferBS
    {
        private readonly IOrderOfferRepository _repo;
        public OrderOfferBS(IOrderOfferRepository repo)
        {
            _repo = repo;
        }
        public void Delete(OrderOffer entity)
        {
            _repo.Delete(entity);
        }

        public void Delete(int Id)
        {
            _repo.Delete(Id);
        }

        public OrderOffer Get(Expression<Func<OrderOffer, bool>> filter = null, params string[] includelist)
        {
            return _repo.Get(filter, includelist);
        }

        public List<OrderOffer> GetAll(Expression<Func<OrderOffer, bool>> filter = null, params string[] includelist)
        {
            return _repo.GetAll(filter, includelist);
        }

        public OrderOffer GetById(int Id, params string[] includelist)
        {
            return _repo.GetById(Id, includelist);
        }

        public void Insert(OrderOffer entity)
        {
            _repo.Insert(entity);
        }

        public void Update(OrderOffer entity)
        {
            _repo.Update(entity);
        }
    }
}

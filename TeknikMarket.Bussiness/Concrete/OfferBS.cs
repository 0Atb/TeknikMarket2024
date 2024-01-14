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
    public class OfferBS : IOfferBS
    {
        private readonly IOfferRepository _repo;
        public OfferBS(IOfferRepository repo)
        {
            _repo = repo;
        }
        public void Delete(Offer entity)
        {
            _repo.Delete(entity);
        }

        public void Delete(int Id)
        {
            _repo.Delete(Id);
        }

        public Offer Get(Expression<Func<Offer, bool>> filter = null, params string[] includelist)
        {
            return _repo.Get(filter, includelist);
        }

        public List<Offer> GetAll(Expression<Func<Offer, bool>> filter = null, params string[] includelist)
        {
            return _repo.GetAll(filter, includelist);
        }

        public Offer GetById(int Id, params string[] includelist)
        {
            return _repo.GetById(Id, includelist);
        }

        public void Insert(Offer entity)
        {
            _repo.Insert(entity);
        }

        public void Update(Offer entity)
        {
            _repo.Update(entity);
        }
    }
}

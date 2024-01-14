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
    public class OfferTypeBS : IOfferTypeBS
    {
        private readonly IOfferTypeRepository _repo;
        public OfferTypeBS(IOfferTypeRepository repo)
        {
            _repo = repo;
        }
        public void Delete(OfferType entity)
        {
            _repo.Delete(entity);
        }

        public void Delete(int Id)
        {
            _repo.Delete(Id);
        }

        public OfferType Get(Expression<Func<OfferType, bool>> filter = null, params string[] includelist)
        {
            return _repo.Get(filter, includelist);
        }

        public List<OfferType> GetAll(Expression<Func<OfferType, bool>> filter = null, params string[] includelist)
        {
            return _repo.GetAll(filter, includelist);
        }

        public OfferType GetById(int Id, params string[] includelist)
        {
            return _repo.GetById(Id, includelist);
        }

        public void Insert(OfferType entity)
        {
            _repo.Insert(entity);
        }

        public void Update(OfferType entity)
        {
            _repo.Update(entity);
        }
    }
}

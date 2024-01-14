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
    public class BankBS : IBankBS
    {
        private readonly IBankRepository _repo;
        public BankBS(IBankRepository repo)
        {
            _repo = repo;
        }
        public void Delete(Bank entity)
        {
            _repo.Delete(entity);
        }

        public void Delete(int Id)
        {
            _repo.Delete(Id);
        }

        public Bank Get(Expression<Func<Bank, bool>> filter = null, params string[] includelist)
        {
            return _repo.Get(filter, includelist);
        }

        public List<Bank> GetAll(Expression<Func<Bank, bool>> filter = null, params string[] includelist)
        {
            return _repo.GetAll(filter, includelist);
        }

        public Bank GetById(int Id, params string[] includelist)
        {
            return _repo.GetById(Id, includelist);
        }

        public void Insert(Bank entity)
        {
            _repo.Insert(entity);
        }

        public void Update(Bank entity)
        {
            _repo.Update(entity);
        }
    }
}

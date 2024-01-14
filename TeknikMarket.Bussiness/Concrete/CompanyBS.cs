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
    public class CompanyBS : ICompanyBS
    {
        private readonly ICompanyRepository _repo;
        public CompanyBS(ICompanyRepository repo)
        {
            _repo = repo;
        }
        public void Delete(Company entity)
        {
            _repo.Delete(entity);
        }

        public void Delete(int Id)
        {
            _repo.Delete(Id);
        }

        public Company Get(Expression<Func<Company, bool>> filter = null, params string[] includelist)
        {
            return _repo.Get(filter, includelist);
        }

        public List<Company> GetAll(Expression<Func<Company, bool>> filter = null, params string[] includelist)
        {
            return _repo.GetAll(filter, includelist);
        }

        public Company GetById(int Id, params string[] includelist)
        {
            return _repo.GetById(Id, includelist);
        }

        public void Insert(Company entity)
        {
            _repo.Insert(entity);
        }

        public void Update(Company entity)
        {
            _repo.Update(entity);
        }
    }
}

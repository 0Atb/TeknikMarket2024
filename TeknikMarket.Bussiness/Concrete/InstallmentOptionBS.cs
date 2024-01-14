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
    public class InstallmentOptionBS : IIntallmentOptionBS
    {
        private readonly IInstallmentOptionRepository _repo;
        public InstallmentOptionBS(IInstallmentOptionRepository repo)
        {
            _repo = repo;
        }
        public void Delete(InstallmentOption entity)
        {
            _repo.Delete(entity);
        }

        public void Delete(int Id)
        {
            _repo.Delete(Id);
        }

        public InstallmentOption Get(Expression<Func<InstallmentOption, bool>> filter = null, params string[] includelist)
        {
            return _repo.Get(filter, includelist);
        }

        public List<InstallmentOption> GetAll(Expression<Func<InstallmentOption, bool>> filter = null, params string[] includelist)
        {
            return _repo.GetAll(filter, includelist);
        }

        public InstallmentOption GetById(int Id, params string[] includelist)
        {
            return _repo.GetById(Id, includelist);
        }

        public void Insert(InstallmentOption entity)
        {
            _repo.Insert(entity);
        }

        public void Update(InstallmentOption entity)
        {
            _repo.Update(entity);
        }
    }
}

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
    public class AdminRoleBS : IAdminRoleBS
    {
        private readonly IAdminRoleRepository _repo;
        public AdminRoleBS(IAdminRoleRepository repo)
        {
            _repo = repo;
        }
        public void Delete(AdminRole entity)
        {
            _repo.Delete(entity);
        }

        public void Delete(int Id)
        {
            _repo.Delete(Id);
        }

        public AdminRole Get(Expression<Func<AdminRole, bool>> filter = null, params string[] includelist)
        {
            return _repo.Get(filter, includelist);
        }

        public List<AdminRole> GetAll(Expression<Func<AdminRole, bool>> filter = null, params string[] includelist)
        {
            return _repo.GetAll(filter, includelist);
        }

        public AdminRole GetById(int Id, params string[] includelist)
        {
            return _repo.GetById(Id, includelist);
        }

        public void Insert(AdminRole entity)
        {
            _repo.Insert(entity);
        }

        public void Update(AdminRole entity)
        {
            _repo.Update(entity);
        }
    }
}

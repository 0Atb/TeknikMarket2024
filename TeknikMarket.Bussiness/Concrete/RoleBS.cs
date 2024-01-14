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
    public class RoleBS : IRoleBS
    {
        private readonly IRoleRepository _repo;
        public RoleBS(IRoleRepository repo)
        {
            _repo = repo;
        }
        public void Delete(Role entity)
        {
            _repo.Delete(entity);
        }

        public void Delete(int Id)
        {
            _repo.Delete(Id);
        }

        public Role Get(Expression<Func<Role, bool>> filter = null, params string[] includelist)
        {
            return _repo.Get(filter, includelist);
        }

        public List<Role> GetAll(Expression<Func<Role, bool>> filter = null, params string[] includelist)
        {
            return _repo.GetAll(filter, includelist);
        }

        public Role GetById(int Id, params string[] includelist)
        {
            return _repo.GetById(Id, includelist);
        }

        public void Insert(Role entity)
        {
            _repo.Insert(entity);
        }

        public void Update(Role entity)
        {
            _repo.Update(entity);
        }
    }
}

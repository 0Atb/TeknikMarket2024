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
    public class UserRoleBS : IUserRoleBS
    {
        private readonly IUserRoleRepository _repo;
        public UserRoleBS(IUserRoleRepository repo)
        {
            _repo = repo;
        }
        public void Delete(UserRole entity)
        {
            _repo.Delete(entity);
        }

        public void Delete(int Id)
        {
            _repo.Delete(Id);
        }

        public UserRole Get(Expression<Func<UserRole, bool>> filter = null, params string[] includelist)
        {
            return _repo.Get(filter, includelist);
        }

        public List<UserRole> GetAll(Expression<Func<UserRole, bool>> filter = null, params string[] includelist)
        {
            return _repo.GetAll(filter, includelist);
        }

        public UserRole GetById(int Id, params string[] includelist)
        {
            return _repo.GetById(Id, includelist);
        }

        public void Insert(UserRole entity)
        {
            _repo.Insert(entity);
        }

        public void Update(UserRole entity)
        {
            _repo.Update(entity);
        }
    }
}

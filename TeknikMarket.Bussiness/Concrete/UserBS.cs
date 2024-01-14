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
    public class UserBS : IUserBS
    {
        private readonly IUserRepository _repo;
        public UserBS(IUserRepository repo)
        {
            _repo = repo;
        }
        public void Delete(User entity)
        {
            _repo.Delete(entity);
        }

        public void Delete(int Id)
        {
            _repo.Delete(Id);
        }

        public User Get(Expression<Func<User, bool>> filter = null, params string[] includelist)
        {
            return _repo.Get(filter, includelist);
        }

        public List<User> GetAll(Expression<Func<User, bool>> filter = null, params string[] includelist)
        {
            return _repo.GetAll(filter, includelist);
        }

        public User GetById(int Id, params string[] includelist)
        {
            return _repo.GetById(Id, includelist);
        }

        public void Insert(User entity)
        {
            _repo.Insert(entity);
        }

        public void Update(User entity)
        {
            _repo.Update(entity);
        }
    }
}

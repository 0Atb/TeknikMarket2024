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
    public class AdminBS : IAdminBS
    {
        private readonly IAdminRepository _repo;
        public AdminBS(IAdminRepository repo)
        {
            _repo = repo;
        }
        public void Delete(Admin entity)
        {
            _repo.Delete(entity);
        }

        public void Delete(int Id)
        {
            _repo.Delete(Id);
        }

        public Admin Get(Expression<Func<Admin, bool>> filter = null, params string[] includelist)
        {
            return _repo.Get(filter, includelist);
        }

        public List<Admin> GetAll(Expression<Func<Admin, bool>> filter = null, params string[] includelist)
        {
            return _repo.GetAll(filter, includelist);
        }

        public Admin GetById(int Id, params string[] includelist)
        {
            return _repo.GetById(Id, includelist);
        }

        public void Insert(Admin entity)
        {
            _repo.Insert(entity);
        }

        public void Update(Admin entity)
        {
           _repo.Update(entity);
        }
    }
}

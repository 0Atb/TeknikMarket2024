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
    public class GenderBS : IGenderBS
    {
        private readonly IGenderRepository _repo;
        public GenderBS(IGenderRepository repo)
        {
            _repo = repo;
        }
        public void Delete(Gender entity)
        {
            _repo.Delete(entity);
        }

        public void Delete(int Id)
        {
            _repo.Delete(Id);
        }

        public Gender Get(Expression<Func<Gender, bool>> filter = null, params string[] includelist)
        {
            return _repo.Get(filter, includelist);
        }

        public List<Gender> GetAll(Expression<Func<Gender, bool>> filter = null, params string[] includelist)
        {
            return _repo.GetAll(filter, includelist);
        }

        public Gender GetById(int Id, params string[] includelist)
        {
            return _repo.GetById(Id, includelist);
        }

        public void Insert(Gender entity)
        {
            _repo.Insert(entity);
        }

        public void Update(Gender entity)
        {
            _repo.Update(entity);
        }
    }
}

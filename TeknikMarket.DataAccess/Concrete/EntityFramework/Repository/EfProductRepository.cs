using Infrastructure.Data.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikMarket.DataAccess.Absract;
using TeknikMarket.DataAccess.Concrete.EntityFramework.Context;
using TeknikMarket.Model.Entity;

namespace TeknikMarket.DataAccess.Concrete.EntityFramework.Repository
{
    public class EfProductRepository : EfRepositoryBase<Product, TeknikMarketContext>, IProductRepository
    {
    }
}

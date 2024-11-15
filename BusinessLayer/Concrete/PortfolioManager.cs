using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class PortfolioManager : IPortoflioService
    {

        private readonly IPortfolioDal _portfolioDal;

        public PortfolioManager(IPortfolioDal portfolioDal)
        {
            _portfolioDal = portfolioDal;
        }

        public void TDelete(int id)
        {
            _portfolioDal.Delete(id);   
        }

        public List<Portfolio> TGetAll()
        {
                return _portfolioDal.GetList();
        }

        public Portfolio TGetById(int id)
        {
            return _portfolioDal.GetById(id);
        }

        public List<Portfolio> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TInsert(Portfolio entity)
        {
            _portfolioDal.Insert(entity);
        }

        public void TUpdate(Portfolio entity)
        {
          _portfolioDal.Update(entity);
        }
    }
}

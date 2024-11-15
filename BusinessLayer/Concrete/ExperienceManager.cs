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
    public class ExperienceManager : IExperienceService
    {

        private readonly IExperienceDal _experienceDal;

        public ExperienceManager(IExperienceDal experienceDal)
        {
            _experienceDal = experienceDal;
        }

        public void TDelete(int id)
        {
          _experienceDal.Delete(id);
        }

        public List<Experience> TGetAll()
        {
           return _experienceDal.GetList();
        }

        public Experience TGetById(int id)
        {
           return _experienceDal.GetById(id);
        }

        public List<Experience> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TInsert(Experience entity)
        {
           _experienceDal.Insert(entity);
        }

        public void TUpdate(Experience entity)
        {
            _experienceDal.Update(entity);
        }
    }
}

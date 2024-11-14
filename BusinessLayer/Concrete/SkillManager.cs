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
    public class SkillManager : ISkillService
    {
        private readonly ISkillDal _skillDal;

        public SkillManager(ISkillDal skillDal)
        {
            _skillDal = skillDal;
        }

        public void TDelete(int id)
        {
            _skillDal.Delete(id);   
        }

        public List<Skill> TGetAll()
        {
            return _skillDal.GetList();
        }

        public Skill TGetById(int id)
        {
           return _skillDal.GetById(id);
        }

        public void TInsert(Skill entity)
        {
           _skillDal.Insert(entity);
        }

        public void TUpdate(Skill entity)
        {
         _skillDal.Update(entity);  
        }
    }
}

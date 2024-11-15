using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AnnouncementManager : IAnnouncementService
    {

        private readonly IAnnouncementDal _announcementDal;

        public AnnouncementManager(IAnnouncementDal announcementDal)
        {
            _announcementDal = announcementDal;
        }

        public void TDelete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Announcement> TGetAll()
        {
            return _announcementDal.GetList();
        }

        public Announcement TGetById(int id)
        {
            return _announcementDal.GetById(id);
        }

        public void TInsert(Announcement entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Announcement entity)
        {
            throw new NotImplementedException();
        }
    }
}

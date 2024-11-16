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
    public class WriterManager : IWriterService
    {
        private readonly IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public void TDelete(int id)
        {
            throw new NotImplementedException();
        }

        public List<WriterUser> TGetAll()
        {
            return _writerDal.GetList();
        }

        public WriterUser TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<WriterUser> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TInsert(WriterUser entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(WriterUser entity)
        {
            throw new NotImplementedException();
        }
    }
}

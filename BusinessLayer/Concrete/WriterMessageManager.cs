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
    public class WriterMessageManager : IWriterMessageService
    {
        private readonly IWriterMessageDal _writerMessageDal;

        public WriterMessageManager(IWriterMessageDal writerMessageDal)
        {
            _writerMessageDal = writerMessageDal;
        }

        public List<WriterMessage> GetListReceiverMessage(string p)
        {
            return _writerMessageDal.GetbyFilter(x => x.Receiver == p);
        }

        public List<WriterMessage> GetListSenderMessage(string p)
        {
            return _writerMessageDal.GetbyFilter(x => x.Sender == p);
        }

        public void TDelete(int id)
        {
            _writerMessageDal.Delete(id);
        }

        public List<WriterMessage> TGetAll()
        {
            throw new NotImplementedException();
        }

        public WriterMessage TGetById(int id)
        {
            return _writerMessageDal.GetById(id);
        }

        public List<WriterMessage> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TInsert(WriterMessage entity)
        {
            _writerMessageDal.Insert(entity);
        }

        public void TUpdate(WriterMessage entity)
        {
            throw new NotImplementedException();
        }
    }
}

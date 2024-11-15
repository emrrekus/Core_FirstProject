using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.EntityFramework
{
    public class EfWriterMessageDal : GenericRepository<WriterMessage>, IWriterMessageDal
    {
        public EfWriterMessageDal(Context context) : base(context)
        {
        }
    }
}

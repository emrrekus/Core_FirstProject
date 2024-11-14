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
    public class UserMessageManager : IUserMessageService
    {
        private readonly IUserMessageDal _userMessageDal;

        public UserMessageManager(IUserMessageDal userMessageDal)
        {
            _userMessageDal = userMessageDal;
        }

        public List<UserMessage> GetUserMessageWithUserService()
        {
          return _userMessageDal.GetUserMessagesWithUser();
        }

        public void TDelete(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserMessage> TGetAll()
        {
           return _userMessageDal.GetList();
        }

        public UserMessage TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TInsert(UserMessage entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(UserMessage entity)
        {
            throw new NotImplementedException();
        }
    }
}

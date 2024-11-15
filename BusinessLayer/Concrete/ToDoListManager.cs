using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ToDoListManager : IToDoListService
    {


        private readonly IToDoListDal _toDoListDal;

        public ToDoListManager(IToDoListDal toDoListDal)
        {
            _toDoListDal = toDoListDal;
        }
        public void TDelete(int id)
        {
            throw new NotImplementedException();
        }

        public List<ToDoList> TGetAll()
        {
           return _toDoListDal.GetList();
        }

        public ToDoList TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ToDoList> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TInsert(ToDoList entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(ToDoList entity)
        {
            throw new NotImplementedException();
        }
    }
}

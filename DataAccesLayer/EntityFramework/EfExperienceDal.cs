﻿using DataAccessLayer.Abstract;
using DataAccesLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfExperienceDal : GenericRepository<Experience>, IExperienceDal
    {
     

        public EfExperienceDal(Context context) : base(context)
        {
        }
    }
}

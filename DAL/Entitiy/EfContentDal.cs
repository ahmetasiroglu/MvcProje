﻿using DAL.Abstract;
using DAL.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entitiy
{
    public class EfContentDal : GenericRepository<Content>, IContentDal
    {
    }
}

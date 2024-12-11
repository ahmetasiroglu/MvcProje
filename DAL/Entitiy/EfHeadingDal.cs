using DAL.Abstract;
using DAL.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entitiy
{
    public class EfHeadingDal : GenericRepository<Heading>, IHeadingDal
    {
    }
}

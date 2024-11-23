using DAL.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Concrate
{
    public class CategoryManager
    {
        GenericRepository<Category> repo = new GenericRepository<Category>();

        public List<Category> GetAll()
        {
            return repo.GetList();
        }

        public void CategoryAddBl(Category p)
        {
            if(p.CatagoryName == "" || p.CatagoryName.Length<=3 || p.CatagoryDescriptions == "" || p.CatagoryName.Length>=51)
            {
                //hata mesajı
            }

            else
            {
                repo.Insert(p);
            }
        }
    }
}

using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class Aboutmanager : IAboutService
    {
        private readonly IAboutDal _AboutDal;

        public Aboutmanager(IAboutDal aboutDal)
        {
            _AboutDal = aboutDal;
        }

        public void TAdd(About t)
        {
            _AboutDal.Insert(t);
        }

        public void TDelete(About t)
        {
            _AboutDal.Delete(t);
        }

        public About TGetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<About> TGetList()
        {
            return _AboutDal.GetList();
        }

        public void TUpdate(About t)
        {
            _AboutDal.Udpate(t);
        }
    }
}
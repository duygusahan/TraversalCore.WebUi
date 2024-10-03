using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalCore.BusinessLayer.Abstract;
using TraversalCore.DataAccessLayer.Abstract;
using TraversalCore.EntityLayer.Concrete;

namespace TraversalCore.BusinessLayer.Concrete
{
    public class SubAboutManager : ISubAboutService
    {
        private readonly ISubAboutDal _subAboutDal;

        public SubAboutManager(ISubAboutDal subAboutDal)
        {
            _subAboutDal = subAboutDal;
        }

        public void TDelete(int id)
        {
            _subAboutDal.Delete(id);
        }

        public SubAbout TGetById(int id)
        {
            return _subAboutDal.GetById(id);
        }

        public List<SubAbout> TGetListAll()
        {
            return _subAboutDal.GetListAll();
        }

        public void TInsert(SubAbout entity)
        {
            _subAboutDal.Insert(entity);
        }

        public void TUpdate(SubAbout entity)
        {
            _subAboutDal.Update(entity);
        }
    }
}

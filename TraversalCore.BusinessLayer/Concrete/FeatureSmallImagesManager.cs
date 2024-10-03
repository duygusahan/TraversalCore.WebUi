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
    public class FeatureSmallImagesManager : IFeatureSmallImagesService
    {
        private readonly IFeatureSmallImagesDal _featureSmallImagesDal;

        public FeatureSmallImagesManager(IFeatureSmallImagesDal featureSmallImagesDal)
        {
            _featureSmallImagesDal = featureSmallImagesDal;
        }

        public void TDelete(int id)
        {
            _featureSmallImagesDal.Delete(id);
        }

        public FeatureSmallImages TGetById(int id)
        {
            return _featureSmallImagesDal.GetById(id);
        }

        public List<FeatureSmallImages> TGetListAll()
        {
            return _featureSmallImagesDal.GetListAll();
        }

        public void TInsert(FeatureSmallImages entity)
        {
           _featureSmallImagesDal.Insert(entity);
        }

        public void TUpdate(FeatureSmallImages entity)
        {
            _featureSmallImagesDal.Update(entity);
        }
    }
}

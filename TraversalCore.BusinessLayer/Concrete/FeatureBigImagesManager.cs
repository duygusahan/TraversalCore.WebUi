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
    public class FeatureBigImagesManager : IFeatureBigImagesService
    {
        private readonly IFeatureBigImagesDal _featureBigImagesDal;

        public FeatureBigImagesManager(IFeatureBigImagesDal featureBigImagesDal)
        {
            _featureBigImagesDal = featureBigImagesDal;
        }

        public void TDelete(int id)
        {
            _featureBigImagesDal.Delete(id);    
        }

        public FeatureBigImages TGetById(int id)
        {
            return _featureBigImagesDal.GetById(id);
        }

        public List<FeatureBigImages> TGetListAll()
        {
            return _featureBigImagesDal.GetListAll();
        }

        public void TInsert(FeatureBigImages entity)
        {
            _featureBigImagesDal.Insert(entity);
        }

        public void TUpdate(FeatureBigImages entity)
        {
            _featureBigImagesDal.Update(entity);
        }
    }
}

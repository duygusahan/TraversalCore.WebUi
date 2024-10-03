using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalCore.DataAccessLayer.Abstract;
using TraversalCore.DataAccessLayer.Context;
using TraversalCore.DataAccessLayer.Repositories;
using TraversalCore.EntityLayer.Concrete;

namespace TraversalCore.DataAccessLayer.EntityFramework
{
    public class EfFeatureSmallImagesDal : GenericRepository<FeatureSmallImages>, IFeatureSmallImagesDal
    {
        public EfFeatureSmallImagesDal(TraversalContext context) : base(context)
        {
        }
    }
}

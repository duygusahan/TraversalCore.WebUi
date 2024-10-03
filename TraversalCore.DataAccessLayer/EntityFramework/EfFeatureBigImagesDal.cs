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
    public class EfFeatureBigImagesDal : GenericRepository<FeatureBigImages>, IFeatureBigImagesDal
    {
        public EfFeatureBigImagesDal(TraversalContext context) : base(context)
        {
        }
    }
}

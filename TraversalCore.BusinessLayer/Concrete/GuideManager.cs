﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalCore.BusinessLayer.Abstract;
using TraversalCore.DataAccessLayer.Abstract;
using TraversalCore.EntityLayer.Concrete;

namespace TraversalCore.BusinessLayer.Concrete
{
    public class GuideManager : IGuideService
    {
        private readonly IGuideDal _guideDal;

        public GuideManager(IGuideDal guideDal)
        {
            _guideDal = guideDal;
        }

        public void TDelete(int id)
        {
            _guideDal.Delete(id);
        }

        public Guide TGetById(int id)
        {
            return _guideDal.GetById(id);
        }

        public List<Guide> TGetListAll()
        {
            return _guideDal.GetListAll();
        }

        public void TInsert(Guide entity)
        {
            _guideDal.Insert(entity);
        }

        public void TUpdate(Guide entity)
        {
            _guideDal.Update(entity);
        }
    }
}

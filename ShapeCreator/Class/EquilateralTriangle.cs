using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShapeCreator
{
    public class EquilateralTriangle : IShape
    {
        private ShapeModel.ShapeType shapeType;

        public EquilateralTriangle()
        {
            shapeType = ShapeModel.ShapeType.EQUILATERAL_TRIANGLE;
        }
        public ShapeModel SetShapeParameters(List<int> list)
        {
            throw new NotImplementedException();
        }
    }
}
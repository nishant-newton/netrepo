using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShapeCreator
{
    public class IsoscelesTriangle : IShape
    {
        private ShapeModel.ShapeType shapeType;

        public IsoscelesTriangle()
        {
            shapeType = ShapeModel.ShapeType.ISOSCELES_TRIANGLE;
        }
        public ShapeModel SetShapeParameters(List<int> list)
        {
            throw new NotImplementedException();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShapeCreator
{
    public class Circle : IShape
    {
        private ShapeModel shape;        

        public Circle()
        {
            shape = new ShapeModel();
            shape.ShapeTypeEnum = ShapeModel.ShapeType.CIRCLE;
        }        

        public ShapeModel SetShapeParameters(List<int> list)
        {
            shape.Radius = list[0];
            return shape;
        }
    }
}
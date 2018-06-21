using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShapeCreator
{
    public class Square : IShape
    {
        private ShapeModel shape;       

        public Square()
        {
            shape = new ShapeModel();
            shape.ShapeTypeEnum = ShapeModel.ShapeType.SQUARE;            
        }
        public ShapeModel SetShapeParameters(List<int> list)
        {
            shape.Height = list[0];
            shape.Width = shape.Height;
            return shape;
        }
    }
}
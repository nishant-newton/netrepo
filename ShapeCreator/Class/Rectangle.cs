using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShapeCreator
{
    public class Rectangle : IShape
    {
        private ShapeModel shape;        

        public Rectangle()
        {
            shape = new ShapeModel();
            shape.ShapeTypeEnum = ShapeModel.ShapeType.RECTANGLE;           
        }
        
        public ShapeModel SetShapeParameters(List<int> list)
        {
            shape.Height = list[0];
            shape.Width = list[1];
            return shape;
        }
    }
}
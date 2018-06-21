using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShapeCreator
{
    public class Parallelogram : IShape
    {        private ShapeModel shape;

        

        public Parallelogram()
        {
            shape = new ShapeModel();
            shape.Angle = 30;
            shape.ShapeTypeEnum = ShapeModel.ShapeType.PARALLELOGRAM;
        }

        public ShapeModel SetShapeParameters(List<int> list)
        {
            shape.Length = list[0];
            shape.Width = list[1];
            return shape;
        }
    }
}
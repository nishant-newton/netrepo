using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShapeCreator
{
    public class Polygon : IShape
    {
        private ShapeModel shape;
        private int NumberofSides;
        public Polygon()
        {
            shape = new ShapeModel();
            shape.ShapeTypeEnum = ShapeModel.ShapeType.POLYGON;
        }

        public Polygon(int NumberofSides) : this()
        {
            this.NumberofSides = NumberofSides;
        }

        public ShapeModel SetShapeParameters(List<int> list)
        {
            shape.Length = list[0];
            shape.NumberOfSides = NumberofSides;
            return shape;
        }
    }
}
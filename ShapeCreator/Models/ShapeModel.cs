using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShapeCreator
{
    public class ShapeModel
    {
        public enum ShapeType
        {
            ISOSCELES_TRIANGLE = 1,
            SQUARE = 2,
            SCALENE_TRIANGLE=3,
            PARALLELOGRAM = 4,
            EQUILATERAL_TRIANGLE=5,
            PENTAGON=6,
            RECTANGLE=7,
            HEXAGON=8,
            OCTAGON=9,
            CIRCLE=10,
            OVAL=11,
            POLYGON=12,
            HEPTAGON=13,
        }

        public int Length { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int Radius { get; set; }
        public int Angle { get; set; }
        public int NumberOfSides { get; set; }

        public string ErrorMessage { get; set; }

        public ShapeType ShapeTypeEnum { get; set; }
    }
}
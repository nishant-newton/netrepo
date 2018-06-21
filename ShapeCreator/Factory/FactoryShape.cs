using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShapeCreator
{
    public static class FactoryShape
    {
        public static IShape GetInstance(ShapeModel.ShapeType shape)
        {
            switch (shape)
            {
                case ShapeModel.ShapeType.CIRCLE:
                    return new Circle();       
                    
                case ShapeModel.ShapeType.EQUILATERAL_TRIANGLE:
                    return new EquilateralTriangle();
                    
                case ShapeModel.ShapeType.HEXAGON:
                    return new Polygon(6);// Hexagon();
                    
                case ShapeModel.ShapeType.ISOSCELES_TRIANGLE:
                    return new IsoscelesTriangle();
                    
                case ShapeModel.ShapeType.OCTAGON:
                    return new Polygon(8);// Octagon();
                    
                case ShapeModel.ShapeType.OVAL:
                    return new Oval();
                    
                case ShapeModel.ShapeType.PARALLELOGRAM:
                    return new Parallelogram();
                    
                case ShapeModel.ShapeType.PENTAGON:
                    return new Polygon(5);// Pentagon();

                case ShapeModel.ShapeType.RECTANGLE:
                    return new Rectangle();

                case ShapeModel.ShapeType.SCALENE_TRIANGLE:
                    return new ScaleneTriangle();

                case ShapeModel.ShapeType.SQUARE:
                    return new Square();

                case ShapeModel.ShapeType.HEPTAGON:
                    return new Polygon(7);
                default:
                    return null;
            }

            
        }
    }
}
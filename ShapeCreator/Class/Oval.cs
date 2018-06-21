using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShapeCreator
{
    public class Oval : IShape
    {
        private ShapeModel.ShapeType shapeType;
        
        public Oval()
        {
            shapeType = ShapeModel.ShapeType.OVAL;
        }

        public ShapeModel SetShapeParameters(List<int> list)
        {
            throw new NotImplementedException();
        }
    }
}
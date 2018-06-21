using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCreator
{
   public interface IShape
    {
        ShapeModel SetShapeParameters(List<Int32> list);        
    }
}

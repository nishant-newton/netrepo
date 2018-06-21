using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace ShapeCreator
{
    public class HomeService
    {
        public ShapeModel GetShape(string input)
        {
            try
            {
                var list = GetNumberOfIntegers(input);
                if (list.Count == 0)
                {
                    return new ShapeModel{
                        ErrorMessage = "Numbers are nor present in the string"
                    };
                }
                var shapeTypeEnum = GetShapeTypeFromSentance(input);
                var Shape = FactoryShape.GetInstance(shapeTypeEnum);

                if(Shape == null)
                {
                    return new ShapeModel
                    {
                        ErrorMessage = string.Format("Shape {0} is not supported", shapeTypeEnum.ToString())
                    };
                }
                var model = Shape.SetShapeParameters(list);
                return model;
            }
            catch (Exception)
            {
                //ideally we should log this exception here..the errormessage is the custom error to be shown to the user
                return new ShapeModel
                {
                    ErrorMessage = "String is not in correct format"
                };

            }
            
        }

        private void ParseSentance(string input)
        {
            //find number of integers in the sentance
            var list = GetNumberOfIntegers(input);
            var shapeTypeEnum = GetShapeTypeFromSentance(input);
        }

        private List<Int32> GetNumberOfIntegers(string input)
        {
            var reg = new Regex("\\d+");
            var match = reg.Match(input);
            var list = new List<Int32>();

            while (match.Success)
            {
                list.Add(Convert.ToInt32(match.Value));
                match = match.NextMatch();
            }
            return list;
        }
        private ShapeModel.ShapeType GetShapeTypeFromSentance(string input)
        {
            var arrInput = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var shapeType = arrInput[2];
            ShapeModel.ShapeType shapeTypeEnum;

            if (Enum.TryParse <ShapeModel.ShapeType>(shapeType.ToUpper(), out shapeTypeEnum))
            {
                return shapeTypeEnum;
            }
            else
                throw new Exception("Input string contains invalid shape type");
        }
    }
}
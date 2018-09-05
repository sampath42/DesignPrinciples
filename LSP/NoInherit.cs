namespace Design_Principles.LSP.Solution
{
    using System;
    using System.Collections.Generic;
    public class NoInherit
    {
        public void SixFor2X3Rectangle()
        {
            var myRectangle = new Rectangle {Height = 2, Width = 3};
            Console.WriteLine(myRectangle.Area());
        }

        public void NineFor3X3Square()
        {
            var mySquare = new Square {SideLength = 3};
            Console.WriteLine(mySquare.Area());
        }

        public void TwentyFor4X5ShapeFromRectangleAnd9For3X3Square()
        {
            var shapes = new List<Shape>
                             {
                                 new Rectangle {Height = 4, Width = 5},
                                 new Square {SideLength = 3}
                             };
            var areas = new List<int>();
            foreach (Shape shape in shapes)
            {
                //areas.Add(shape.Area());
                if (shape.GetType() == typeof (Rectangle))
                {
                    areas.Add(((Rectangle) shape).Area());
                }
                if (shape.GetType() == typeof (Square))
                {
                    areas.Add(((Square) shape).Area());
                }
            }
            Console.WriteLine(areas[0]);
            Console.WriteLine(areas[1]);
        }
    }
}
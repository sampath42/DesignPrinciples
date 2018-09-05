namespace Design_Principles.LSP.Violation
{
    using System;
    public class CalculateArea
    {
        public void SixFor2X3Rectangle()
        {
            var myRectangle = new Rectangle { Height = 2, Width = 3 };
            Console.WriteLine(AreaCalculator.CalculateArea(myRectangle));
        }
        
        public void NineFor3X3Square()
        {
            var mySquare = new Square() { Height = 3 };
            Console.WriteLine(AreaCalculator.CalculateArea(mySquare));
        }
        
        public void  TwentyFor4X5RectangleFromSquare()
        {
            Rectangle newRectangle = new Square();
            newRectangle.Width = 4;
            newRectangle.Height = 5;
            Console.WriteLine(AreaCalculator.CalculateArea(newRectangle));
        }
    }
}
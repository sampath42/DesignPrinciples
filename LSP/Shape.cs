namespace Design_Principles.LSP.Solution
{
    public abstract class Shape
    {        
    }

    public class Rectangle : Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public int Area()
        {
            return Height*Width;
        }
    }

    public class Square : Shape
    {
        public int SideLength;

        public int Area()
        {
            return SideLength*SideLength;
        }
    }
}
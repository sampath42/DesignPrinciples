using System;
using System.Collections.Generic;
// using Design_Principles.SRP.Violation;
// using Design_Principles.SRP.Solution;
// using Design_Principles.OCP.Violation;
// using Design_Principles.OCP.Solution;
// using Design_Principles.LSP.Violation;
// using Design_Principles.LSP.Solution;

namespace Design_Principles
{
    class Program
    {
        static void Main(string[] args)
        {
            // SRP            

            // OCP
            OCP.Violation.Customer customer = new OCP.Violation.Customer();
            var discountAmount = customer.Discount(100,2);
            Console.WriteLine(discountAmount);

            OCP.Solution.Customer customer_OCP = new OCP.Solution.SilverCustomer();
            var discountAmount_OCP = customer_OCP.Discount(100);
            Console.WriteLine(discountAmount_OCP);

            // LSP            
            LSPExample();

            // ISP
            // DIP
        }

        private static void LSPExample()
        {
            LSP.Violation.CalculateArea calculateArea = new LSP.Violation.CalculateArea();
            calculateArea.SixFor2X3Rectangle();
            calculateArea.NineFor3X3Square();
            calculateArea.TwentyFor4X5RectangleFromSquare();

            LSP.Solution.NoInherit noInherit = new LSP.Solution.NoInherit();
            noInherit.SixFor2X3Rectangle();
            noInherit.NineFor3X3Square();
            noInherit.TwentyFor4X5ShapeFromRectangleAnd9For3X3Square();
        }
    }
}

using System;

namespace Design_Principles.SRP.Violation
{
    class Customer
    {
        public void Add()
        {
            try
            {
                // Customer add implementation
            }
            catch(Exception ex)
            {
                System.IO.File.WriteAllText(@"c:\Error.txt", ex.ToString());
            }
        }
    }
}
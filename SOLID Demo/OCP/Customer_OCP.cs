namespace Design_Principles.OCP.Solution
{
    class Customer
    {
        public virtual double Discount(double amount)
        {
            return amount;
        }       
    }
    class SilverCustomer : Customer
    {
        public override double Discount(double amount) 
        {
            return amount - (amount * 5)/100;
        }
    }
    class GoldCustomer : Customer
    {
        public override double Discount(double amount) 
        {
            return amount - (amount * 10)/100;
        }
    }
}
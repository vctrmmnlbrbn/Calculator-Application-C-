using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    public delegate double CalculateOperator(double a, double b);
    internal class CalculatorClass
    {

         public double GetSum(double a, double b)
        {
            return a + b;
        }
        public double GetSubtraction(double a, double b)
        {
            return a - b;
        }
        public double GetProduct(double a, double b)
        {
            return a * b;
        }
        public double GetQuotient(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Denominator cannot be zero.");
            }
            return a / b;
        }
        
        public CalculateOperator calculate_Event;
        public event CalculateOperator CalculateEvent
        {
            add
            {
                calculate_Event += value;
                Console.WriteLine("Added the Delegate");
            }
            remove
            {
                calculate_Event -= value;
                Console.WriteLine("Removed the Delegate");
            }
        }

       

    }
}

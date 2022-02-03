using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_Intarefaces_Lesson11
{
    internal class SimpleCalc : ICalculator
    {
        public double Number1 { get; set; }
        public double Number2 { get; set; }

        public SimpleCalc(double number1, double number2)
        {
            Number1 = number1;
            Number2 = number2;
        }

        public double AddTwoNumbers()
        {
            return Number1 + Number2;
        }
        
        public double SubTwoNumbers()
        {
            return Number1 - Number2;

        }

        public double DivTwoNumbers()
        {
            return Number1 / Number2;
        }

        public double MultplTwoNumbers()
        {
            return Number1 * Number2;
        }


    }
}

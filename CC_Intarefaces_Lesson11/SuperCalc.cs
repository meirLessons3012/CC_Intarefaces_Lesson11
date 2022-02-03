using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_Intarefaces_Lesson11
{
    internal class SuperCalc : ICalculator
    {
        public double Number1 { get; set; }
        public double Number2 { get; set; }
        public double Number3 { get; set; }

        public SuperCalc(double number1, double number3)
        {
            Number1 = number1;
            Number3 = number3;
        }

        public double AddTwoNumbers()
        {
            return Number1 + Number3;
        }

        //public double SubTwoNumbers()
        //{
        //    return Number1 - Number3;
        //}

        public double DivTwoNumbers()
        {
            return Number1 / Number3;
        }

        public double MultplTwoNumbers()
        {
            return Number1 * Number3;
        }



        public void MethodOnlyOnCalcClass()
        {

        }



    }
}

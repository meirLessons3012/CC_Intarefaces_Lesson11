using System;

namespace CC_Intarefaces_Lesson11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object o = "gershon";
            string s = "gershon";
            s.ToUpper();
            o.ToString().ToUpper();

            ICalculator c1 = new SuperCalc(13,5);
            ICalculator c2 = new SimpleCalc(21,52);
            SuperCalc c3 = new SuperCalc(41,20);
            SimpleCalc c4 = new SimpleCalc(3,12);

            CalcNumbers(c1);
            CalcNumbers(c2);
            CalcNumbers(c3);
            CalcNumbers(c4);

            ICalculator[] calculators = new ICalculator[3];
            ICalculator cl1 = c1;
            ICalculator cl2 = c3;
            ICalculator cl3 = c4;
        }

        static void CalcNumbers(ICalculator calculator)
        {
            calculator.AddTwoNumbers();
            calculator.SubTwoNumbers();
            calculator.MultplTwoNumbers();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_Intarefaces_Lesson11
{
    internal interface ICalculator
    {
        double Number1 { get; set; }
        double Number2 { get; set; }
        double AddTwoNumbers();
        double SubTwoNumbers()
        {
            return Number1 - Number2;
        }
        double MultplTwoNumbers();
        double DivTwoNumbers();
    }
}

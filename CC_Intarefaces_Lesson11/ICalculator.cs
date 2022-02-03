using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_Intarefaces_Lesson11
{
    internal interface ICalculator
    {
        public double Number1 { get; set; }
        public double Number2 { get; set; }
        public double AddTwoNumbers();
        public double SubTwoNumbers();
        public double MultplTwoNumbers();
        public double DivTwoNumbers();
    }
}

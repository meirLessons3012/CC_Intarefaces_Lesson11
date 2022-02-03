using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_Intarefaces_Lesson11
{
    internal interface IBreakable
    {
        void Break();
    }

    internal interface IElectronicDevice : IBreakable
    {
        bool IsTurnOn();
        void On();
        void Off();
    }

}

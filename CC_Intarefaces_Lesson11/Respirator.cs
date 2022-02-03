using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_Intarefaces_Lesson11
{
    internal class Respirator : IElectronicDevice, IHardOffable
    {
        public void Break()
        {
            Console.WriteLine("oh no this Respirator Was Very Expensive");
        }

        public bool IsTurnOn()
        {
            return true;
        }

        public void Off()
        {
            Console.WriteLine("Now, Respirator Is On");
        }

        public void On()
        {
            Console.WriteLine("Now, Respirator Is Off");
        }
    }
}

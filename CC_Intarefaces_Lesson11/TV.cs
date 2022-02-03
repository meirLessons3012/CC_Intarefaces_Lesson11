using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_Intarefaces_Lesson11
{
    class TV : IElectronicDevice
    {
        public void Break()
        {
            Console.WriteLine("oh no this Tv Was Very Expensive");
        }

        public bool IsTurnOn()
        {
            return true;
        }

        public void Off()
        {
            Console.WriteLine("Now, TV Is On");
        }

        public void On()
        {
            Console.WriteLine("Now, TV Is Off");
        }
    }

}

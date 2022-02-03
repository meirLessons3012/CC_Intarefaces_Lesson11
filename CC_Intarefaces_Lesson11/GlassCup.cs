using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_Intarefaces_Lesson11
{
    class GlassCup : IBreakable
    {
        public void Break()
        {
            Console.WriteLine("The whole house is glass");
        }
    }

}

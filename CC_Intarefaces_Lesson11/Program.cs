using System;

namespace CC_Intarefaces_Lesson11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            object o1 = "meir";
            string s1 = o1 as string;
            object o2 = 123;
            string s2 = o2 as string;

            string s3 = o1 as string;
            if(s3 != null)
            {
                Console.WriteLine("string");
            }
            else
            {
                Console.WriteLine("not string");
            }


            #region Interfaces
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
            calculators[0] = c1;
            calculators[1] = c3;
            calculators[2] = c4;
            #endregion

            #region MyRegion

            IBreakable glassCup = new GlassCup();
            IBreakable Tv = new TV();
            IElectronicDevice tv2 = new TV();

            DropOnTheFloor(glassCup);
            DropOnTheFloor(Tv);
            DropOnTheFloor(tv2);

            //OnClickPowerOnButton(glassCup);//Error
            //OnClickPowerOnButton(Tv);//Error
            OnClickPowerOnButton(tv2);

            Respirator respirator = new Respirator();
            OnClickPowerOffButton(tv2);
            OnClickPowerOffButton(respirator);

            #endregion

            PrintType("");//system.String
            PrintType(13);//system.Int32
            PrintType(new TV());//CC_Intarefaces_Lesson11.TV


        }

        static void PrintType(object o)
        {
            Console.WriteLine(o.GetType());
        }

        static void CalcNumbers(ICalculator calculator)
        {
            //calculator.AddTwoNumbers();
            calculator.SubTwoNumbers();
            //calculator.MultplTwoNumbers();
        }

        public static void DropOnTheFloor(IBreakable someBreakable)
        {
            someBreakable.Break();
        }

        public static void OnClickPowerOnButton(IElectronicDevice ElDevice)
        {
            if (DateTime.Now.Hour >= 23)
                ElDevice.Break();
            else
                ElDevice.On();
        }
        public static void OnClickPowerOffButton(IElectronicDevice ElDevice)
        {

            if (ElDevice is IHardOffable)
            {
                Console.WriteLine("you can turn off respirator only after 23:00");
                return;
            }
            else
            {
                ElDevice.Off();
            }
        }


    }
}

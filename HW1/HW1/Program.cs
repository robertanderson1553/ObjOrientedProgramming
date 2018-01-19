using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar1 = new Car();
            Car myCar2 = new Car();

            myCar1.Color = "Blue";
            myCar1.Weight = 3000;
            Console.WriteLine("{0}", myCar1.Details());
            
            myCar2.Color = "Red";
            myCar2.Weight = 4000;
            Console.WriteLine("{0}", myCar2.Details());

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Car
    {
        private string _Color;
        private int _Weight;

        //Default constructor
        public Car()
        {
            
        }

        //Constructor for passing in parameters for color and weight
        public Car(string pColor, int pWeight)
        {
            this.Color = pColor;
            this.Weight = pWeight;
        }

        public string Color
        {
            get { return _Color; }
            set { _Color = value; }
        }

        public int Weight
        {
            get { return _Weight; }
            set { _Weight = value; }
        }

        public string Details()
        {
            return "This car weighs " + _Weight + " pounds and it is " + _Color + ". ";
        }
    }
}

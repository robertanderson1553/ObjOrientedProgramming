// -------------------------------------------------------------------------
// --------------------------Written by Robert Anderson---------------------
// --------------------------for Prog 120 Assignment 4----------------------
// --------------------------Last modified: 1/29/2018-----------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//----------------------------------------------------------------------------
/*
 Assumptions:
 1. Child class of parent class shape
 2. Construct a circle shape object (as an integer size (radius), and string object color)
 3. Give values to each object instianted 
 */

namespace ShapesHW 
{
    class Circle : Shape
    {
        // lemgth of radius
        public int Size { get; set; }

        //default constructor
        public Circle() { }

        //constructor that accepts 2 parameters
        public Circle(string pColor, int pSize)
        {
            this.Size = pSize;      // lemgth of radius
            this.Color = pColor;    // object color as defined in parent
        }

        public override void print()  // Child class method
        {
            // Write from the child circle class
            Console.WriteLine("This is a {0} circle with radius of size {1}", Color, Size);

        }
    }
}

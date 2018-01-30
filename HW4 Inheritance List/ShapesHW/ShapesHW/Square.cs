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
 2. Construct a square shape object (as an integer size, and string object color)
 3. Give values to each object instianted 
 */

namespace ShapesHW
{
    public class Square : Shape
    {
        // lemgth of one side
        public int Size { get; set; }

        //default constructor
        public Square() { }

        //constructor that accepts 2 parameters
        public Square(string pColor, int pSize)
        {
            this.Size = pSize;      // lemgth of one side
            this.Color = pColor;    // object color as defined in parent
        }

        public override void print()  // Child class method
        {
            // Write from the child square class
            Console.WriteLine("This is a {0} square with sides of size {1}", Color, Size);
            
        }
    }
}

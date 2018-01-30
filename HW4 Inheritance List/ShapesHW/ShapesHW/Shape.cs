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
 1. Parent class for constructing a shape object (as an integer size (defined in child class), and string object color)
 */

namespace ShapesHW
{
    public class Shape
    {
        // shape color
        public string Color { get; set; }

        public virtual void print()  // Superclass method
        {
            // Write from the parent shape class
            Console.WriteLine("Running print in Parent Class. Color = " + Color);
        }

    }
}

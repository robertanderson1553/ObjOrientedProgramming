// -------------------------------------------------------------------------
// --------------------------Written by Robert Anderson---------------------
// --------------------------for Prog 120 Assignment 4----------------------
// --------------------------Last modified: 1/29/2018-----------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapesHW;

//----------------------------------------------------------------------------
/*
 Assumptions:
 1. Instiate n objects (6 objects for this exercise).
 2. Create a new List of type Shape.
 3. Add n shape objects to the List of type Shape.
 4. Call the Print method of each of the 6 objects.
 */

namespace ShapesHW
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate 6 objects, and set their color and size properties. 
            // Instantiate 2 objects of type square.
            Square square1 = new Square("Purple", 7);
            Square square2 = new Square("Orange", 3);

            // Instantiate 2 objects of type circle
            Circle circle1 = new Circle("Blue", 4);
            Circle circle2 = new Circle("Yellow", 8);

            // Instantiate 2 objects of type diamond (rhombus).
            Rhombus rhombus1 = new Rhombus("Red", 5);
            Rhombus rhombus2 = new Rhombus("Green", 6);

            // Create a new List of type Shape
            List<Shape> myShapeList = new List<Shape>();

            // Add 6 objects above to the myShapeList
            myShapeList.Add(square1);
            myShapeList.Add(square2);
            myShapeList.Add(circle1);
            myShapeList.Add(circle2);
            myShapeList.Add(rhombus1);
            myShapeList.Add(rhombus2);

            // call the Print method of each of the 6 objects.
            foreach (Shape item in myShapeList)
            {
                item.print();
            }

            Console.ReadLine(); // end gracefully
        }
    }
}

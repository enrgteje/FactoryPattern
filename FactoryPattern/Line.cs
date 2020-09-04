/* Name: Enrique Tejeda
 * Date: 9/4/2020
 * Filename: Line.cs
 * Description: The class inherits the function draw() from the interface GeometricShape and implements the function by writing to console.
 */

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace FactoryPattern
{
    class Line : GeometricShape
    {
        public void draw()
        {
            Console.WriteLine("Line is drawn.");
        }
    }
}

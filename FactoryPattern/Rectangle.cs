/* Name: Enrique Tejeda
 * Date: 9/4/2020
 * Filename: Rectangle.cs
 * Description: The class inherits the function draw() from the interface GeometricShape and implements the function by writing to console.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class Rectangle : GeometricShape
    {
        public void draw()
        {
            Console.WriteLine("Rectangle is drawn.");
        }
    }
}

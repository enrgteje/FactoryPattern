/* Name: Enrique Tejeda
 * Date: 9/4/2020
 * Filename: Circle.cs
 * Description: The class inherits the function draw() from the interface GeometricShape and implements the function by writing to console.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class Circle : GeometricShape
    {
        public void draw()
        {
            Console.WriteLine("Circle is drawn.");
        }
    }
}

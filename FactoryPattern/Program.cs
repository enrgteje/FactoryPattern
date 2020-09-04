/* Name: Enrique Tejeda
 * Date: 9/4/2020
 * Filename: Program.cs
 * Description: Program runs through each shape type and tries to use the draw function, but it will overlook if it will return null.
 */

using System;
using System.Reflection.Metadata.Ecma335;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 5; i++)
            {
                ShapeFactory shape = new ShapeFactory();
                ShapeType s = (ShapeType)i;
                if(shape.getShape(s) != null) 
                    shape.getShape(s).draw();
                Console.WriteLine();
            }
        }
    }
}
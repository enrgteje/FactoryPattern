/* Name: Enrique Tejeda
 * Date: 9/4/2020
 * Filename: ShapeFactory.cs
 * Description: Class will assign ShapeType type to the responding shape. Since triangle doesn't have a draw function, it is left out.
 *              If anything other than the cases listed below are entered, then it will write to console that it is an invalide shape.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class ShapeFactory
    {
        public GeometricShape getShape(ShapeType type)
        {
            switch (type)
            {
                case 0:
                    GeometricShape line;
                    return line = new Line();
                case (ShapeType)1:
                    GeometricShape circle;
                    return circle = new Circle();
                case (ShapeType)2:
                    GeometricShape rectangle;
                    return rectangle = new Rectangle();
                case (ShapeType)3:
                    Console.WriteLine("Triangle cannot be drawn.");
                    return null;
                default:
                    Console.WriteLine("Invalid shape!");
                    return null;
            }
        }
    }
}

enum ShapeType { LINE, CIRCLE, RECTANGLE, TRIANGLE }

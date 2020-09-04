Author: Enrique Tejeda
Program: FactoryPattern
Date: 9-4-2020
Description: Program loops and prints to the console what shape is being drawn by using the draw() function. If the shape doesn't have a draw() function it will say that it cannot be drawn and will return null. 
	     Shapes that aren't a line, circle, rectangle, or a triangle will print to console that it is an invalid shape and return null.

Files needed to run program:
	Program.cs
	ShapeFactory.cs
	GeometricShape.cs
	Line.cs
	Rectangle.cs
	Circle.cs

Design Decisions:
	-ShapeFactory.cs
		-Put a switch statement that uses enum ShapeType so that it will use the corresponding shapes as cases. For each case that has a draw function, it will return the function draw() of the shape.
		 If it doesn't have a draw() function, then it will say that the shape can't be drawn and return null. If it is a shape that isn't listed then it will write to console that it is invalid and return null.

	-Program.cs
		-A for loop is setup to show each case used from the switch statement. The loop will not run the draw() function if it will return null for cases that don't have a draw function and/or a defined shape in the program.

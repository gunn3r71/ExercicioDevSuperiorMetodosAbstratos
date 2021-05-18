using ExercicioDevSuperiorMetodosAbstratos.Entities;
using ExercicioDevSuperiorMetodosAbstratos.Entities.Abstract;
using ExercicioDevSuperiorMetodosAbstratos.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioDevSuperiorMetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Title = "Shape Area";

            try
            {
                var shapeList = new List<Shape>();

                Console.Write("Enter the number of shapes: ");
                int numberShapes = int.Parse(Console.ReadLine());

                for (int i = 1; i <= numberShapes; i++)
                {
                    Console.WriteLine($"Shape #{i} data: ");
                    Console.Write("Rectangle,Square or Circle (r,s,c)? ");
                    char shapeType = char.Parse(Console.ReadLine());

                    Console.Write("Color (Red, Blue, Green, Black): ");
                    var shapeColor = (EnumColors) Enum.Parse(typeof(EnumColors), Console.ReadLine());

                    if (shapeType == 'r' || shapeType == 's')
                    {
                        Console.Write("Width: ");
                        var width = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                        Console.Write("Heigth: ");
                        var heigth = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                        if (shapeType == 'r')
                        {
                            shapeList.Add(new Rectangle(width, heigth, shapeColor));
                        }
                        else
                        {
                            shapeList.Add(new Square(width, heigth, shapeColor));
                        }
                    } else 
                    {
                        Console.Write("Radius: ");
                        var radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        shapeList.Add(new Circle(radius, shapeColor));
                    }
                }

                Console.WriteLine("\nSHAPE AREAS: ");
                foreach (var shape in shapeList)
                {
                    Console.BackgroundColor = (ConsoleColor) shape.Color;
                    Console.WriteLine($"{shape}");
                    Console.BackgroundColor = ConsoleColor.Black;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

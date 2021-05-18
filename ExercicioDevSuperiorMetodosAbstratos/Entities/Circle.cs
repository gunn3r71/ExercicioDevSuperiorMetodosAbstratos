using ExercicioDevSuperiorMetodosAbstratos.Entities.Abstract;
using ExercicioDevSuperiorMetodosAbstratos.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioDevSuperiorMetodosAbstratos.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle()
        {
        }

        public Circle(double radius, EnumColors color)
        {
            this.Radius = radius;
            this.Color = color;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius,2);
        }
    }
}

using ExercicioDevSuperiorMetodosAbstratos.Entities.Abstract;
using ExercicioDevSuperiorMetodosAbstratos.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioDevSuperiorMetodosAbstratos.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Heigth { get; set; }

        public Rectangle()
        {
        }

        public Rectangle(double width, double heigth, EnumColors color)
        {
            this.Width = width;
            this.Heigth = heigth;
            this.Color = color;
        }

        public override double Area()
        {
            return this.Width * this.Heigth;
        }
    }
}

using ExercicioDevSuperiorMetodosAbstratos.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercicioDevSuperiorMetodosAbstratos.Entities.Abstract
{
    abstract class Shape
    {
        public EnumColors Color { get; set; }

        public abstract double Area();

        public override string ToString()
        {
            return $"{this.Area().ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}

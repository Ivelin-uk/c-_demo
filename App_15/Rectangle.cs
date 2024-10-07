using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C__2024.App_15
{
    public class Rectangle : Shape
    {
        // TODO: Добавете полета и конструктор
        public override double CalculatePerimeter()
        { 
            return this.sideA * 2 + this.sideB * 2; 
        }
        public override double CalculateArea()
        { 
            return this.sideA * this.sideB; 
        }
        public sealed override string Draw()
        { 
            return base.Draw() + "Rectangle"; 
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C__2024.App_15
{
    public class Circle : Shape
    {
    // TODO: Добавете полета и конструктор
    public override double CalculatePerimeter()
    { 
        return 2 * Math.PI * this.radius; 
    }
    public override double CalculateArea()
    { 
        return Math.PI * this.radius * this.radius;
    }
    public sealed override string Draw()
    { 
        return base.Draw() + "Circle"; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C__2024.App_15
{
    public class Shape
    {
        public abstract double CalculatePerimeter();
        public abstract double CalculateArea();
        public virtual string Draw()
        {
            return "Drawing ";
        }
    }
}
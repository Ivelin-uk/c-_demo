using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_13
{
    public class Rectangle : IDrawable
    {
        public void Draw()
        {
            System.Console.WriteLine("Draw rectangle !");
        }
    }
}
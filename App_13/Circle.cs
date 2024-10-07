using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_13
{
    public class Circle : IDrawable 
    {
        public void Draw() 
        {
            System.Console.WriteLine("draw circle !");
        }
    }
}
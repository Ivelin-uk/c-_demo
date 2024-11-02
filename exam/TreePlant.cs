using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class TreePlant : Plant
{
    private int height;
    public int Height
    {
        get 
        {
            return this.height;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Height should be positive!");
            }
            this.height = value;
        }
    }

    public TreePlant(int id, string name, double humidityLevel, double fertilityLevel, int height) : base(id, name, "tree", humidityLevel, fertilityLevel)
    {
        this.Height = height;
    }

     public override string ToString()
    {
        string result = base.ToString();
        result += "\n";
        result += $"Height: {this.Height}";

        return result;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class FloweringPlant : Plant
{
    private string color;
    public string Color
    {
        get 
        {
            return this.color;
        }
        set
        {
            if (value.Length < 3 || value.Length > 30)
            {
                throw new ArgumentException("Name should be between 3 and 30 characters!");
            }
            this.color = value;
        }
    }

    public FloweringPlant(int id, string name, double humidityLevel, double fertilityLevel, string color) : base(id, name, "flower", humidityLevel, fertilityLevel)
    {
        this.Color = color;
    }

    public override string ToString()
    {
        string result = base.ToString();
        result += "\n";
        result += $"Color: {this.Color}";

        return result;
    }
}

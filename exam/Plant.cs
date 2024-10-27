using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public abstract class Plant
{
    private int id;
    private string name;
    private string type;
    private double humidityLevel;
    private double fertilityLevel;
    private List<CareItem> careItems;

    public int Id
    {
        get => this.id
        private set 
        {
            this.id = value
        }
    }

    public string Name
    {
        get => this.name;
        set
        {
            if (value.Length < 3 || value.Length > 30)
            {
                throw new ArgumentException("Name should be between 3 and 30 characters!");
            }
            name = value;
        }
    }

    public string Type
    {
        get => type;
        set
        {
            if (value.Length < 3 || value.Length > 30)
            {
                throw new ArgumentException("Type should be between 3 and 30 characters!");
            }
            type = value;
        }
    }

    public List<CareItem> CareItems { get; private set; }

    public double HumidityLevel
    {
        get => humidityLevel;
        set
        {
            if (value < 0 || value > 1)
            {
                throw new ArgumentException("Humidity Level should be between 0 and 1!");
            }
            humidityLevel = value;
        }
    }

    public double FertilityLevel
    {
        get => fertilityLevel;
        set
        {
            if (value < 0 || value > 1)
            {
                throw new ArgumentException("Fertility Level should be between 0 and 1!");
            }
            fertilityLevel = value;
        }
    }

    public List<CareItem> CareItems
    {
        get => _careItems;
        set
        {
            if (value == null)
            {
                throw new ArgumentException("CareItems list cannot be null!");
            }
            careItems = value;
        }
    }

    protected Plant(int id, string name, string type, double humidityLevel, double fertilityLevel)
    {
        Id = id;
        Name = name;
        Type = type;
        HumidityLevel = humidityLevel;
        FertilityLevel = fertilityLevel;
        CareItems = new List<CareItem>();
    }
    public abstract void CareInstructions();
}

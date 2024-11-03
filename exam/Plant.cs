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
    private List<CareItem> careItems = new List<CareItem>();

    public int Id
    {
        get
        {
            return this.id;
        }
        set 
        {
            this.id = value;
        }
    }

    public string Name
    {
        get 
        {
            return this.name;
        }
        set
        {
            if (value.Length < 3 || value.Length > 30)
            {
                throw new ArgumentException("Name should be between 3 and 30 characters!");
            }
            this.name = value;
        }
    }

    public string Type
    {
        get
        {
            return this.type;
        }
        set
        {
            if (value.Length < 3 || value.Length > 30)
            {
                throw new ArgumentException("Type should be between 3 and 30 characters!");
            }
            this.type = value;
        }
    }

    public double HumidityLevel
    {
        get 
        {
            return this.humidityLevel;
        }
        set
        {
            if (value < 0 || value > 1)
            {
                throw new ArgumentException("Humidity Level should be between 0 and 1!");
            }
            this.humidityLevel = value;
        }
    }

    public double FertilityLevel
    {
        get
        { 
            return this.fertilityLevel;
        }
        set
        {
            if (value < 0 || value > 1)
            {
                throw new ArgumentException("Fertility Level should be between 0 and 1!");
            }
            this.fertilityLevel = value;
        }
    }

    protected Plant(int id, string name, string type, double humidityLevel, double fertilityLevel)
    {
        this.Id = id;
        this.Name = name;
        this.Type = type;
        this.HumidityLevel = humidityLevel;
        this.FertilityLevel = fertilityLevel;
        //this.careItems = new List<CareItem>();
    }
    public void AddCareItem(CareItem careItem)
    {
        this.careItems.Add(careItem);
    }

    public int TotalCaresDone()
    {
        return careItems.Where(x => x.Status == true).Count();
    }

    public bool Water(double percent)
    {
        if (HumidityLevel + percent <= 1)
        {
            HumidityLevel += percent;
            return true;
        }
        return false;
    }
    
    public bool Fertilize(double percent)
    {
        if (FertilityLevel + percent <= 1)
        {
            FertilityLevel += percent;
            return true;
        }
        return false;
    }

    public override string ToString()
    {
        string result = $"Name: {this.Name}";
        result += "\n";
        result += $"Type: {this.Type}";
        result += "\n";
        result += $"Humidity Level: {this.HumidityLevel} %";
        result += "\n";
        result += $"Fertility Level: {this.FertilityLevel} %";

        return result;
    }
}

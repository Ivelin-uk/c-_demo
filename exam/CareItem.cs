using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class CareItem
{
    private string name;
    private bool status;
    public string Name
    {
        get 
        {
            return this.name;
        }
        set
        {
            if (value.Length < 2 || value.Length > 40)
            {
                throw new ArgumentException("Name should be between 2 and 40 characters!");
            }
            this.name = value;
        }
    }

    public bool Status
    {
        get 
        {
            return this.status;
        }
        set
        {
            this.status = value;
        }
    }

    public CareItem(string name, bool status)
    {
        this.Name = name;
        this.Status = status;
    }

    public override string ToString()
    {
        string result = $"CareItem {Name}";
        result += "\n";
        result = $"Status: {Status}";

        return result;
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Controller
{
    private readonly Dictionary<int, Plant> plants;

    public Controller()
    {
        plants = new Dictionary<int, Plant>();
    }

    public string AddCareItem(List<string> args)
    {
        int plantId = int.Parse(args[0]);
        string name = args[1];
        bool status = bool.Parse(args[2]);

        if(plants.ContainsKey(plantId))
        {
            CareItem CareItem = new CareItem(name,status);
            plants[plantId].AddCareItem(CareItem);
            return $"Created Care {name} for {plantId}!";
        }
        else
        {
            return $"Plant not found!";
        }
    }

    public string AddPlant(List<string> args)
    {
        int plantId = int.Parse(args[0]);
        string name = args[1];
        double humidityLevel = double.Parse(args[2]);
        double fertilityLevel = double.Parse(args[3]);
        string type = args[4];
    
        if(type == "tree")
        {
            int option = int.Parse(args[5]);
            TreePlant treePlant = new TreePlant(plantId,name,humidityLevel,fertilityLevel,option);

            if(!plants.ContainsKey(plantId))
            {
                this.plants.Add(plantId,treePlant);
                return $"Created Plant {name} with ID {plantId}!";
            }
            else
            {
                return $"Plant with ID {plantId} already exists!";
            }

        }

        if(type == "flower")
        {
            string option = args[5];
            FloweringPlant floweringPlant = new FloweringPlant(plantId,name,humidityLevel,fertilityLevel,option);

            if(!plants.ContainsKey(plantId))
            {
                this.plants.Add(plantId,floweringPlant);
                return $"Created Plant {name} with ID {plantId}!";
            }
            else
            {
                return $"Plant with ID {plantId} already exists!";
            }
        }

        return "Invalid date";
    }

    public string GetTotalCaresByPlantId(List<string> args)
    {
        int plantId = int.Parse(args[0]);
        if(!plants.ContainsKey(plantId))
        {
            return $"Plant not found!";
        }

        int count = plants[plantId].TotalCaresDone();
        return $"Total cares for plant {plantId}: {count}";
    }

    public string WaterPlantById(List<string> args)
    {
        int plantId = int.Parse(args[0]);
        double percent = double.Parse(args[1]);

        if(!plants.ContainsKey(plantId))
        {
            return $"Plant not found!";
        }

        if(plants[plantId].Water(percent))
        {
            return $"Plant {plantId} was watered successfully!";
        }
        else
        {
            return $"Plant {plantId} could not be watered!.";
        }
    }

    public string FertilizePlantById(List<string> args)
    {
        int plantId = int.Parse(args[0]);
        double percent = double.Parse(args[1]);

        if(!plants.ContainsKey(plantId))
        {
            return $"Plant not found!";
        }

        if(plants[plantId].Fertilize(percent))
        {
            return $"Plant {plantId} was fertilized successfully!";
        }
        else
        {
            return $"Plant {plantId} could not be fertilized!";
        }
    }

    public string GetTallestTree(List<string> args)
    {   
        var tallest = plants.Values.OfType<TreePlant>().OrderByDescending(x => x.Height).FirstOrDefault();
        if (tallest == null)
        {
            return "No trees found!";
        }
        return tallest.ToString();
    }

}
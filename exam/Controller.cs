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
        /*
            При успех върнете:

            Съобщение: Created Care {name} for {plantId}!

            Ако такова растение не съществува - да се изведе "Plant not found!".
        */
        //TODO: Implement me...
        throw new NotImplementedException();
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
        //TODO: Implement me...
        throw new NotImplementedException();
    }

    public string WaterPlantById(List<string> args)
    {
        //TODO: Implement me...
        throw new NotImplementedException();
    }

    public string FertilizePlantById(List<string> args)
    {
        //TODO: Implement me...
        throw new NotImplementedException();
    }

    public string GetTallestTree(List<string> args)
    {
        //TODO: Implement me...
        throw new NotImplementedException();
    }

}
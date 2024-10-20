using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Dog : IAnimal , IMakeNoise , IMakeTrick
{
    public string MakeNoise()
    {
        return "Woof";
    }
    public string MakeTrick()
    {
        return "Hold my paw, human!";
    }
    public string Perform()
    {
        return this.MakeNoise() + " " + this.MakeTrick();
    }

    public string Jump_dog()
    {
        return "Jump_dog";
    }

}

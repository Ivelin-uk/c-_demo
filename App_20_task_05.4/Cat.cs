using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*
Този клас трябва да имплементира IAnimal.
• Метод MakeNoise(), който отпечатва съобщението: “Meow!”.
• Метод MakeTrick(), който отпечатва: “No trick for you! I'm too lazy!”
• Метод Perform(), който извиква първо MakeNoise(), а после MakeTrick()
*/
public class Cat : IAnimal , IMakeNoise , IMakeTrick
{
    public string MakeNoise()
    {
        return "Meow";
    }
    public string MakeTrick()
    {
        return "No trick for you! I'm too lazy!";
    }
    public string Perform()
    {
        return this.MakeNoise() + " " + this.MakeTrick();
    }

    public string Jump_cat()
    {
        return "Jump_cat";
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Trainer
{
    private IAnimal entity;
    public IAnimal Entity
    {
        set 
        { 
            this.entity = value; 
        }
        get 
        { 
            return this.entity; 
        }
    }
    public Trainer(IAnimal entity)
    {
        this.Entity = entity;
    }

    public void Make()
    {
        System.Console.WriteLine(this.entity.Perform());
    }
}

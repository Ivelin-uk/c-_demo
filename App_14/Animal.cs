using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_14
{
    public class Animal : IMakeNoise, IMakeTrick
    {
        private string name;
        private int age;

        public string Name
        {
            set
            {
                this.name = value;
            }
            get
            {
                return this.name;
            }
        }
        public int Age
        {
            set
            {
                if(value > 0)
                {
                    this.age = value;
                }
                else
                {
                    throw new ArgumentException("Invalid age !");
                }
            }
            get
            {
                return this.age;
            }
        }

        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public virtual string MakeNoise()
        {
            return "My name is " + this.Name + " I am " + this.Age  + " old.";
        }

        public virtual string MakeTrick()
        {
            return "Look at my trick!";
        }
    }
}
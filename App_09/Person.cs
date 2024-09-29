using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_09
{
    public class Person
    {
        private string name;
        private string address;

        public Person(string name, string address)
        {
            this.Name = name;
            this.Address = address;
        }
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

        public string Address
        {
            set 
            { 
                this.address = value; 
            }
            get 
            {  
               return this.address; 
            }
        }

        public void Sleep()
        {
            System.Console.WriteLine("Sleep");
        }
        public override string ToString()
        {
            return "Name: " + this.Name + " Address: " + this.Address;
        }
    }
}
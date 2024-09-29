using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_09
{
    public class Employee : Person
    {
        public string company;
        public string Company
        {
            set 
            { 
                this.company = value; 
            }
            get 
            {  
               return this.company; 
            }
        }

        public Employee(string name, string address, string company): base(name,address)
        {
            this.Company = company;
        }

        public override string ToString()
        {
            return base.ToString() + " Company: " + this.company;
        }
    }
}
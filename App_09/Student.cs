using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_09
{
    public class Student : Person
    {
        public string school;
        public string School
        {
            set 
            { 
                this.school = value; 
            }
            get 
            {  
               return this.school; 
            }
        }
        public Student(string name, string address, string school): base(name,address)
        {
            this.School = school;
        }

        public override string ToString()
        {
            return base.ToString() + " School: " + this.school;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_12
{
    public class FullTimeEmployee : BaseEmployee
    {
        private string employeePosition;

        private string employeeDepartment;

        public string EmployeePosition
        {
            set
            {
                if (value.Length > 2)
                {
                    this.employeePosition = value;
                }
                else
                {
                    throw new ArgumentException("Invalid length position!");
                }
            }
            get
            {
                return this.employeePosition;
            }
        }

        public string EmployeeDepartment
        {
            set
            {
                if (value.Length >= 2)
                {
                    this.employeeDepartment = value;
                }
                else
                {
                    throw new ArgumentException("Invalid length department!");
                }
            }
        }

        public FullTimeEmployee(string employeeID, string employeeName,string employeeAddress,string employeePosition, string employeeDepartment) 
        : base(employeeID, employeeName,employeeAddress)
        {
            this.EmployeePosition = employeePosition;
            this.EmployeeDepartment = employeeDepartment;
        }

        public string Show()
        {
            return base.Show() + " Department: " + this.GetDepartment() + " Position: " + this.EmployeePosition;
        }

        public override double CalculateSalary(int workingHours)
        {
            double r = 250 + workingHours * 10.80;
            return r;
        }

        public override string GetDepartment()
        {
            return this.employeeDepartment;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_12
{
    public class ContractEmployee : BaseEmployee
    {
        private string employeeTask;

        private string employeeDepartment;

        public string EmployeeTask
        {
            set
            {
                if (value.Length > 2)
                {
                    this.employeeTask = value;
                }
                else
                {
                    throw new ArgumentException("Invalid length task!");
                }
            }
            get
            {
                return this.employeeTask;
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

        public ContractEmployee(string employeeID, string employeeName,string employeeAddress,string employeeTask, string employeeDepartment) 
        : base(employeeID, employeeName,employeeAddress)
        {
            this.EmployeeTask = employeeTask;
            this.EmployeeDepartment = employeeDepartment;
        }

        public string Show()
        {
            return base.Show() + " Department: " + this.GetDepartment() + " Task: " + this.EmployeeTask;
        }

        public override double CalculateSalary(int workingHours)
        {
            double r = 250 + workingHours * 20;
            return r;
        }

        public override string GetDepartment()
        {
            return this.employeeDepartment;
        }
    }
}
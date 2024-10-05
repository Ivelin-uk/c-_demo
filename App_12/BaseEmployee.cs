using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*
    Поле employeeID, което пази идентификационния номер на работника
    като низ.
    • Поле employeeName за отбелязване на името на работника
    • Поле employeeAddress за отбелязване на адреса по местоживеене на
    работника
    • Конструктор, който приема три параметъра и ги присвоява на
    съответните полета, изброени по-горе
    • Метод Show(), който отпечатва информация за работника.
    • Абстрактен метод CalculateSalary(int workingHours), който ще изчислява
    заплатата за работника, като се приема параметър – брой изработени
    часове
    • Абстрактен метод GetDepartment(), който връща името на звеното от
    фирмата, в което работи работника
*/

namespace App_12
{
    abstract public class BaseEmployee
    {
        private string employeeID;

        private string employeeName;

        private string employeeAddress;

        public string EmployeeID
        {
            set
            {
                if (value.Length > 2)
                {
                    this.employeeID = value;
                }
                else
                {
                    throw new ArgumentException("Invalid length ID!");
                }
            }
            get
            {
                return this.employeeID;
            }
        }

        public string EmployeeName
        {
            set
            {
                if (value.Length > 2)
                {
                    this.employeeName = value;
                }
                else
                {
                    throw new ArgumentException("Invalid length name!");
                }
            }
            get
            {
                return this.employeeName;
            }
        }

        public string EmployeeAddress
        {
            set
            {
                if (value.Length > 2)
                {
                    this.employeeAddress = value;
                }
                else
                {
                    throw new ArgumentException("Invalid length address!");
                }
            }
            get
            {
                return this.employeeAddress;
            }
        }

        public BaseEmployee(string employeeID, string employeeName,string employeeAddress)
        {
            this.EmployeeID = employeeID;
            this.EmployeeName = employeeName;
            this.EmployeeAddress = employeeAddress;
        }

        public string Show()
        {
            return "ID: " + this.EmployeeID + " Name: " + this.EmployeeName + " Address: " + this.EmployeeAddress;
        }

        abstract public double CalculateSalary(int workingHours);

        abstract public string GetDepartment();
    }
}
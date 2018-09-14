using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab1
{
    class Employee
    {
        private string _employeeName;
        private double _employeeBaseSalary;
        private int _employeeId;
        private static int employeeCount = 1;

        public string EmployeeName { get => _employeeName; set => _employeeName = value; }
        public double EmployeeBaseSalary { get => _employeeBaseSalary; set => _employeeBaseSalary = value; }
        public int EmployeeId { get => _employeeId; set => _employeeId = value; }

        public Employee(string name, double baseSalary)
        {
            EmployeeName = name;
            EmployeeBaseSalary = baseSalary;
            EmployeeId = employeeCount++;
        }

        public double getBaseSalary()
        {
            return EmployeeBaseSalary;
        }

        public string getName()
        {
            return this.EmployeeName;
        }
        public int getEmployeeID()
        {
            return EmployeeId;
        }

        public string toString()
        {
            return EmployeeId + " " + EmployeeName;
        }

        public virtual string employeeStatus()
        {
            return toString() + " is in the company's system.";
        }
    }
}

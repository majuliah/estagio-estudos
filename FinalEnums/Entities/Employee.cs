using static System.Console;
using FinalEnums.Entities;
using FinalEnums.Enums;

namespace FinalEnums.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public EmployeeLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> TotalByHours { get; set; } = new List<HourContract>();

        public Employee() { }

        public Employee(string name, EmployeeLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        //methods and operations
        public void AddContracts(HourContract contract)
        {
            TotalByHours.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            TotalByHours.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;

            foreach(HourContract contract in TotalByHours)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                    sum += contract.TotalValue(); 
            }

            return sum;
            
        }

    }
}
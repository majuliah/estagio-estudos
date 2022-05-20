using static System.Console;
using System.Globalization;
using FinalEnums.Entities;
using FinalEnums.Enums;

namespace FinalEnums
{
    class Program
    {
        public static void Main(string[] args)
        {

            WriteLine("Primeiro, entre com o nome do departamento :)");
            string nomedpto = ReadLine();
            WriteLine("Entre com o nome do empregado!");
            string employeesName = ReadLine();
            WriteLine("Entre com o nível do cargo: ");
            EmployeeLevel level = Enum.Parse<EmployeeLevel>(ReadLine());
            WriteLine("Agora o valor do salário");
            double salario = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
            WriteLine("Quantos contratos você deseja cadastrar?");
            int numberOfContracts = int.Parse(ReadLine());

            Department departamento = new Department(nomedpto);
            Employee employee1 = new Employee(employeesName, level, salario, departamento);

            for(int i = 1; i <= numberOfContracts; i++)
            {
                WriteLine("Entre com a data do primeiro contrato: MM/YYYY");
                DateTime data = DateTime.Parse(ReadLine());
                WriteLine("Entre com o valor por hora :");
                double valorPorHora = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
                WriteLine("Entre com o total de horas trabalhadas: ");
                int horas = int.Parse(ReadLine());
                HourContract contract = new HourContract(data, valorPorHora, horas);
                employee1.AddContracts(contract);
            }

            WriteLine("Entre com o mês e o ano para calcular o salário: ");
            string monthAndYear = ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            WriteLine("Entre com o mês e o ano para calcular o salário: ");
            WriteLine($"Nome do empregado: {employee1.Name}");
            WriteLine($"Salário do empregado: {employee1.Income(year, month)}");
            WriteLine($"Departamento do empregado: {employee1.Department.Name}");











        }
    }
}
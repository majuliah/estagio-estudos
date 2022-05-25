using static System.Console;

using Composition.Entities.Enums;

namespace Compositions
{
    class Program
    {
        static void Main(string[] args)
        {   

            WriteLine("Entre com o nome do departamento: ");
            string departamentoName = ReadLine();
            WriteLine("Agora entre com uma data: ");
            string data = ReadLine();
            WriteLine("Agora entre com o nome do funcionário ");
            string nameFuncionario = ReadLine();
            WriteLine("Entre com o nível do funcionário: ");
            WorkerLever Level = Enum.Parse<WorkerLever>(ReadLine());
            WriteLine("Now enter with a base salary");
            double baseSalary = double.Parse(ReadLine());


            //Departament dpt = new Departament(departamentoName);
            //Worker worker = new Worker(nameFuncionario, Level, data, baseSalary);

        }
    }
}

using static System.Console;

namespace TestandoExpressoes
{
    public class Program
    {
         public static void Main(string[] args)
        {
            
            string nome = "Majulia";
            string nome1 = nome.ToUpper();

            bool comeca = !nome1.StartsWith("Ma");

            WriteLine(comeca);
            comeca = nome1.StartsWith("MA");

            WriteLine(comeca);
            comeca = nome1.StartsWith("Ju");

            WriteLine(comeca);
            comeca = nome1.StartsWith("ju");

            WriteLine(comeca);
            comeca = nome1.StartsWith("PRJ");
        }
        
    }
}
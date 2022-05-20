using static System.Console;
using System.Globalization;

namespace dateTime
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var data = DateTime.Now;
            var data2 = new DateTime(2022, 05, 13, 08, 15, 00);

            TimeSpan diferenca = data - data2;
            var difEmHora = diferenca.TotalHours;

            WriteLine("A diferença em horas é: " + difEmHora.ToString("F2"));
            WriteLine("A diferença em minutos é: " + diferenca.TotalMinutes);


            if(diferenca.TotalMinutes > 495)
                WriteLine("Maior que 8:15!!!");
            else
                WriteLine("Menor que 8:15!!!!!");

        }
    }
}

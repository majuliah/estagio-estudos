using static System.Console;
using System.Globalization;

namespace TestandoCodigos
{
    class Program
    {
        public static void Main(string[] args)
        {
            WriteLine("Hello World! : D ");
            
            var numberOne = 10;
            var numberTwo = numberOne;

            WriteLine("number one is: " + numberOne);
            WriteLine("numberTwo is: " + numberTwo);

            numberOne = 23;
            numberTwo += 2;

            WriteLine("Now numberOne is: " + numberOne);
            WriteLine("Now numberTwo is: " + numberTwo);


            //dealing with time

            TimeSpan horaLimiteConvertida = new TimeSpan(08, 15, 00);
            var tudoConvertido = horaLimiteConvertida.TotalMinutes;
            WriteLine("Tudo convertido é: " + tudoConvertido);

            var hora = 10;
            var minutos = 20;
            var segundos = 30;

            TimeSpan testando = new TimeSpan(hora, minutos, segundos);
            var convertendoTudo = testando.TotalMinutes;
            WriteLine("Testando por último " + convertendoTudo.ToString("F1",CultureInfo.InvariantCulture));

            WriteLine(convertendoTudo.ToString());

            //dealing with string to time
            var Hora = "08:15";
            var pegandoAhora = Hora.Remove(2);
            var pegandoOminuto = Hora.Remove(0, 3);
            WriteLine("Pegando a hora é: " + pegandoAhora + "e pegando o minuto é: " + pegandoOminuto);

            TimeSpan testandoDireto = new TimeSpan(int.Parse(Hora.Remove(2)), int.Parse(Hora.Remove(0, 3)), 00);
            WriteLine("O valor foi: " + testandoDireto.TotalMinutes);
        
            TimeSpan testandoAcima = new TimeSpan(int.Parse(pegandoAhora), int.Parse(pegandoOminuto), 00);
            var ResultadoConversao = testandoAcima.TotalMinutes;

            WriteLine("Os minutos devem ser 495, eles são: " + ResultadoConversao);

            Teste testandoComClasses = new Teste("08:15", "Maraju", 22);

            TimeSpan testandoAsClasses = new TimeSpan(
                int.Parse(
                    testandoComClasses.Valor.Remove(2)
                ), int.Parse(
                    testandoComClasses.Valor.Remove(0, 3)
                ), 00
            );

            WriteLine("Testando aqui: " + testandoComClasses.Valor);
            WriteLine("O valor é: " + testandoAsClasses + " Agora convertido é: " + testandoAsClasses.TotalMinutes);


            TimeSpan horaQualquer = new TimeSpan(09, 10, 00);
            var calculaHoraRestante = testandoAsClasses - horaQualquer;
            WriteLine("O resultado é: " + calculaHoraRestante);
            
            TimeSpan calculandoTudo = testandoAsClasses - horaQualquer;
            WriteLine("Agora com tipo timestamp: " + calculandoTudo);

            TimeSpan var1 = new TimeSpan(10, 10, 10);
            var totalMinutoVar1 = var1.TotalMinutes;
            TimeSpan var2 = new TimeSpan(12, 12, 12);
            var totalMinutoVar2 = var2.TotalMinutes;

            var difEntreVar1eVar2 = totalMinutoVar1 - totalMinutoVar2;
            WriteLine("A diferença entre as duas horas em minutos será: " + difEntreVar1eVar2);

            TimeSpan testeDeHoras = new TimeSpan(600, 200, 300);
            WriteLine("Dias em 600h, 200min e 300seg: " + testeDeHoras.TotalDays);
            WriteLine("Horas em em 600h, 200min e 300seg: " + testeDeHoras.TotalHours);
            WriteLine("Minutos em em 600h, 200min e 300seg: " + testeDeHoras.TotalMinutes);
            WriteLine("Milissegundos em em 600h, 200min e 300seg: " + testeDeHoras.TotalMilliseconds);

            TimeSpan horaDiaria = new TimeSpan(08, 15, 00);
            WriteLine("Hora limite diária: " + horaDiaria.TotalMinutes);

            var horaLimiteDiaria = new TimeSpan(08, 15, 00).TotalMinutes;
            WriteLine("Hora Limite tentando converter: " + horaLimiteDiaria.TotalMinutes);
            


        
        }
    } 
}
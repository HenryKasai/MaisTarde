using System;

namespace MaisTarde
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime horaatual = DateTime.Now;
            string horaatualstring = horaatual.ToShortTimeString();
            DateTime acréscimo = horaatual.AddHours(6).AddMinutes(30);
            string acréscimostring = acréscimo.ToShortTimeString();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Agora é exatamente {horaatualstring}, mais tarde será {acréscimostring}.");
            Console.ForegroundColor = ConsoleColor.Gray;

        }
    }
}

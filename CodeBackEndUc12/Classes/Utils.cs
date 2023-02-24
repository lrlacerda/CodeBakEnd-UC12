using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeBackEndUc12.Classes
{
    public static class Utils
    {
        public static void BarraCarregamento(string texto)
        {
            Console.WriteLine($"{texto}");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            for (var contador = 0; contador < 5; contador++)
            {
                Console.Write($"-");
                Thread.Sleep(500);
            }
            Console.ResetColor();
        }
    }
}
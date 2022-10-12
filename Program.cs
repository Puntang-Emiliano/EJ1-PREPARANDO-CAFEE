/*Escriba por pantalla los pasos en secuencia para preparar una taza de café. Por cada paso se
debe esperar que el usuario presiones una tecla. Limpiar la pantalla al comenzar el programa.*/

using System;

namespace EJ1_RecetaParaPrepararCafe
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.ForegroundColor = ConsoleColor.DarkBlue;

        Console.WriteLine("-------BIENBENIDO AL SISTEMA-------");
        Console.WriteLine("Si desea preparar cafe siga los siguientes pasos: ");
        Console.WriteLine("1) ---Ponga el agua a calentar.");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("2) ----Agregue el cafe en la tasa.");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("3) ----Agregar el agua caliente en la tasa.");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("4) ----Endulzar a gusto.");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("5) ----Sientese a disfrutas de su cafe.");
        Console.ReadKey();
        Console.Clear();

           







        }
    }
}

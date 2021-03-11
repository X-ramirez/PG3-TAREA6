using System;

namespace Hello_Word
{
    class Program
    {
        static void Main(string[] args)
        {

            int loop = 1;
            int veces = 0;
            int choice;

            while (loop == 1)
            {
                Console.WriteLine("Hello World, yo soy Alan, Xiolin, y Deriam.");
                veces= veces + 1;
                Console.WriteLine("La cantidad de veces que se ha dicho hola mundo es: " + veces);
                Console.WriteLine("Desea repetir una vez mas?");
                Console.WriteLine("1: Si");
                Console.WriteLine("2: No");
                choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Repitiendo una vez mas...");
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Dejando de repetir...");
                    loop = 0;
                }
                else
                {
                    Console.WriteLine("Valor erroneo, repitiendo otra vez...");
                }
            }

        }
    }
}

using System;

namespace aula1302
{
    class Program
    {
        // Tipos Contador
        static void Main(string[] args)
        {
            int contador = 0;
            do
            {
                Console.WriteLine($" O contador esta em: {contador}");
                contador++;
            } while( contador < 10 );


            //int contador = 0;
            //while (contador < 10)
            //{
            //    Console.WriteLine($" O contador esta: { contador}");
            //    contador++;
            //}


            //for (int contador = 0; contador < 10; contador++)
            //{
            //    Console.WriteLine($"contador esta {contador}");
            //}


        }
    }
}

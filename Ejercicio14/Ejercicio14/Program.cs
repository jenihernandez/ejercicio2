// Elabora un algoritmo que imprima los números del 1 al 100. Que calcule la suma de todos los
// números pares por un lado, y por otro, la de todos los impares.


using System;

class Program
{
    static void Main(string[] args)
    {
        int sumPares = 0;
        int sumImpares = 0;

        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine(i);

            if (i % 2 == 0)
            {
                sumPares += i;
            }
            else
            {
                sumImpares += i;
            }
        }

        Console.WriteLine("Suma de los números pares: " + sumPares);
        Console.WriteLine("Suma de los números impares: " + sumImpares);
    }
}
    }
}

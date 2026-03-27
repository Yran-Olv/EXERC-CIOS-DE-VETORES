using System;

namespace EXERCÍCIOS_DE_VETORES
{
    internal static class Analyze20
    {
        internal static void Run()
        {
            Console.WriteLine("Análises em vetor de 20 posições");
            var v = InputHelper.ReadIntArray(20, "v");
            int pares = 0, impares = 0, maior50 = 0, menor7 = 0;
            foreach (var x in v)
            {
                if (x % 2 == 0) pares++; else impares++;
                if (x > 50) maior50++;
                if (x < 7) menor7++;
            }
            Console.WriteLine($"Números pares: {pares}");
            Console.WriteLine($"Números ímpares: {impares}");
            Console.WriteLine($"Números maiores que 50: {maior50}");
            Console.WriteLine($"Números menores que 7: {menor7}");
        }
    }
}

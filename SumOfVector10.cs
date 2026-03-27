using System;

namespace EXERCÍCIOS_DE_VETORES
{
    internal static class SumOfVector10
    {
        internal static void Run()
        {
            Console.WriteLine("Somatório de 10 números");
            var v = InputHelper.ReadIntArray(10, "v");
            long sum = 0;
            foreach (var x in v) sum += x;
            Console.WriteLine($"Somatório: {sum}");
        }
    }
}

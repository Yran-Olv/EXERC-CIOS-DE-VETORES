using System;

namespace EXERCÍCIOS_DE_VETORES
{
    internal static class SumVectors10
    {
        internal static void Run()
        {
            Console.WriteLine("Soma de dois vetores (10)");
            Console.WriteLine("Preencha o primeiro vetor:");
            var a = InputHelper.ReadIntArray(10, "a");
            Console.WriteLine("Preencha o segundo vetor:");
            var b = InputHelper.ReadIntArray(10, "b");
            var c = new int[10];
            for (int i = 0; i < 10; i++) c[i] = a[i] + b[i];
            InputHelper.PrintVector(c, "Vetor resultante");
        }
    }
}

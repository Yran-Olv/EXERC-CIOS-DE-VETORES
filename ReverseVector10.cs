using System;

namespace EXERCÍCIOS_DE_VETORES
{
    internal static class ReverseVector10
    {
        internal static void Run()
        {
            Console.WriteLine("Trocar primeiro/último, segundo/penúltimo (10)");
            var v = InputHelper.ReadIntArray(10, "v");
            InputHelper.PrintVector(v, "Vetor original");
            int n = v.Length;
            for (int i = 0; i < n / 2; i++)
            {
                var tmp = v[i];
                v[i] = v[n - 1 - i];
                v[n - 1 - i] = tmp;
            }
            InputHelper.PrintVector(v, "Vetor após troca");
        }
    }
}

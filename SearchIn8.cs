using System;

namespace EXERCÍCIOS_DE_VETORES
{
    internal static class SearchIn8
    {
        internal static void Run()
        {
            Console.WriteLine("Buscar valor em vetor de 8 posições");
            var v = InputHelper.ReadIntArray(8, "v");
            int target = InputHelper.ReadInt("Valor a buscar: ");
            int idx = Array.IndexOf(v, target);
            if (idx >= 0)
                Console.WriteLine($"O número está na posição {idx} (índice zero-based) -> posição {idx + 1}");
            else
                Console.WriteLine("O número não se encontra no vetor");
        }
    }
}

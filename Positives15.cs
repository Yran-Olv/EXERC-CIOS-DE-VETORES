using System;

namespace EXERCÍCIOS_DE_VETORES
{
    internal static class Positives15
    {
        internal static void Run()
        {
            Console.WriteLine("Mostrar somente números positivos (15)");
            var v = InputHelper.ReadIntArray(15, "v");
            Console.WriteLine("Números positivos:");
            bool any = false;
            foreach (var x in v)
            {
                if (x > 0) { Console.WriteLine(x); any = true; }
            }
            if (!any) Console.WriteLine("Nenhum número positivo encontrado.");
        }
    }
}

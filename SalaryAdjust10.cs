using System;

namespace EXERCÍCIOS_DE_VETORES
{
    internal static class SalaryAdjust10
    {
        internal static void Run()
        {
            Console.WriteLine("Reajustar salários de 10 funcionários (5%)");
            var s = InputHelper.ReadDoubleArray(10, "salario");
            Console.WriteLine("Salários reajustados:");
            for (int i = 0; i < s.Length; i++)
            {
                var novo = s[i] * 1.05;
                Console.WriteLine($"Funcionario {i + 1}: {s[i]:F2} -> {novo:F2}");
            }
        }
    }
}

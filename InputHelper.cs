using System;
using System.Globalization;

namespace EXERCÍCIOS_DE_VETORES
{
    internal static class InputHelper
    {
        public static int ReadInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                var s = Console.ReadLine();
                if (int.TryParse(s, NumberStyles.Integer, CultureInfo.CurrentCulture, out int v)) return v;
                if (int.TryParse(s, NumberStyles.Integer, CultureInfo.InvariantCulture, out v)) return v;
                Console.WriteLine("Entrada inválida. Tente novamente.");
            }
        }

        public static double ReadDouble(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                var s = Console.ReadLine();
                if (double.TryParse(s, NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.CurrentCulture, out double v)) return v;
                if (double.TryParse(s, NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out v)) return v;
                Console.WriteLine("Entrada inválida. Tente novamente.");
            }
        }

        public static int[] ReadIntArray(int length, string name = "vetor")
        {
            var arr = new int[length];
            for (int i = 0; i < length; i++) arr[i] = ReadInt($"{name}[{i}] = ");
            return arr;
        }

        public static double[] ReadDoubleArray(int length, string name = "salario")
        {
            var arr = new double[length];
            for (int i = 0; i < length; i++) arr[i] = ReadDouble($"{name}[{i}] = ");
            return arr;
        }

        public static void PrintVector(int[] v, string label = "Vetor")
        {
            Console.WriteLine(label + ":");
            for (int i = 0; i < v.Length; i++) Console.WriteLine($"[{i}] = {v[i]}");
        }

        public static void PrintVector(double[] v, string label = "Vetor")
        {
            Console.WriteLine(label + ":");
            for (int i = 0; i < v.Length; i++) Console.WriteLine($"[{i}] = {v[i]:F2}");
        }
    }
}

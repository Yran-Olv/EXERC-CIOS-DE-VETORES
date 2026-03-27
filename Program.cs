namespace EXERCÍCIOS_DE_VETORES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("VETORES - Exercícios (selecione uma opção):");
                Console.WriteLine("1 - Somatório de 10 números");
                Console.WriteLine("2 - Mostrar somente positivos (15)");
                Console.WriteLine("3 - Buscar valor em vetor (8)");
                Console.WriteLine("4 - Somar dois vetores (10)");
                Console.WriteLine("5 - Análises em vetor (20)");
                Console.WriteLine("6 - Reajustar salários (10)");
                Console.WriteLine("7 - Trocar primeiro/último, segundo/penúltimo (10)");
                Console.WriteLine("0 - Sair");
                Console.Write("Opção: ");
                var opt = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(opt)) continue;
                if (!int.TryParse(opt, out int opc)) continue;
                Console.WriteLine();
                switch (opc)
                {
                    case 0: return;
                    case 1: SumOfVector10.Run(); break;
                    case 2: Positives15.Run(); break;
                    case 3: SearchIn8.Run(); break;
                    case 4: SumVectors10.Run(); break;
                    case 5: Analyze20.Run(); break;
                    case 6: SalaryAdjust10.Run(); break;
                    case 7: ReverseVector10.Run(); break;
                    default: Console.WriteLine("Opção inválida"); break;
                }
                Console.WriteLine();
                Console.WriteLine("Pressione Enter para retornar ao menu...");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}

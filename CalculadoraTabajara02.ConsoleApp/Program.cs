namespace CalculadoraTabajara02.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcao;

            List<String> operacoes = new List<string>();

            while (true)
            {
                #region Menu Principal

                Console.Clear();

                Console.WriteLine("Calculadora Tabajara 1.0\n");

                Console.WriteLine("Tela Principal\n");

                Console.WriteLine("Digite 1 para Adição\n");

                Console.WriteLine("Digite 2 para Subtração\n");

                Console.WriteLine("Digite 3 para Multiplicação\n");

                Console.WriteLine("Digite 4 para Divisão\n");

                Console.WriteLine("Digite 5 para Visualizar as operações\n");

                Console.WriteLine("Digite S para sair\n");

                Console.Write("Opção: ");
                opcao = Console.ReadLine();

                if (opcao.Equals("s", StringComparison.OrdinalIgnoreCase))
                    break;

                if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "5")
                {
                    Console.WriteLine("Você precisa digitar uma opção válida!");
                    Console.ReadLine();
                    continue;
                }

                #endregion
            }
        }
    }
}
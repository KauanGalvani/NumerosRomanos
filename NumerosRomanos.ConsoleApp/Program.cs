namespace NumerosRomanos.ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("========================");
            Console.WriteLine("=    Nuemros Romanos   =");
            Console.WriteLine("========================");
            Console.WriteLine();

            Console.WriteLine("Digite um numero");
            int entradaDoUsuario = Convert.ToInt32(Console.ReadLine());
            // Console.Clear();

            string valorApresentacao = DecisaoNumeros.ApresentacaoDecisao(entradaDoUsuario);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=====================");
            Console.WriteLine(valorApresentacao);
            Console.WriteLine("=====================");
            Console.ResetColor();

            Console.WriteLine();
            Console.WriteLine($"Numero digitado {entradaDoUsuario}");

            Console.ReadLine();
            // Console.Clear();

        }
    }
}

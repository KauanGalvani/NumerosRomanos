namespace NumerosRomanos.ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("1 - Converter numero Arabico para Romano");
            Console.WriteLine("2 - Converter Romano para Arabico");
            Console.WriteLine("========================================");
            Console.WriteLine("");

            string? escolhaUsuario = Console.ReadLine();

            if (escolhaUsuario == "1")
                ApresentacaoParaRomano.TelaParaRomano();
            // else if (escolhaUsuario == "2")
            //     ApresentascaoParaArabico.TelaParaArabico();
        }
    }
}

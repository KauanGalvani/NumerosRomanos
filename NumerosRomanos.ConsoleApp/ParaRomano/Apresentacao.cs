namespace NumerosRomanos.ConsoleApp;

static class ApresentacaoParaRomano
{
    public static string ApresentacaoDecisao(int entradaDoUsuario)
    {
        if (entradaDoUsuario >= 1 && entradaDoUsuario <= 10)
        {
            string valorDeRomano = VerificarNumeros.NumerosInteiros(entradaDoUsuario);
            return valorDeRomano;
        }

        else if (entradaDoUsuario >= 11 && entradaDoUsuario <= 19)
        {
            string valorDeRomano = VerificarNumeros.VerificarNumerosTeen(entradaDoUsuario);
            return valorDeRomano;
        }

        else if (entradaDoUsuario % 10 == 0 && entradaDoUsuario <= 90)
        {
            string valorDeRomano = VerificarNumeros.Verificardezenas(entradaDoUsuario);
            return valorDeRomano;
        }

        else if (entradaDoUsuario % 100 == 0 && entradaDoUsuario <= 900)
        {
            string valorDeRomano = VerificarNumeros.VerificarCentenas(entradaDoUsuario);
            return valorDeRomano;
        }

        else if (entradaDoUsuario % 1000 == 0 && entradaDoUsuario <= 4000)
        {
            string valorDeRomano = VerificarNumeros.VerificarMilhar(entradaDoUsuario);
            return valorDeRomano;
        }

        else if (entradaDoUsuario % 10 != 0 && entradaDoUsuario <= 99)
        {
            string valorRomano = SepararValor.SeparandoDezena(entradaDoUsuario);
            return valorRomano;
        }

        else if (entradaDoUsuario % 100 != 0 && entradaDoUsuario <= 999)
        {
            string valorRomano = SepararValor.SeparandoCentena(entradaDoUsuario);
            return valorRomano;
        }

        else if (entradaDoUsuario % 1000 != 0 && entradaDoUsuario <= 3999)
        {
            string valorRomano = SepararValor.SeparandoMilhar(entradaDoUsuario);
            return valorRomano;
        }

        return "O numero não é valido";
    }

    public static void Cabeçalho()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("============");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("============");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("=    Nuemros");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(" Romanos   =");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("============");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("============");
        Console.ResetColor();

        Console.WriteLine("Digite um numero");
        Console.Write(">> ");
    }

    public static void TelaParaRomano()
    {
        while (true)
        {
            Cabeçalho();

            int entradaDoUsuario = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            string valorApresentacao = ApresentacaoParaRomano.ApresentacaoDecisao(entradaDoUsuario);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=====================");
            Console.WriteLine(valorApresentacao);
            Console.WriteLine("=====================");
            Console.ResetColor();

            Console.WriteLine();
            Console.WriteLine($"Numero digitado {entradaDoUsuario}");

            Console.WriteLine("Deseja Continuar? [S/N]");
            string? devContinuar = Console.ReadLine()?.ToUpper();

            if (devContinuar != "S")
                break;

            Console.Clear();


        }
    }
}

namespace NumerosRomanos.ConsoleApp;

static class VerificarNumeros
{
    public static string NumerosInteiros(int valorEntrada)
    {
        Dictionary<int, string> convertendoParaRomano = new Dictionary<int, string>()
        {
            {0, ""},
            {1, "I"},
            {2, "II"},
            {3, "III"},
            {4, "IV"},
            {5, "V"},
            {6, "VI"},
            {7, "VII"},
            {8, "VIII"},
            {9, "IX"},
            {10, "X"}
        };

        // convertendoParaRomano.TryGetValue(); Fazer a validação apos finalizar o exercicio 

        string valor = convertendoParaRomano[(valorEntrada)];
        return valor;
    }

    public static string VerificarNumerosTeen(int valorEntrada)
    {
        Dictionary<int, string> convertendoParaRomano = new Dictionary<int, string>()
        {
            {0, ""},
            {11, "XI"},
            {12, "XII"},
            {13, "XIII"},
            {14, "XIV"},
            {15, "XV"},
            {16, "XVI"},
            {17, "XVII"},
            {18, "XVIII"},
            {19, "XIX"},
        };

        string valor = convertendoParaRomano[(valorEntrada)];
        return valor;
    }

    public static string Verificardezenas(int valorEntrada)
    {
        Dictionary<int, string> convertendoParaRomano = new Dictionary<int, string>()
        {
            {0, ""},
            {20, "XX"},
            {30, "XXX"},
            {40, "XL"},
            {50, "L"},
            {60, "LX"},
            {70, "LXX"},
            {80, "LXXX"},
            {90, "XC"},
        };

        string valor = convertendoParaRomano[(valorEntrada)];
        return valor;
    }

    public static string VerificarCentenas(int valorEntrada)
    {
        Dictionary<int, string> convertendoParaRomano = new Dictionary<int, string>()
        {
            {0, ""},
            {100, "C"},
            {200, "CC"},
            {300, "CCC"},
            {400, "CD"},
            {500, "D"},
            {600, "DC"},
            {700, "DCC"},
            {800, "DCCC"},
            {900, "CM"}
        };

        string valor = convertendoParaRomano[(valorEntrada)];
        return valor;
    }

    public static string VerificarMilhar(int valorEntrada)
    {
        Dictionary<int, string> convertendoParaRomano = new Dictionary<int, string>()
        {
            {0, ""},
            {1000, "M"},
            {2000, "MM"},
            {3000, "MMM"},
            {4000, "MMMM"},
        };

        string valor = convertendoParaRomano[(valorEntrada)];
        return valor;
    }
}
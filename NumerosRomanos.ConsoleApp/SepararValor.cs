namespace NumerosRomanos.ConsoleApp;

public static class SepararValor
{
    public static string SeparandoDezena(int valorEntrada)
    {
        decimal valorDezena = Convert.ToDecimal(valorEntrada) / 10m;

        int valorinteiro = (int)((valorDezena * 10) % 10); // Valor de interio

        int valorDeDezena = valorEntrada - valorinteiro; // Valor Dezena

        string valor1 = VerificarNumeros.Verificardezenas(valorDeDezena);

        string valor2 = VerificarNumeros.NumerosInteiros(valorinteiro);

        return ($"{valor1}{valor2}");
    }

    public static string SeparandoCentena(int valorEntrada)
    {
        decimal valordivisao = Convert.ToDecimal(valorEntrada) / 100m;

        int valorDesena = (int)((valordivisao * 100) % 100); // valor de desena

        int valorCentena = valorEntrada - valorDesena;


        string valor1 = VerificarNumeros.VerificarCentenas(valorCentena);
        string valor2;

        if (valorDesena >= 11 && valorDesena <= 19)
        {
            valor2 = VerificarNumeros.VerificarNumerosTeen(valorDesena);
            return ($"{valor1}{valor2}");
        }

        valor2 = SeparandoDezena(valorDesena);
        return ($"{valor1}{valor2}");
    }

    public static string SeparandoMilhar(int valorEntrada)
    {
        decimal valordivisao = Convert.ToDecimal(valorEntrada) / 1000m;

        int valorCentena = (int)((valordivisao * 1000) % 1000); // valor de Centena

        int valorMilhar = valorEntrada - valorCentena;

        string valor1 = VerificarNumeros.VerificarMilhar(valorMilhar);
        string valor2 = SeparandoCentena(valorCentena);

        return ($"{valor1}{valor2}");
    }
}



namespace DiamanteX.ConsoleApp;

public class DiamanteX
{
    public static string[] GerarDiamanteCompleto(int tamanho)
    {
        string[] diamanteSuperior = GerarDiamanteSuperior(tamanho);

        string[] diamanteMeio = GerarDiamanteMeio(tamanho);

        string[] diamanteInferior = GerarDiamanteInferior(tamanho);

        string[] resultado = diamanteSuperior.Concat(diamanteMeio).Concat(diamanteInferior).ToArray();

        return resultado;
    }

    public static string[] GerarDiamanteSuperior(int tamanho)
    {
        int linhasDiamante = tamanho / 2;

        string[] resultado = new string[linhasDiamante];

        for (int i = 0; i < linhasDiamante; i++)
        {
            string espacoDiamante = new string(' ', linhasDiamante - i);

            string diamanteSuperior = new string('*', i * 2 + 1);

            resultado[i] = espacoDiamante + diamanteSuperior;
        }

        return resultado;
    }

    public static string[] GerarDiamanteMeio(int tamanho)
    {
        string diamanteMeio = new string('*', tamanho);
        string[] resultado = [diamanteMeio];
        return resultado;
    }

    public static string[] GerarDiamanteInferior(int tamanho)
    {
        int linhasDiamante = tamanho / 2;

        string[] resultado = new string[linhasDiamante];

        for (int i = 0; i < linhasDiamante; i++)
        {
            string espacoDiamante = new string(' ', i + 1);

            string diamanteInferior = new string('*', (linhasDiamante - i - 1) * 2 + 1);

            resultado[i] = espacoDiamante + diamanteInferior;
        }

        return resultado;
    }
}

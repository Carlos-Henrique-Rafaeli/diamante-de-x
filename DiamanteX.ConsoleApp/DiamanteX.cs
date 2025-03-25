namespace DiamanteX.ConsoleApp;

public class DiamanteX
{
    public static void GerarDiamanteCompleto(int tamanho)
    {
        GerarDiamanteSuperior(tamanho);
        GerarDiamanteInferior(tamanho);
    }

    public static void GerarDiamanteSuperior(int tamanho)
    {
        int linhasDiamante = tamanho / 2;

        for (int i = 0; i < linhasDiamante; i++)
        {
            string espacoDiamante = new string(' ', linhasDiamante - i);

            string diamanteCima = new string('*', i * 2 + 1);

            Console.WriteLine(espacoDiamante + diamanteCima);
        }

    }

    public static void GerarDiamanteInferior(int tamanho)
    {
        int linhasDiamante = tamanho / 2;

        for (int i = linhasDiamante; i >= 0; i--)
        {
            string espacoDiamante = new string(' ', linhasDiamante - i);

            string diamanteCima = new string('*', i * 2 + 1);

            Console.WriteLine(espacoDiamante + diamanteCima);
        }
    }
}

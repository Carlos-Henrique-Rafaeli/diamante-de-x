namespace DiamanteX.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        int tamanhoDiamante;

        while (true)
        {
            Console.Write("Digite o tamanho do diamante: ");

            bool conseguiuConverter = int.TryParse(Console.ReadLine(), out tamanhoDiamante);

            if (conseguiuConverter && tamanhoDiamante % 2 != 0)
                break;

            Console.WriteLine("\nValor Inválido\n");
        }

        int linhasDiamante = tamanhoDiamante / 2;
        
        for (int i = 0; i < linhasDiamante; i++)
        {
            string espacoDiamante = new string(' ', linhasDiamante - i);

            string diamanteCima = new string('*', i * 2 + 1);

            Console.WriteLine(espacoDiamante + diamanteCima);
        }

        for (int i = linhasDiamante; i >= 0; i--)
        {
            string espacoDiamante = new string(' ', linhasDiamante - i);

            string diamanteCima = new string('*', i * 2 + 1);

            Console.WriteLine(espacoDiamante + diamanteCima);
        }

        Console.ReadLine();
    }
}

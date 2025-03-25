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
            {
                tamanhoDiamante = Math.Abs(tamanhoDiamante);
                break;
            }

            Console.WriteLine("\nValor Inválido");
            Console.WriteLine("\nDigite um valor inteiro e ímpar!\n");
        }

        DiamanteX.GerarDiamanteCompleto(tamanhoDiamante);

        Console.ReadLine();
    }
}

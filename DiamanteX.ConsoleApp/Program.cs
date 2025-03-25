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

        string diamanteMeio = new string('*', tamanhoDiamante);

        Console.WriteLine(diamanteMeio);

        Console.ReadLine();
    }
}

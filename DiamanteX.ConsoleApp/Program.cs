namespace DiamanteX.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();

            int tamanhoDiamante = DigitarNumero();

            string[] diamante = DiamanteX.GerarDiamanteCompleto(tamanhoDiamante);

            MostrarDiamante(diamante);

            if (JogarNovamente())
                break;
        }
    }

    static void MostrarDiamante(string[] diamante)
    {
        foreach (string i in diamante)
        {
            Console.WriteLine(i);
        }
    }

    static int DigitarNumero()
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
        Console.WriteLine();
        
        return tamanhoDiamante;
    }

    static bool JogarNovamente()
    {
        Console.WriteLine("\nDeseja jogar novamente? (S/N)");
        string validacao = Console.ReadLine()!.ToUpper();

        return validacao != "S"; 
    }
}

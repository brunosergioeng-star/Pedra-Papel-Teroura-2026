namespace PedraPapelTesoura.ConsoleApp.Entidades;

public class Jogador
{
    public static int ObterEscolhaJogador()
    {
        int escolhaJogador;

        do
        {
            Console.Clear();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Pedra, Papel, Tesoura");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("1 - Pedra");
            Console.WriteLine("2 - Papel");
            Console.WriteLine("3 - Tesoura");
            Console.WriteLine("-----------------------------");

            Console.Write("Digite uma opção válida: ");
            string? strescolhaJogador = Console.ReadLine();

            if (strescolhaJogador == "1" || strescolhaJogador == "2" || strescolhaJogador == "3")
            {
                escolhaJogador = Convert.ToInt32(strescolhaJogador);
                break;
            }
            ;

        } while (true);

        return escolhaJogador;

    }
}

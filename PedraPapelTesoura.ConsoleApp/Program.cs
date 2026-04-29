using System.Security.Cryptography;

const int ESCOLHA_PEDRA = 1;
const int ESCOLHA_PAPEL = 2;
const int ESCOLHA_TESOURA = 3;

while (true)
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
        string strescolhaJogador = Console.ReadLine();

        if (strescolhaJogador == "1" || strescolhaJogador == "2" || strescolhaJogador == "3")
        {
            escolhaJogador = Convert.ToInt32(strescolhaJogador);
            break;
        }
    } while (true);

    int escolhaComputador = RandomNumberGenerator.GetInt32(1, 4);

    if (escolhaJogador == escolhaComputador)
    {
        Console.WriteLine("Empate!");
    }

    else if (escolhaJogador == ESCOLHA_PEDRA)
    {
        Console.Write("Pedra vs ");

        if (escolhaComputador == ESCOLHA_PAPEL)
        {
            Console.WriteLine("Papel");
            Console.WriteLine("O computador venceu");
        }
        else if (escolhaComputador == ESCOLHA_TESOURA)
        {
            Console.WriteLine("Tesoura");
            Console.WriteLine("Você venceu");
        }
    }

    else if (escolhaJogador == ESCOLHA_PAPEL)
    {
        Console.Write("Papel vs ");

        if (escolhaComputador == ESCOLHA_TESOURA)
        {
            Console.WriteLine("Tesoura");
            Console.WriteLine("O computador venceu");
        }
        else if (escolhaComputador == ESCOLHA_PEDRA)
        {
            Console.WriteLine("Pedra");
            Console.WriteLine("Você venceu");
        }
    }

    else if (escolhaJogador == ESCOLHA_TESOURA)
    {
        Console.Write("Tesoura vs ");

        if (escolhaComputador == ESCOLHA_PEDRA)
        {
            Console.WriteLine("Pedra");
            Console.WriteLine("O computador venceu");
        }
        else if (escolhaComputador == ESCOLHA_PAPEL)
        {
            Console.WriteLine("Papel");
            Console.WriteLine("Você venceu");
        }
    }

    Console.WriteLine("-----------------------------");
    Console.Write("Deseja continuar? (s/N): ");
    string? opcaoContinuar = Console.ReadLine().ToUpper();

    if (opcaoContinuar != "S")
        break;
}


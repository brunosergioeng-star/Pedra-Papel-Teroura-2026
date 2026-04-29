using System.Security.Cryptography;
using PedraPapelTesoura.ConsoleApp.Entidades;
namespace PedraPapelTesoura.ConsoleApp;
class Program
{
    static void Main()
    {
        while (true)
        {
            int escolhaJogador = Jogador.ObterEscolhaJogador();
            int escolhaComputador = Computador.ObterEscolhaJogadorComputador();

            Jogo.CompararEscolhas(escolhaJogador, escolhaComputador);
            
            Console.Write("Deseja continuar? (s/N): ");
            string? opcaoContinuar = Console.ReadLine().ToUpper();

            if (opcaoContinuar != "S")
                break;
        }
    }
}
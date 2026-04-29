using System.Security.Cryptography;
using System;

namespace PedraPapelTesoura.ConsoleApp.Entidades;

public static class Computador
{
    public static int ObterEscolhaJogadorComputador()
    {
        return RandomNumberGenerator.GetInt32(1, 4);
    }
}

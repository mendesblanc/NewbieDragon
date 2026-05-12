namespace NewbieDragon.UI;

using NewbieDragon.Domain.Enums;
using NewbieDragon.Strategies;

public static class Menu
{
    public static string PedirNome()
    {
        Console.Write("\n  Nome do seu heroi: ");
        string? nome = Console.ReadLine()?.Trim();
        return string.IsNullOrWhiteSpace(nome) ? "Aventureiro" : nome;
    }

    public static TipoClasse EscolherClasse()
    {
        Console.WriteLine("\n  ---- ESCOLHA A CLASSE ----");
        Console.WriteLine("  [1] Guerreiro  (d10 PV)");
        Console.WriteLine("  [2] Mago       (d4 PV)");
        Console.WriteLine("  [3] Ladrao     (d6 PV)");
        Console.Write("\n  Opcao: ");

        return Console.ReadLine()?.Trim() switch
        {
            "1" => TipoClasse.Guerreiro,
            "2" => TipoClasse.Mago,
            "3" => TipoClasse.Ladrao,
            _   => TipoClasse.Guerreiro
        };
    }

    public static IDistribuicaoStrategy EscolherDistribuicao()
    {
        Console.WriteLine("\n  ---- METODO DE ATRIBUTOS ----");
        Console.WriteLine("  [1] Dados (3d6 por atributo)");
        Console.WriteLine("  [2] Matriz (valores fixos: 16,14,13,12,10,8)");
        Console.WriteLine("  [3] Compra de Pontos (27 pontos)");
        Console.Write("\n  Opcao: ");

        return Console.ReadLine()?.Trim() switch
        {
            "1" => new DadoDistribuicao(),
            "2" => new MatrizDistribuicao(),
            "3" => new CompraDistribuicao(),
            _   => new DadoDistribuicao()
        };
    }
}

namespace NewbieDragon.UI;

using NewbieDragon.Domain.Entities;
using NewbieDragon.Domain.ValueObjects;

public static class FormatadorFicha
{
    private const int Largura = 54;

    public static void Exibir(Personagem personagem, int pontosDeVida)
    {
        string nomeClasse = personagem.GetType().Name;

        Console.WriteLine();
        Linha('=');
        CentroColorido("** FICHA DO HEROI **", ConsoleColor.Yellow);
        Linha('=');

        Campo("Nome",   personagem.Nome);
        Campo("Classe", nomeClasse);
        Campo("Nivel",  "1");
        Campo("PV",     pontosDeVida.ToString() + " pontos de vida");

        Linha('-');
        CentroColorido("ATRIBUTOS", ConsoleColor.White);
        Console.WriteLine();

        ExibirAtributo(personagem.Forca);
        ExibirAtributo(personagem.Destreza);
        ExibirAtributo(personagem.Constituicao);
        ExibirAtributo(personagem.Inteligencia);
        ExibirAtributo(personagem.Sabedoria);
        ExibirAtributo(personagem.Carisma);

        Linha('-');
        CentroColorido("HABILIDADES DA CLASSE", ConsoleColor.White);
        Console.WriteLine();

        foreach (var habilidade in personagem.Habilidades)
        {
            int sep = habilidade.IndexOf(':');
            if (sep > 0)
            {
                string titulo    = habilidade[..sep].Trim();
                string descricao = habilidade[(sep + 1)..].Trim();
                Console.Write("  > ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(titulo + ": ");
                Console.ResetColor();
                Console.WriteLine(descricao);
            }
            else
            {
                Console.WriteLine("  > " + habilidade);
            }
            Console.WriteLine();
        }

        Linha('=');
        Console.WriteLine();
    }

    private static void Campo(string rotulo, string valor)
    {
        Console.Write($"  {rotulo,-8}: ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(valor);
        Console.ResetColor();
    }

    private static void ExibirAtributo(Atributo atributo)
    {
        int mod = atributo.CalcularModificador();
        string sinal  = mod >= 0 ? "+" : "";
        string modStr = $"({sinal}{mod})";
        int blocos = (int)Math.Round((atributo.Valor - 3) / 15.0 * 12);
        string barra = "[" + new string('#', blocos) + new string('.', 12 - blocos) + "]";

        Console.Write($"  {atributo.Nome,-14} {atributo.Valor,2} {barra} ");

        ConsoleColor cor = mod > 0 ? ConsoleColor.Green
                         : mod < 0 ? ConsoleColor.Red
                         : ConsoleColor.DarkGray;
        Console.ForegroundColor = cor;
        Console.WriteLine(modStr);
        Console.ResetColor();
    }

    private static void Linha(char ch)
    {
        Console.WriteLine("  " + new string(ch, Largura));
    }

    private static void CentroColorido(string texto, ConsoleColor cor)
    {
        int pad = (Largura - texto.Length) / 2;
        Console.Write("  " + new string(' ', pad));
        Console.ForegroundColor = cor;
        Console.WriteLine(texto);
        Console.ResetColor();
    }
}

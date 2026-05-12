namespace NewbieDragon.Strategies;

public class CompraDistribuicao : IDistribuicaoStrategy
{
    public string Nome => "Compra de Pontos";

    public int[] Distribuir()
    {
        int pontosRestantes = 27;
        string[] nomes = { "Forca", "Destreza", "Constituicao", "Inteligencia", "Sabedoria", "Carisma" };
        int[] resultado = new int[6];

        Console.WriteLine($"\nVocê tem {pontosRestantes} pontos para distribuir.");
        Console.WriteLine("Cada atributo começa em 8. Gaste seus pontos para aumentá-los.");

        for (int i = 0; i < nomes.Length; i++)
        {
            Console.Write($"\nPontos restantes: {pontosRestantes} | Quanto gastar em {nomes[i]}? ");

            while (true)
            {
                string digitado = Console.ReadLine() ?? "";

                if (!int.TryParse(digitado, out int gasto))
                {
                    Console.Write("Digite apenas números: ");
                    continue;
                }

                if (gasto > pontosRestantes)
                {
                    Console.Write($"Você só tem {pontosRestantes} pontos! Tente novamente: ");
                    continue;
                }

                if (gasto < 0)
                {
                    Console.Write("Digite um valor positivo: ");
                    continue;
                }

                resultado[i] = 8 + gasto;
                pontosRestantes -= gasto;
                break;
            }
        }

        return resultado;
    }
}
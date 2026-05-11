namespace NewbieDragon.Strategies;

// Jogador recebe pontos para distribuir livremente entre os atributos
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

                // Caso 1: digitou letra em vez de número
                if (!int.TryParse(digitado, out int gasto))
                {
                    Console.Write("Digite apenas números: ");
                    continue;
                }

                // Caso 2: tentou gastar mais do que tem
                if (gasto > pontosRestantes)
                {
                    Console.Write($"Você só tem {pontosRestantes} pontos! Tente novamente: ");
                    continue;
                }

                // Caso 3: número negativo
                if (gasto < 0)
                {
                    Console.Write("Digite um valor positivo: ");
                    continue;
                }

                // Atributo começa em 8, jogador soma os pontos gastos
                resultado[i] = 8 + gasto;
                pontosRestantes -= gasto;
                break;
            }
        }

        return resultado;
    }
}
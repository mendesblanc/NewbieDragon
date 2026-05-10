namespace NewbieDragon.Strategies;

// Conjunto fixo de valores: o jogador escolhe onde colocar cada um
public class MatrizDistribuicao : IDristribuicaoStrategy
{
    public string Nome => "Matriz (valores fixos)";

    public int[] Distribuir()
    {
        List<int> disponiveis = new List<int> { 16, 14, 13, 12, 10, 8 };
        string[] nomes = { "Forca", "Destreza", "Constituicao", "Inteligencia", "Sabedoria", "Carisma" };
        int[] resultado = new int[6];

        Console.WriteLine("\nValores disponíveis: 16, 14, 13, 12, 10, 8");

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine($"\nRestantes: [{string.Join(", ", disponiveis)}]");
            Console.Write($"Valor para {nomes[i]}: ");

            while (true)
            {
                string digitado = Console.ReadLine() ?? "";

                if (!int.TryParse(digitado, out int escolha))
                {
                    Console.Write("Digite apenas números: ");
                    continue;
                }

                if (!disponiveis.Contains(escolha))
                {
                    Console.Write("Valor inválido ou já usado. Tente novamente: ");
                    continue;
                }

                resultado[i] = escolha;
                disponiveis.Remove(escolha);
                break;
            }
        }

        return resultado;
    }
}
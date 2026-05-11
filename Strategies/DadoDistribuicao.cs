namespace NewbieDragon.Strategies;

// Rola 3d6 para cada atributo e o jogador escolhe onde colocar cada valor
public class DadoDistribuicao : IDistribuicaoStrategy
{
    public string Nome => "Dados (3d6)";

    public int[] Distribuir()
    {
        Random dado = new Random();
        int[] valores = new int[6];

        for (int i = 0; i < 6; i++)
        {
            // Rola 3 dados de 6 lados e soma
            valores[i] = dado.Next(1, 7) + dado.Next(1, 7) + dado.Next(1, 7);
        }

        return valores;
    }
}
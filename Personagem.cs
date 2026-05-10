public abstract class Personagem
{
    public string Nome = "";
    public int Forca;
    public int Destreza;
    public int Constituicao;
    public int Inteligencia;
    public int Sabedoria;
    public int Carisma;
    public int CA;
    public int JogadaDeProtecao;

    public List<string> Habilidades = new List<string>();

    // Cada classe filha calcula PV do seu jeito
    public abstract int CalcularPV();

    // Rola 3 dados de 6 lados e soma, repetindo 6 vezes (um por atributo)
    // Retorna um array com 6 valores entre 3 e 18
    public static int[] RolarAtributos()
    {
        Random dado = new Random();
        int[] valores = new int[6];

        for (int i = 0; i < 6; i++)
        {
            // Next(1, 7) sorteia 1, 2, 3, 4, 5 ou 6 — o 7 é a parede, nunca sai
            valores[i] = dado.Next(1, 7) + dado.Next(1, 7) + dado.Next(1, 7);
        }

        return valores;
    }

    // Mostra cada valor sorteado e pede ao jogador onde quer colocar
    public void DistribuirAtributos()
    {
        int[] valores = RolarAtributos();

        // Caixinha com os atributos disponíveis
        // Conforme o jogador escolhe, o atributo some da lista
        List<string> atributosDisponiveis = new List<string>
        {
            "Forca", "Destreza", "Constituicao",
            "Inteligencia", "Sabedoria", "Carisma"
        };

        // Para cada valor sorteado, o jogador escolhe onde colocar
        foreach (int valor in valores)
        {
            Console.WriteLine($"\nValor sorteado: {valor}");
            Console.WriteLine("Escolha o atributo:");

            // Mostra apenas os atributos que ainda não foram preenchidos
            // +1 porque o jogador vê de 1 a 6, mas o array começa em 0
            for (int i = 0; i < atributosDisponiveis.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {atributosDisponiveis[i]}");
            }

            int escolha;

            // Fica repetindo até o jogador digitar algo válido
            while (true)
            {
                Console.Write("> ");
                string digitado = Console.ReadLine() ?? "";

                // Caso 1: digitou letra em vez de número
                if (!int.TryParse(digitado, out escolha))
                {
                    Console.WriteLine("Digite apenas números!");
                    continue;
                }

                // Ajusta para o índice do array (jogador vê 1 a 6, array começa em 0)
                escolha = escolha - 1;

                // Caso 2 e 3: número fora do intervalo válido
                if (escolha < 0 || escolha >= atributosDisponiveis.Count)
                {
                    Console.WriteLine($"Digite um número entre 1 e {atributosDisponiveis.Count}!");
                    continue;
                }

                // Chegou aqui significa que a escolha é válida, sai do loop
                break;
            }

            string atributoEscolhido = atributosDisponiveis[escolha];

            // Atribui o valor ao atributo escolhido
            switch (atributoEscolhido)
            {
                case "Forca":        Forca        = valor; break;
                case "Destreza":     Destreza     = valor; break;
                case "Constituicao": Constituicao = valor; break;
                case "Inteligencia": Inteligencia = valor; break;
                case "Sabedoria":    Sabedoria    = valor; break;
                case "Carisma":      Carisma      = valor; break;
            }

            // Remove o atributo já escolhido para não aparecer novamente
            atributosDisponiveis.Remove(atributoEscolhido);
        }
    }
}
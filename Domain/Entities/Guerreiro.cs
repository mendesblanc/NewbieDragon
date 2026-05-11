namespace NewbieDragon.Domain.Entities;

public class Guerreiro : Personagem
{
    public Guerreiro()
    {
        CA = 15;
        JogadaDeProtecao = 4;
        Habilidades = new List<string>
        {
            "Aparar: pode tentar reduzir o dano de um ataque recebido.",
            "Maestria em Espada Longa: possui treinamento especial com espada longa.",
            "Maestria em Machado de Batalha: possui treinamento especial com machado de batalha."
        };
    }

    public override int CalcularPV()
    {
        Random dado = new Random();
        int rolagem = dado.Next(1, 10);
        return Math.Max(1, rolagem + Constituicao.CalcularModificador());
    }
}
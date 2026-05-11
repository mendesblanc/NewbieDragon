namespace NewbieDragon.Domain.Entities;

public class Ladrao : Personagem
{
    public Ladrao()
    {
        CA = 14;
        JogadaDeProtecao = 6;
        Habilidades = new List<string>
        {
            "Ataque Furtivo: causa dano extra ao atacar um inimigo desprevenido.",
            "Talentos de Ladrão: habilidades especiais como furtar bolsos e abrir fechaduras.",
            "Ouvir Ruídos: consegue detectar sons suspeitos em portas e paredes."
        };
    }

    public override int CalcularPV()
    {
        Random dado = new Random();
        int rolagem = dado.Next(1, 7);
        return Math.Max(1, rolagem + Constituicao.CalcularModificador());
    }
}
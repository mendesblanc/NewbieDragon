namespace NewbieDragon.Domain.Entities;

public class Mago : Personagem
{
    public Mago()
    {
        CA = 10;
        JogadaDeProtecao = 8;
        Habilidades = new List<string>
        {
            "Magias Arcanas: pode conjurar magias escritas em seu grimório.",
            "Ler Magias: consegue ler e identificar pergaminhos mágicos.",
            "Detectar Magias: consegue detectar a presença de magia ao redor."
        };
    }

    public override int CalcularPV()
    {
        Random dado = new Random();
        int rolagem = dado.Next(1, 5);
        return Math.Max(1, rolagem + Constituicao.CalcularModificador());
    }
}
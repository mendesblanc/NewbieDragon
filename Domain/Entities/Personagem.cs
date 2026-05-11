namespace NewbieDragon.Domain.Entities;

using NewbieDragon.Domain.ValueObjects;

public abstract class Personagem
{
    public string Nome = "";
    public int CA;
    public int JogadaDeProtecao;
    public List<string> Habilidades = new List<string>();

    // Atributos usando a classe Atributo
    public Atributo Forca = new Atributo("Forca", 10);
    public Atributo Destreza = new Atributo("Destreza", 10);
    public Atributo Constituicao = new Atributo("Constituicao", 10);
    public Atributo Inteligencia = new Atributo("Inteligencia", 10);
    public Atributo Sabedoria = new Atributo("Sabedoria", 10);
    public Atributo Carisma = new Atributo("Carisma", 10);

    // Cada classe filha calcula PV usando seu dado de vida + mod de CON
    public abstract int CalcularPV();

    // Recebe os valores da Strategy e aplica nos atributos
    public void AplicarAtributos(int[] valores)
    {
        Forca.Valor = Math.Clamp(valores[0], 3, 18);
        Destreza.Valor = Math.Clamp(valores[1], 3, 18);
        Constituicao.Valor = Math.Clamp(valores[2], 3, 18);
        Inteligencia.Valor = Math.Clamp(valores[3], 3, 18);
        Sabedoria.Valor = Math.Clamp(valores[4], 3, 18);
        Carisma.Valor = Math.Clamp(valores[5], 3, 18);
    }
}
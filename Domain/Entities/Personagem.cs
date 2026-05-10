namespace NewbieDragon.Domain.Entities;

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
}
namespace NewbieDragon.Strategies;

public interface IDistribuicaoStrategy 
{
    string Nome { get; }
    int[] Distribuir();
}
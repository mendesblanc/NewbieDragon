namespace NewbieDragon.Strategies;

public interface IDristribuicaoStrategy
{
    string Nome { get; }
    int[] Distribuir();
}
namespace NewbieDragon.Domain.ValueObjects;

public class Atributo
{
    public string Nome;
    public int Valor;

    public Atributo(string nome, int valor)
    {
        Nome = nome;
        Valor = Math.Clamp(valor, 3, 18);
    }

    public int CalcularModificador()
    {
        if (Valor == 3)  return -3;
        if (Valor <= 5)  return -2;
        if (Valor <= 8)  return -1;
        if (Valor <= 12) return  0;
        if (Valor <= 15) return +1;
        if (Valor <= 17) return +2;
        return                  +3;
    }

    public override string ToString()
    {
        string sinal = CalcularModificador() >= 0 ? "+" : "";
        return $"{Nome}: {Valor} ({sinal}{CalcularModificador()})";
    }
}
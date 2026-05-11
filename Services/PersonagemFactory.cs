namespace NewbieDragon.Services;

using NewbieDragon.Domain.Entities;
using NewbieDragon.Domain.Enums;

public static class PersonagemFactory
{
    public static Personagem Criar(TipoClasse tipo)
    {
        return tipo switch
        {
            TipoClasse.Guerreiro => new Guerreiro(),
            TipoClasse.Mago => new Mago(),
            TipoClasse.Ladrao => new Ladrao(),
            _ => throw new ArgumentException("Classe inválida")
        };
    }
}
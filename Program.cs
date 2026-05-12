using NewbieDragon.Services;
using NewbieDragon.UI;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("\n  === OLD DRAGON — CRIADOR DE PERSONAGEM ===\n");

string nome                  = Menu.PedirNome();
var tipoClasse               = Menu.EscolherClasse();
var estrategiaDistribuicao   = Menu.EscolherDistribuicao();

var personagem = PersonagemFactory.Criar(tipoClasse);
personagem.Nome = nome;

int[] valoresAtributos = estrategiaDistribuicao.Distribuir();
personagem.AplicarAtributos(valoresAtributos);

int pontosDeVida = personagem.CalcularPV();

FormatadorFicha.Exibir(personagem, pontosDeVida);

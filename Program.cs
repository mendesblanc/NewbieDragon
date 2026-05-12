using NewbieDragon.Services;
using NewbieDragon.UI;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("\n  === OLD DRAGON — CRIADOR DE PERSONAGEM ===\n");

// 1. Coleta dados via Menu
string nome                  = Menu.PedirNome();
var tipoClasse               = Menu.EscolherClasse();
var estrategiaDistribuicao   = Menu.EscolherDistribuicao();

// 2. Cria personagem pela Factory
var personagem = PersonagemFactory.Criar(tipoClasse);
personagem.Nome = nome;

// 3. Distribui atributos pela Strategy escolhida
int[] valoresAtributos = estrategiaDistribuicao.Distribuir();
personagem.AplicarAtributos(valoresAtributos);

// 4. Calcula PV (dado de vida da classe + mod de Constituicao)
int pontosDeVida = personagem.CalcularPV();

// 5. Exibe a ficha formatada
FormatadorFicha.Exibir(personagem, pontosDeVida);

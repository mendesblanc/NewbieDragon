using NewbieDragon.Strategies;

string[] nomes = { "Forca", "Destreza", "Constituicao", "Inteligencia", "Sabedoria", "Carisma" };

// Testa Dados
Console.WriteLine("=== TESTE: Distribuição por Dados ===");
var dados = new DadoDistribuicao();
int[] valoresDados = dados.Distribuir();
Console.WriteLine("\nResultado final:");
for (int i = 0; i < 6; i++)
    Console.WriteLine($"  {nomes[i]}: {valoresDados[i]}");

// Testa Matriz
Console.WriteLine("\n=== TESTE: Distribuição por Matriz ===");
var matriz = new MatrizDistribuicao();
int[] valoresMatriz = matriz.Distribuir();
Console.WriteLine("\nResultado final:");
for (int i = 0; i < 6; i++)
    Console.WriteLine($"  {nomes[i]}: {valoresMatriz[i]}");

// Testa Compra
Console.WriteLine("\n=== TESTE: Distribuição por Compra de Pontos ===");
var compra = new CompraDistribuicao();
int[] valoresCompra = compra.Distribuir();
Console.WriteLine("\nResultado final:");
for (int i = 0; i < 6; i++)
    Console.WriteLine($"  {nomes[i]}: {valoresCompra[i]}");
using NewbieDragon.Strategies;

// Testa Dados
Console.WriteLine("=== TESTE: Distribuição por Dados ===");
var dados = new DadoDistribuicao();
int[] valoresDados = dados.Distribuir();
Console.WriteLine("Valores gerados: " + string.Join(", ", valoresDados));

// Testa Matriz
Console.WriteLine("\n=== TESTE: Distribuição por Matriz ===");
var matriz = new MatrizDistribuicao();
int[] valoresMatriz = matriz.Distribuir();
Console.WriteLine("Valores gerados: " + string.Join(", ", valoresMatriz));
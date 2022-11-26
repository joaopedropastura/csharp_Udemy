double? x = null;
double? y = 10.0;


// usando o "?" na criacao da variavel nos permite
//usar as funcoes:
// GetValueOrDefault() retornando o valor ou 0 para default
// Hasvalue retorna um bool dizendo se ha ou n valores atribuidos a variavel

Console.WriteLine(x.GetValueOrDefault());
Console.WriteLine(y.GetValueOrDefault());

var temp = x.HasValue ? x.Value : 0.3;

Console.WriteLine(temp);
Console.WriteLine(x.HasValue);
Console.WriteLine(y.HasValue);
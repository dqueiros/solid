using Solid.LSP.Violacao2.LSP_Violacao;

var numeros = new int[] { 5, 7, 9, 8, 1, 6, 4 };

CalculaSoma somaNumeros = new CalculaSoma(numeros);
Console.WriteLine($"\nA soma dos números é : {somaNumeros.Calcular()}");

CalculaSomaNumerosPares somaPares = new CalculaSomaNumerosPares(numeros);
Console.WriteLine($"\nA soma dos números pares é : {somaPares.Calcular()}");

//Substituindo a instância da classe base
//por uma instância de classe derivada
CalculaSoma soma = new CalculaSomaNumerosPares(numeros);
Console.WriteLine($"\nA soma dos números é : {soma.Calcular()}");


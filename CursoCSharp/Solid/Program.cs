using Solid.LSP.Violacao2.LSP_Aderente;

var numeros = new int[] { 5, 7, 9, 8, 1, 6, 4 };

Calculadora somaNumeros = new CalculaSoma(numeros);
Console.WriteLine($"\nA soma dos números é : {somaNumeros.Calcular()}");

Calculadora somaPares = new  CalculaSomaNumerosPares(numeros);
Console.WriteLine($"\nA soma dos números Pares é : {somaPares.Calcular()}");


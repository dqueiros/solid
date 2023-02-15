using Solid.LSP.Violacao1.LSP_Violacao;

Funcionario func1 = new Gerente("Paulo", "Cargo");
Console.WriteLine(func1.GetType());

Funcionario func2 = new Vendedor("Paulo", "Cargo");
Console.WriteLine(func2.GetType());

Console.WriteLine("Salário do Gerente");
var sal1 = func1.CalculaSalario(5000);
Console.WriteLine(sal1);

Console.WriteLine("Salário do Vendedor");
var sal2 = func2.CalculaSalario(3000);
Console.WriteLine(sal2);




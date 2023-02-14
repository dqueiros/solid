using Solid.OCP.OPC_Violacao;

Produto produto1 = new Produto(
    1,
    "Caneta",
    "Caneta Esferográfica azul",
    2.00M,
    3.40M,
    100,
    true);

Console.WriteLine($"{produto1.Nome} Lucro = {produto1.MargemLucro()}");




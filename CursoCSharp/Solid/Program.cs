﻿using Solid.OCP.ExtensionMethod.OCP_Aderente;
using Solid.OCP.ExtensionMethod.OCP_Aderente.Extensions;

Produto produto1 = new Produto(
    1,
    "Caneta",
    "Caneta Esferográfica azul",
    2.00M,
    3.40M,
    100,
    true);

Console.WriteLine($"Produto = {produto1.Nome} Lucro = {produto1.MargemLucro()}");




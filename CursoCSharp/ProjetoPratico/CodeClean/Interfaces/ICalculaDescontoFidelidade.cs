﻿
namespace ProjetoPratico.CodeClean.Interfaces
{
    public interface ICalculaDescontoFidelidade
    {
        decimal AplicarDescontoFidelidade(decimal preco, int tempoDeContaEmAnos);
    }
}

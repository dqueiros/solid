﻿
namespace ProjetoPratico.CodeClean;

public class GerenciadorDeDescontos
{
    public decimal AplicarDesconto(decimal precoProduto, int statusContaCliente, int tempoDeContasEmAnos)
    {
        decimal precoAposDesconto = 0;

        decimal descontoPorFidelidade = (tempoDeContasEmAnos > 5) ? 
            (decimal)5 / 100 : 
            (decimal)tempoDeContasEmAnos / 100;
        
        if (statusContaCliente == 1)
        {
            precoAposDesconto = precoProduto;
        }
        else if (statusContaCliente == 2)
        {
            precoAposDesconto = (precoProduto - (0.1m * precoProduto)) - 
                descontoPorFidelidade * (precoProduto - (0.1m * precoProduto));
        }
        else if (statusContaCliente == 3)
        {
            precoAposDesconto = (0.7m * precoProduto) - 
                descontoPorFidelidade * (0.7m * precoProduto);
        }
        else if (statusContaCliente == 4)
        {
            precoAposDesconto = (precoProduto - (0.5m * precoProduto)) 
                - descontoPorFidelidade * (precoProduto - (0.5m * precoProduto));
        }
        return precoAposDesconto;
    }
}

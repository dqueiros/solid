namespace Solid.OCP.ExtensionMethod.OCP_Aderente.Extensions
{
    public static class ProdutoExtension
    {
        //OCP - Usando Métodos de Extensão
        public static double MargemLucro(this Produto produto)
        {
            try
            {
                var lucroLiquido = produto.Venda - produto.Custo;
                var margemLucro = lucroLiquido / produto.Venda * 100;
                return Convert.ToDouble(margemLucro);
            }
            catch (Exception)
            {
                throw new InvalidOperationException("Erro ao calcular a margem de lucro");
            }
        }
    }
}

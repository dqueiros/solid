
namespace Solid.LSP.Violacao1.LSP_Violacao
{
    public class Vendedor : Funcionario
    {
        public double comissao = 1500;

        public Vendedor(string nome, string cargo) : base(nome, cargo)
        { }

        public double CalculaSalario(double salario)
        {
            return salario + comissao;
        }
    }
}


namespace Solid.LSP.Violacao1.LSP_Aderente
{
    public class Vendedor : Funcionario
    {
        public double comissao = 1500;

        public Vendedor(string nome, string cargo) : base(nome, cargo)
        { }

        public override double CalculaSalario(double salario)
        {
            return salario + comissao;
        }
    }
}

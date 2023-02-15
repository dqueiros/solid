
namespace Solid.LSP.Violacao1.LSP_Aderente
{
    public class Funcionario
    {
        private string? Nome { get; set; }
        private string? Cargo { get; set; }

        public Funcionario(string nome, string cargo)
        {
            Nome = nome;
            Cargo = cargo;
        }

        public virtual double CalculaSalario(double salario)
        {
            return salario;
        }
    }
}

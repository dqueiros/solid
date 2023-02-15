
namespace Solid.LSP.Violacao1.LSP_Violacao
{
    public class Gerente : Funcionario
    {
        private double bonus = 3000;

        public Gerente(string nome, string cargo) : base(nome, cargo)
        { }

        public double CalculaSalario(double salario)
        {
            return salario + bonus;
        }
    }
}

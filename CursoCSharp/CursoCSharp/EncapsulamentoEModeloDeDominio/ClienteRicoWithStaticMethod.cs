
using CursoCSharp.EncapsulamentoEModeloDeDominio.Validation;

namespace CursoCSharp.EncapsulamentoEModeloDeDominio
{
    public class ClienteRicoWithStaticMethod
    {
        //A outra solução seria implementar o padrão Notifcation Pattern (Martin Fowler)
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Endereco { get; private set; }
        public ClienteRicoWithStaticMethod(int id, string nome, string endereco)
        {
            DomainExceptionValidation.When(id < 0, "O Id não pode ser negativo");
            DomainExceptionValidation.When(string.IsNullOrEmpty(nome), "O nome deve ser informado");
            DomainExceptionValidation.When(string.IsNullOrEmpty(endereco), "Informe o endereço.");

            Id = id;
            Nome = nome;
            Endereco = endereco;
        }
    }
}

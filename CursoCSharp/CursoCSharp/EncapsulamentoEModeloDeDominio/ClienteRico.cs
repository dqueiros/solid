
namespace CursoCSharp.EncapsulamentoEModeloDeDominio
{
    public class ClienteRico
    {
        //Usa o encapsulamento.
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Endereco { get; private set; }
        public ClienteRico(int id, string nome, string endereco)
        {
            if(id < 0)
                throw new InvalidOperationException();

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(endereco))
                throw new InvalidOperationException();

            Id = id;
            Nome = nome;
            Endereco = endereco;
        }
    }
}

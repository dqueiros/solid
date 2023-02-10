
namespace CursoCSharp.EncapsulamentoEModeloDeDominio
{
    public class ClienteAnemico
    {
        //Modelo de domínio anêmico

        //É um modelo sem lógica, definido apenas com propriedades
        //com get e set públicos.
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
    }
}

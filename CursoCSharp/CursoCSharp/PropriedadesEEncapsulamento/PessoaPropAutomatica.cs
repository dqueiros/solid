
namespace CursoCSharp.PropriedadesEEncapsulamento
{
    public class PessoaPropAutomatica
    {
        //Propriedade Automática
        public string Nome { get; set; }
        
        //Somente leitura
        public string SobreNome { get; }

        //Somente escrita
        private string genero;
        public string Genero 
        {
            set { 
                genero = value;
                Console.WriteLine(genero);
            }
        }

        private int idade;
        public int Idade
        {
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Idade deve ser maior que 18");
                }
                else
                {
                    this.Idade = value;
                }
            }
            get { return idade; }
        }
    }
}

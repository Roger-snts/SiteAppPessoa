using AppPessoa.Models;

namespace AppPessoa.Contexto
{
    public class ContextoBD
    {
        public List<Pessoa>? Pessoas { get; set; }

        public ContextoBD()
        {
            Pessoas = new List<Pessoa>();
        }
    }
}

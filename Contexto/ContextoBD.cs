// Essa classe cria a conexão com o Banco de Dados, requerendo uma Pessoa para passar para ele também

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

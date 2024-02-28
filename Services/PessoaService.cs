using AppPessoa.Contexto;
using AppPessoa.Models;

namespace AppPessoa.Services
{
    public class PessoaService
    {
        private readonly ContextoBD _contexto;

        public PessoaService(ContextoBD contexto)
        {
            _contexto = contexto;
        }

        public async Task<List<Pessoa>>? Pessoas()
        {
            var pessoas = _contexto.Pessoas?.ToList();
            return pessoas;
        }

        public async Task<Pessoa> GetPessoa(int id)
        {
            var pessoa = _contexto.Pessoas?.Where(p => p.id == id).FirstOrDefault();
            return pessoa;
        }

        public async Task<Pessoa> GetPessoa(string cpf)
        {
            var pessoa = _contexto.Pessoas?.Where(p => p.cpf == cpf).FirstOrDefault();
            return pessoa;
        }

        public async Task Add(Pessoa pessoa)
        {
            _contexto.Pessoas?.Add(pessoa);
        }
    }
}

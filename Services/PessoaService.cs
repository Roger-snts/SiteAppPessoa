// Aqui ficam as funções para fazer o CRUD da tabela Pessoa no Banco de Dados

using AppPessoa.Contexto;
using AppPessoa.Models;

namespace AppPessoa.Services
{
    public class PessoaService
    {
        // Inicia uma variável para utilizar os serviços do Banco de Dados
        private readonly ContextoBD _contexto;

        // Método construtor para conectar com o Banco de Dados
        public PessoaService(ContextoBD contexto)
        {
            _contexto = contexto;
        }

        // Método que retorna uma lista com todas as Pessoas cadastradas no Banco de Dados
        public async Task<List<Pessoa>>? Pessoas()
        {
            var pessoas = _contexto.Pessoas?.ToList();
            return pessoas;
        }

        // Método que utiliza o ID para retornar apenas uma Pessoa que esteja cadastrada no Banco de Dados
        public async Task<Pessoa> GetPessoa(int id)
        {
            var pessoa = _contexto.Pessoas?.Where(p => p.id == id).FirstOrDefault();
            return pessoa;
        }

        // Método que utiliza o CPF para retornar apenas uma Pessoa que esteja cadastrada no Banco de Dados
        public async Task<Pessoa> GetPessoa(string cpf)
        {
            var pessoa = _contexto.Pessoas?.Where(p => p.cpf == cpf).FirstOrDefault();
            return pessoa;
        }

        // Método que adiciona uma nova pessoa no Banco de Dados
        public async Task Add(Pessoa pessoa)
        {
            _contexto.Pessoas?.Add(pessoa);
        }
    }
}

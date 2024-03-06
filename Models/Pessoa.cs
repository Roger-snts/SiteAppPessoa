// Modelo de uma pessoa para enviar ao Banco de Dados

namespace AppPessoa.Models
{
    public class Pessoa
    {
        public int       id       { get; set; }
        public string?   nome     { get; set; }
        public string?   cpf      { get; set; }
        public DateTime? dataNasc { get; set; }
        public string    telefone { get; set; }
    }
}

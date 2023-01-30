using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_ProjetoSeguros
{
    public class Pessoa
    {
        private string nome;
        private string cpf;
        private string nascimento;
        
        private string cep;
        private string logradouro;
        private string complemento;
        private string bairro;
        private string cidade;
        private string estado;

        public Pessoa(string nome, string cpf, string nascimento, string cep, string logradouro, string complemento, string bairro, string cidade, string estado)
        {
            Nome = nome;
            Cpf = cpf;
            Nascimento = nascimento;
            Cep = cep;
            Logradouro = logradouro;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Nascimento { get => nascimento; set => nascimento = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Logradouro { get => logradouro; set => logradouro = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}

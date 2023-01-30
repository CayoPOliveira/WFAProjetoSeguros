using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_ProjetoSeguros
{
    public class Tecnico : Pessoa
    {
        private string login;
        private string password;
        private int idTecnico;
        private string especialidade;


        public Tecnico(string nome, string cpf, string nascimento, string cep, string logradouro, string complemento, string bairro, string cidade, string estado, string login, string password, string especialidade, int id = 0) : base(nome, cpf, nascimento, cep, logradouro, complemento, bairro, cidade, estado)
        {
            if (string.IsNullOrEmpty(nome))
            {
                throw new ArgumentException($"'{nameof(nome)}' não pode ser nulo nem vazio.", nameof(nome));
            }

            if (string.IsNullOrEmpty(cpf))
            {
                throw new ArgumentException($"'{nameof(cpf)}' não pode ser nulo nem vazio.", nameof(cpf));
            }

            if (string.IsNullOrEmpty(nascimento))
            {
                throw new ArgumentException($"'{nameof(nascimento)}' não pode ser nulo nem vazio.", nameof(nascimento));
            }

            if (string.IsNullOrEmpty(cep))
            {
                throw new ArgumentException($"'{nameof(cep)}' não pode ser nulo nem vazio.", nameof(cep));
            }

            if (string.IsNullOrEmpty(logradouro))
            {
                throw new ArgumentException($"'{nameof(logradouro)}' não pode ser nulo nem vazio.", nameof(logradouro));
            }

            if (string.IsNullOrEmpty(complemento))
            {
                throw new ArgumentException($"'{nameof(complemento)}' não pode ser nulo nem vazio.", nameof(complemento));
            }

            if (string.IsNullOrEmpty(bairro))
            {
                throw new ArgumentException($"'{nameof(bairro)}' não pode ser nulo nem vazio.", nameof(bairro));
            }

            if (string.IsNullOrEmpty(cidade))
            {
                throw new ArgumentException($"'{nameof(cidade)}' não pode ser nulo nem vazio.", nameof(cidade));
            }

            if (string.IsNullOrEmpty(estado))
            {
                throw new ArgumentException($"'{nameof(estado)}' não pode ser nulo nem vazio.", nameof(estado));
            }

            if (string.IsNullOrEmpty(login))
            {
                throw new ArgumentException($"'{nameof(login)}' não pode ser nulo nem vazio.", nameof(login));
            }

            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentException($"'{nameof(password)}' não pode ser nulo nem vazio.", nameof(password));
            }

            if (string.IsNullOrEmpty(especialidade))
            {
                throw new ArgumentException($"'{nameof(especialidade)}' não pode ser nulo nem vazio.", nameof(especialidade));
            }

            this.login = login;
            this.password = password;
            this.idTecnico = id;
            this.especialidade = especialidade;
        }

        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
        public int Id { get => idTecnico; set => idTecnico = value; }
        public string Especialidade { get => especialidade; set => especialidade = value; }


    }
}

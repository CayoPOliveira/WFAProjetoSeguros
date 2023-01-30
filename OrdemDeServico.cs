using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_ProjetoSeguros
{
    public class OrdemDeServico
    {
        private int idCliente;
        private string tipoDeSeguro;
        private double valor;
        private string dataSolicitacao;
        private string descricaoProblema;
        private int idOrdemServico;
        private int idTecnico;
        private string dataConclusao;
        private string descricaoResposta;

        public OrdemDeServico(int idCliente, string tipoDeSeguro, double valor, string dataSolicitacao, string descricaoProblema, int idOrdemServico = 0, int idTecnico = 0, string dataConclusao = "", string descricaoResposta = "")
        {
            if (string.IsNullOrEmpty(tipoDeSeguro))
            {
                throw new ArgumentException($"'{nameof(tipoDeSeguro)}' não pode ser nulo nem vazio.", nameof(tipoDeSeguro));
            }

            if (string.IsNullOrEmpty(dataSolicitacao))
            {
                throw new ArgumentException($"'{nameof(dataSolicitacao)}' não pode ser nulo nem vazio.", nameof(dataSolicitacao));
            }

            if (string.IsNullOrEmpty(descricaoProblema))
            {
                throw new ArgumentException($"'{nameof(descricaoProblema)}' não pode ser nulo nem vazio.", nameof(descricaoProblema));
            }

            this.idCliente = idCliente;
            this.tipoDeSeguro = tipoDeSeguro;
            this.valor = valor;
            this.dataSolicitacao = dataSolicitacao;
            this.descricaoProblema = descricaoProblema;
            this.idOrdemServico = idOrdemServico;
            this.idTecnico = idTecnico;
            this.dataConclusao = dataConclusao;
            this.descricaoResposta = descricaoResposta;
        }

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string TipoDeSeguro { get => tipoDeSeguro; set => tipoDeSeguro = value; }
        public double Valor { get => valor; set => valor = value; }
        public string DataSolicitacao { get => dataSolicitacao; set => dataSolicitacao = value; }
        public string DescricaoProblema { get => descricaoProblema; set => descricaoProblema = value; }
        public int IdOrdemServico { get => idOrdemServico; set => idOrdemServico = value; }
        public int IdTecnico { get => idTecnico; set => idTecnico = value; }
        public string DataConclusao { get => dataConclusao; set => dataConclusao = value; }
        public string DescricaoResposta { get => descricaoResposta; set => descricaoResposta = value; }
    }
}

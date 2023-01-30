using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfa_CRUDWithBD;

namespace wfa_ProjetoSeguros
{
    public partial class FormOrdemServico : Form
    {
        private Cliente cliente;
        private Tecnico tecnico;
        private OrdemDeServico respostaOS = null;

        public FormOrdemServico(Cliente cliente, Tecnico tecnico)
        {
            InitializeComponent();

            this.cliente = cliente;
            this.tecnico = tecnico;

            if (this.cliente == null)
            {
                dGV.Show();
                lblResposta.Show();
                tbResposta.Show();
                btConfirmaResposta.Show();

                //dGV deve mostrar as OS sem técnico ainda
                ConexaoString stringConexao = new ConexaoString();
                string conexao = stringConexao.ConnString();
                NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexão com o banco
                con.Open(); // Abre a conexão com o banco

                DataTable dt = new DataTable(); // Objeto que pode conter tabelas
                string commandText = "SELECT cod_os, cod_cliente, tipo_seguro, valor_seguro, data_solicitacao_seguro, problema_seguro FROM ordemdeservico WHERE cod_tecnico IS NULL;";
                using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(commandText, con))
                { // Faz a ligação em db e o database
                    Adpt.Fill(dt);
                }

                con.Close(); // Fecha a conexão com o banco

                dGV.DataSource = dt;
            }
        }


        private void btConfirmaCadastro_Click(object sender, EventArgs e)
        {
            OrdemDeServico novaOS = new OrdemDeServico(cliente.Id, tbTipoSeguro.Text, 199.99, DateTime.Now.ToString(), tbDescricao.Text);

            ConexaoString stringConexao = new ConexaoString();
            string conexao = stringConexao.ConnString();
            NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexão com o banco
            con.Open(); // Abre a conexão com o banco

            string commandText = String.Format($"INSERT INTO ordemdeservico (cod_cliente, tipo_seguro, valor_seguro , data_solicitacao_seguro, problema_seguro) VALUES ({novaOS.IdCliente}, '{novaOS.TipoDeSeguro}', {novaOS.Valor.ToString("0,##")}, '{novaOS.DataSolicitacao}', '{novaOS.DescricaoProblema}');");

            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
            { // Faz a ligação em db e o database
                pgsqlcommand.ExecuteNonQuery();
            }

            con.Close();
            MessageBox.Show("Ordem de Serviço cadastrada com sucesso.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }

        private void btConfirmaResposta_Click(object sender, EventArgs e)
        {
            if(respostaOS == null) { MessageBox.Show("Selecione uma ordem de serviço primeiro.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); ; return; }

            respostaOS.DataConclusao = DateTime.Now.ToString();
            respostaOS.DescricaoResposta = tbResposta.Text;
            respostaOS.IdTecnico = tecnico.Id;
            

            ConexaoString stringConexao = new ConexaoString();
            string conexao = stringConexao.ConnString();
            NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexão com o banco
            con.Open(); // Abre a conexão com o banco

            string commandText = String.Format($"UPDATE ordemdeservico SET resposta_seguro = '{respostaOS.DescricaoResposta}', data_conclusao_seguro = '{respostaOS.DataConclusao}', cod_tecnico = '{respostaOS.IdTecnico}' WHERE cod_os = {respostaOS.IdOrdemServico};");

            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
            { // Faz a ligação em db e o database
                pgsqlcommand.ExecuteNonQuery();
            }

            con.Close();
            
            MessageBox.Show("Resposta enviada com sucesso.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }

        private void dGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            respostaOS = new OrdemDeServico(Convert.ToInt32(dGV.Rows[e.RowIndex].Cells[1].Value), Convert.ToString(dGV.Rows[e.RowIndex].Cells[2].Value), Convert.ToDouble(dGV.Rows[e.RowIndex].Cells[3].Value), Convert.ToString(dGV.Rows[e.RowIndex].Cells[4].Value), Convert.ToString(dGV.Rows[e.RowIndex].Cells[5].Value), Convert.ToInt32(dGV.Rows[e.RowIndex].Cells[0].Value));
            tbResposta.Text = Convert.ToString(dGV.Rows[e.RowIndex].Cells[5].Value);
        }

        private void dGV_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            respostaOS = new OrdemDeServico(Convert.ToInt32(dGV.Rows[e.RowIndex].Cells[1].Value), Convert.ToString(dGV.Rows[e.RowIndex].Cells[2].Value), Convert.ToDouble(dGV.Rows[e.RowIndex].Cells[3].Value), Convert.ToString(dGV.Rows[e.RowIndex].Cells[4].Value), Convert.ToString(dGV.Rows[e.RowIndex].Cells[5].Value), Convert.ToInt32(dGV.Rows[e.RowIndex].Cells[0].Value));
            tbResposta.Text = Convert.ToString(dGV.Rows[e.RowIndex].Cells[5].Value);
        }
    }
}

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
    public partial class Home : Form
    {

        private Cliente cliente;
        private Tecnico tecnico;
        private int idOS=-1;

        public Cliente Cliente { get => cliente; set => cliente = value; }
        public Tecnico Tecnico { get => tecnico; set => tecnico = value; }

        public Home()
        {
            InitializeComponent();
            mtbCpf.Mask = "000,000,000-00";
            mtbCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mtbCep.Mask = "00000-000";
            mtbCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
        }

        private void escondeCamposLogin()
        {
            rbCliente.Hide();
            rbTecnico.Hide();
            lblLogin.Hide();
            lblSenha.Hide();
            tbLogin.Hide();
            tbSenha.Hide();
            llblCadastro.Hide();
            btLogin.Hide();
        }
        private void ligaCamposLogin()
        {
            rbCliente.Show();
            rbTecnico.Show();
            lblLogin.Show();
            lblSenha.Show();
            tbLogin.Show();
            tbSenha.Show();
            llblCadastro.Show();
            btLogin.Show();
        }
        private void escondeCamposSair()
        {
            lblNome.Hide();
            tbNome.Hide();
            lblCpf.Hide();
            mtbCpf.Hide();
            lblNascimento.Hide();
            dtmNascimento.Hide();
            lblCep.Hide();
            mtbCep.Hide();
            lblLogradouro.Hide();
            tbLogradouro.Hide();
            lblComplemento.Hide();
            tbComplemento.Hide();
            lblBairro.Hide();
            tbBairro.Hide();
            lblCidade.Hide();
            tbCidade.Hide();
            lblEstado.Hide();
            tbEstado.Hide();
            lblEspecialidade.Hide();
            tbEspecialidade.Hide();
            btDelete.Hide();

            dGV.Hide();
            btSair.Hide();
            btVizualiza.Hide();
            btAtualizar.Hide();
            btSolicita.Hide();
        }
        private void ligaCamposAcesso()
        {
            lblNome.Show();
            tbNome.Show();
            lblCpf.Show();
            mtbCpf.Show();
            lblNascimento.Show();
            dtmNascimento.Show();
            lblCep.Show();
            mtbCep.Show();
            lblLogradouro.Show();
            tbLogradouro.Show();
            lblComplemento.Show();
            tbComplemento.Show();
            lblBairro.Show();
            tbBairro.Show();
            lblCidade.Show();
            tbCidade.Show();
            lblEstado.Show();
            tbEstado.Show();
            lblEspecialidade.Show();
            tbEspecialidade.Show();

            dGV.Show();
            btSair.Show();
            btVizualiza.Show();
            btAtualizar.Show();
            btSolicita.Show();

        }

        private void logado(DataTable dt)
        {
            escondeCamposLogin();
            ligaCamposAcesso();
            if (rbCliente.Checked)
            {
                Cliente acessoCliente = new Cliente(dt.Rows[0].Field<string>(4), dt.Rows[0].Field<string>(5), dt.Rows[0].Field<string>(6), dt.Rows[0].Field<string>(7), dt.Rows[0].Field<string>(8), dt.Rows[0].Field<string>(9), dt.Rows[0].Field<string>(10), dt.Rows[0].Field<string>(11), dt.Rows[0].Field<string>(12), dt.Rows[0].Field<string>(1), dt.Rows[0].Field<string>(2), dt.Rows[0].Field<double>(3), dt.Rows[0].Field<int>(0));
                this.Cliente = acessoCliente;

                lblEspecialidade.Hide(); tbEspecialidade.Hide();
                tbNome.Text = acessoCliente.Nome;
                mtbCpf.Text = acessoCliente.Cpf;
                dtmNascimento.Text = acessoCliente.Nascimento;
                mtbCep.Text = acessoCliente.Cep;
                tbLogradouro.Text = acessoCliente.Logradouro;
                tbComplemento.Text = acessoCliente.Complemento;
                tbBairro.Text = acessoCliente.Bairro;
                tbCidade.Text = acessoCliente.Cidade;
                tbEstado.Text = acessoCliente.Estado;

            }
            else if (rbTecnico.Checked)
            {
                Tecnico acessoTecnico = new Tecnico(dt.Rows[0].Field<string>(4), dt.Rows[0].Field<string>(5), dt.Rows[0].Field<string>(6), dt.Rows[0].Field<string>(7), dt.Rows[0].Field<string>(8), dt.Rows[0].Field<string>(9), dt.Rows[0].Field<string>(10), dt.Rows[0].Field<string>(11), dt.Rows[0].Field<string>(12), dt.Rows[0].Field<string>(1), dt.Rows[0].Field<string>(2), dt.Rows[0].Field<string>(3), dt.Rows[0].Field<int>(0));
                this.Tecnico = acessoTecnico;
                if (Tecnico.Id == 0) btDelete.Show();

                tbNome.Text = acessoTecnico.Nome;
                mtbCpf.Text = acessoTecnico.Cpf;
                dtmNascimento.Text = acessoTecnico.Nascimento;
                mtbCep.Text = acessoTecnico.Cep;
                tbLogradouro.Text = acessoTecnico.Logradouro;
                tbComplemento.Text = acessoTecnico.Complemento;
                tbBairro.Text = acessoTecnico.Bairro;
                tbCidade.Text = acessoTecnico.Cidade;
                tbEstado.Text = acessoTecnico.Estado;
                tbEspecialidade.Text = acessoTecnico.Especialidade;
            }

            return;
        }

        private void llblCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCadastro cadastroform = new FormCadastro();
            cadastroform.Show();
        }


        private void btLogin_Click(object sender, EventArgs e)
        {
            string login = tbLogin.Text;
            string senha = tbSenha.Text;

            string table = "", logtable = "", sentable = "";
            if (rbCliente.Checked) { table = "cliente"; logtable = "login_cliente"; sentable = "senha_cliente"; }
            else if (rbTecnico.Checked) { table = "tecnico"; logtable = "login_tecnico"; sentable = "senha_tecnico"; }

            ConexaoString stringConexao = new ConexaoString();
            string conexao = stringConexao.ConnString();
            NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexão com o banco
            con.Open(); // Abre a conexão com o banco

            DataTable dt = new DataTable(); // Objeto que pode conter tabelas
            string commandText = String.Format($"SELECT * FROM {table} WHERE {logtable} = '{login}' AND {sentable} = '{senha}';" );
            using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(commandText, con))
            { // Faz a ligação em db e o database
                Adpt.Fill(dt);
            }

            con.Close();

            int count = dt.Rows.Count;
            if (count == 0) MessageBox.Show("Login ou Senha não foi encontrado", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            else logado(dt);
        }

        private void btVizualiza_Click(object sender, EventArgs e)
        {
            ConexaoString stringConexao = new ConexaoString();
            string conexao = stringConexao.ConnString();
            NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexão com o banco
            con.Open(); // Abre a conexão com o banco

            DataTable dt = new DataTable(); // Objeto que pode conter tabelas
            if (rbCliente.Checked)
            {
                string commandText = $"SELECT cod_os, tipo_seguro, valor_seguro, data_solicitacao_seguro, problema_seguro, data_conclusao_seguro, resposta_seguro FROM ordemdeservico WHERE cod_cliente = {this.Cliente.Id};";
                using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(commandText, con))
                { // Faz a ligação em db e o database
                    Adpt.Fill(dt);
                }
            }
            else if (rbTecnico.Checked)
            {
                string commandText = $"SELECT cod_os, tipo_seguro, valor_seguro, data_solicitacao_seguro, problema_seguro, data_conclusao_seguro, resposta_seguro FROM ordemdeservico WHERE cod_tecnico = {this.Tecnico.Id};";
                if (Tecnico.Id == 0)
                   commandText = "SELECT cod_os, cod_cliente, cod_tecnico, tipo_seguro, valor_seguro, data_solicitacao_seguro, problema_seguro,  data_conclusao_seguro, resposta_seguro FROM ordemdeservico";
                using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(commandText, con))
                { // Faz a ligação em db e o database
                    Adpt.Fill(dt);
                }
            }
            con.Close(); // Fecha a conexão com o banco

            dGV.DataSource = dt;
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            escondeCamposSair();
            ligaCamposLogin();
            dGV.DataSource = "";
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            if (rbCliente.Checked)
            {
                Cliente novoCliente = new Cliente(tbNome.Text, mtbCpf.Text, dtmNascimento.Text, mtbCep.Text, tbLogradouro.Text, tbComplemento.Text, tbBairro.Text, tbCidade.Text, tbEstado.Text, this.Cliente.Login, this.Cliente.Password, this.Cliente.Debitos, this.Cliente.Id);

                ConexaoString stringConexao = new ConexaoString();
                string conexao = stringConexao.ConnString();
                NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexão com o banco
                con.Open(); // Abre a conexão com o banco

                string commandText = String.Format($"UPDATE cliente SET nome_cliente = '{novoCliente.Nome}' ,cpf_cliente = '{novoCliente.Cpf}', nascimento_cliente = '{novoCliente.Nascimento}', cep_cliente = '{novoCliente.Cep}', logradouro_cliente = '{novoCliente.Logradouro}', complemento_cliente = '{novoCliente.Complemento}', bairro_cliente = '{novoCliente.Bairro}', cidade_cliente = '{novoCliente.Cidade}', estado_cliente = '{novoCliente.Estado}' WHERE cod_cliente = {novoCliente.Id}; ");

                using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
                { // Faz a ligação em db e o database
                    pgsqlcommand.ExecuteNonQuery();
                }

                con.Close();
                this.Cliente = novoCliente;
            }
            else if (rbTecnico.Checked)
            {
                Tecnico novoTecnico = new Tecnico(tbNome.Text, mtbCpf.Text, dtmNascimento.Text, mtbCep.Text, tbLogradouro.Text, tbComplemento.Text, tbBairro.Text, tbCidade.Text, tbEstado.Text, tbLogin.Text, tbSenha.Text, tbEspecialidade.Text, this.Tecnico.Id);

                ConexaoString stringConexao = new ConexaoString();
                string conexao = stringConexao.ConnString();
                NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexão com o banco
                con.Open(); // Abre a conexão com o banco

                string commandText = String.Format($"UPDATE tecnico SET nome_tecnico = '{novoTecnico.Nome}' ,cpf_tecnico = '{novoTecnico.Cpf}', nascimento_tecnico = '{novoTecnico.Nascimento}', cep_tecnico = '{novoTecnico.Cep}', logradouro_tecnico = '{novoTecnico.Logradouro}', complemento_tecnico = '{novoTecnico.Complemento}', bairro_tecnico = '{novoTecnico.Bairro}', cidade_tecnico = '{novoTecnico.Cidade}', estado_tecnico = '{novoTecnico.Estado}', especialidade = '{novoTecnico.Especialidade}' WHERE cod_tecnico = {novoTecnico.Id}; ");

                using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
                { // Faz a ligação em db e o database
                    pgsqlcommand.ExecuteNonQuery();
                }

                con.Close();
                this.Tecnico = novoTecnico;
            }

            MessageBox.Show("Cadastro atualizado com sucesso: ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btSolicita_Click(object sender, EventArgs e)
        {
            FormOrdemServico formOS = null;
            if (rbCliente.Checked) formOS = new FormOrdemServico(this.cliente, null);
            if (rbTecnico.Checked) formOS = new FormOrdemServico(null, this.tecnico);
            formOS.Show();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if(idOS == -1) { return; }

            ConexaoString stringConexao = new ConexaoString();
            string conexao = stringConexao.ConnString();
            NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexão com o banco

            con.Open(); // Abre a conexão com o banco

            string commandText = String.Format($"DELETE FROM ordemdeservico WHERE cod_os = '{idOS}';");
            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
            {
                pgsqlcommand.ExecuteNonQuery();
            }

            con.Close();

            MessageBox.Show("Ordem de serviço excluida com sucesso.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            idOS = Convert.ToInt32(dGV.Rows[e.RowIndex].Cells[0].Value);
        }

        private void dGV_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            idOS = Convert.ToInt32(dGV.Rows[e.RowIndex].Cells[0].Value);
        }
    }
}

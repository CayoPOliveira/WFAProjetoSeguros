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
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
            lblEspecialidade.Hide();
            tbEspecialidade.Hide();
            lblErros.Hide();
            mtbCpf.Mask = "000,000,000-00";
            mtbCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mtbCep.Mask = "00000-000";
            mtbCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
        }

        private void rbCliente_CheckedChanged(object sender, EventArgs e)
        {
            lblEspecialidade.Hide();
            tbEspecialidade.Hide();
        }

        private void rbTecnico_CheckedChanged(object sender, EventArgs e)
        {
            lblEspecialidade.Show();
            tbEspecialidade.Show();
        }

        private bool verificaLogin()
        {
            string login = tbLogin.Text;
            string table = "", logtable = "";
            if (rbCliente.Checked) { table = "cliente"; logtable = "login_cliente"; }
            else if (rbTecnico.Checked) { table = "tecnico"; logtable = "login_tecnico"; }

            ConexaoString stringConexao = new ConexaoString();
            string conexao = stringConexao.ConnString();
            NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexão com o banco
            con.Open(); // Abre a conexão com o banco

            DataTable dt = new DataTable(); // Objeto que pode conter tabelas
            string commandText = String.Format($"SELECT * FROM {table} WHERE {logtable} = '{login}'");
            using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(commandText, con))
            { // Faz a ligação em db e o database
                Adpt.Fill(dt);
            }

            con.Close();

            int count = dt.Rows.Count;
            return count == 0 ? true : false; 
        }

        private void cadastrarCliente()
        {
            Cliente novoCliente = new Cliente(tbNome.Text,mtbCpf.Text,dtmNascimento.Text,mtbCep.Text,tbLogradouro.Text,tbComplemento.Text,tbBairro.Text,tbCidade.Text,tbEstado.Text,tbLogin.Text,tbSenha.Text);

            ConexaoString stringConexao = new ConexaoString();
            string conexao = stringConexao.ConnString();
            NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexão com o banco
            con.Open(); // Abre a conexão com o banco

            string commandText = String.Format($"INSERT INTO cliente (login_cliente,senha_cliente,debitos_cliente,nome_cliente,cpf_cliente,nascimento_cliente,cep_cliente,logradouro_cliente,complemento_cliente,bairro_cliente,cidade_cliente,estado_cliente) VALUES('{novoCliente.Login}','{novoCliente.Password}',{novoCliente.Debitos},'{novoCliente.Nome}','{novoCliente.Cpf}','{novoCliente.Nascimento}','{novoCliente.Cep}','{novoCliente.Logradouro}','{novoCliente.Complemento}','{novoCliente.Bairro}','{novoCliente.Cidade}','{novoCliente.Estado}');");

            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
            { // Faz a ligação em db e o database
                pgsqlcommand.ExecuteNonQuery();
            }

            con.Close();

        }

        private void cadastrarTecnico()
        {
            Tecnico novoTecnico = new Tecnico(tbNome.Text, mtbCpf.Text, dtmNascimento.Text, mtbCep.Text, tbLogradouro.Text, tbComplemento.Text, tbBairro.Text, tbCidade.Text, tbEstado.Text, tbLogin.Text, tbSenha.Text, tbEspecialidade.Text);

            ConexaoString stringConexao = new ConexaoString();
            string conexao = stringConexao.ConnString();
            NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexão com o banco
            con.Open(); // Abre a conexão com o banco

            string commandText = String.Format($"INSERT INTO tecnico (login_tecnico,senha_tecnico,especialidade,nome_tecnico,cpf_tecnico,nascimento_tecnico,cep_tecnico,logradouro_tecnico,complemento_tecnico,bairro_tecnico,cidade_tecnico,estado_tecnico) VALUES('{novoTecnico.Login}','{novoTecnico.Password}','{novoTecnico.Especialidade}','{novoTecnico.Nome}','{novoTecnico.Cpf}','{novoTecnico.Nascimento}','{novoTecnico.Cep}','{novoTecnico.Logradouro}','{novoTecnico.Complemento}','{novoTecnico.Bairro}','{novoTecnico.Cidade}','{novoTecnico.Estado}');");

            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
            { // Faz a ligação em db e o database
                pgsqlcommand.ExecuteNonQuery();
            }

            con.Close();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            if (tbSenha.Text != tbConfSenha.Text || !verificaLogin()) { lblErros.Show(); return; }

            if (rbCliente.Checked) { cadastrarCliente(); }
            else if (rbTecnico.Checked) { cadastrarTecnico(); }

            MessageBox.Show("Cadastro inserido com sucesso: ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}

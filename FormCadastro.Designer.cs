namespace wfa_ProjetoSeguros
{
    partial class FormCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mtbCep = new System.Windows.Forms.MaskedTextBox();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.dtmNascimento = new System.Windows.Forms.DateTimePicker();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.lblErros = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.tbConfSenha = new System.Windows.Forms.TextBox();
            this.lblConfSenha = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblEspecialidade = new System.Windows.Forms.Label();
            this.tbEspecialidade = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.tbEstado = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.tbComplemento = new System.Windows.Forms.TextBox();
            this.tbLogradouro = new System.Windows.Forms.TextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.rbTecnico = new System.Windows.Forms.RadioButton();
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mtbCep
            // 
            this.mtbCep.Location = new System.Drawing.Point(465, 96);
            this.mtbCep.Name = "mtbCep";
            this.mtbCep.Size = new System.Drawing.Size(207, 23);
            this.mtbCep.TabIndex = 9;
            // 
            // mtbCpf
            // 
            this.mtbCpf.Location = new System.Drawing.Point(465, 38);
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(207, 23);
            this.mtbCpf.TabIndex = 7;
            // 
            // dtmNascimento
            // 
            this.dtmNascimento.Location = new System.Drawing.Point(465, 68);
            this.dtmNascimento.Name = "dtmNascimento";
            this.dtmNascimento.Size = new System.Drawing.Size(207, 23);
            this.dtmNascimento.TabIndex = 8;
            this.dtmNascimento.Value = new System.DateTime(2023, 1, 27, 22, 18, 33, 0);
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(169, 244);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(147, 26);
            this.btCadastrar.TabIndex = 16;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // lblErros
            // 
            this.lblErros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErros.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErros.ForeColor = System.Drawing.Color.Red;
            this.lblErros.Location = new System.Drawing.Point(13, 157);
            this.lblErros.Name = "lblErros";
            this.lblErros.Size = new System.Drawing.Size(303, 37);
            this.lblErros.TabIndex = 84;
            this.lblErros.Text = "Este login não está disponível ou as senhas não são idênticas, porfavor verifique" +
    ".";
            this.lblErros.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(169, 73);
            this.tbLogin.MaxLength = 50;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(147, 23);
            this.tbLogin.TabIndex = 3;
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(169, 102);
            this.tbSenha.MaxLength = 50;
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(147, 23);
            this.tbSenha.TabIndex = 4;
            this.tbSenha.UseSystemPasswordChar = true;
            // 
            // tbConfSenha
            // 
            this.tbConfSenha.Location = new System.Drawing.Point(169, 131);
            this.tbConfSenha.MaxLength = 50;
            this.tbConfSenha.Name = "tbConfSenha";
            this.tbConfSenha.Size = new System.Drawing.Size(147, 23);
            this.tbConfSenha.TabIndex = 5;
            this.tbConfSenha.UseSystemPasswordChar = true;
            // 
            // lblConfSenha
            // 
            this.lblConfSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConfSenha.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblConfSenha.Location = new System.Drawing.Point(11, 127);
            this.lblConfSenha.Name = "lblConfSenha";
            this.lblConfSenha.Size = new System.Drawing.Size(152, 30);
            this.lblConfSenha.TabIndex = 80;
            this.lblConfSenha.Text = "Confirme a senha";
            this.lblConfSenha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLogin.Location = new System.Drawing.Point(11, 69);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(152, 30);
            this.lblLogin.TabIndex = 79;
            this.lblLogin.Text = "Login";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSenha
            // 
            this.lblSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSenha.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSenha.Location = new System.Drawing.Point(11, 98);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(152, 30);
            this.lblSenha.TabIndex = 78;
            this.lblSenha.Text = "Senha";
            this.lblSenha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEspecialidade
            // 
            this.lblEspecialidade.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEspecialidade.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblEspecialidade.Location = new System.Drawing.Point(331, 266);
            this.lblEspecialidade.Name = "lblEspecialidade";
            this.lblEspecialidade.Size = new System.Drawing.Size(128, 30);
            this.lblEspecialidade.TabIndex = 77;
            this.lblEspecialidade.Text = "Especialidade";
            this.lblEspecialidade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbEspecialidade
            // 
            this.tbEspecialidade.AutoCompleteCustomSource.AddRange(new string[] {
            "Carros",
            "Computadores",
            "Celulares"});
            this.tbEspecialidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbEspecialidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbEspecialidade.Location = new System.Drawing.Point(465, 270);
            this.tbEspecialidade.MaxLength = 50;
            this.tbEspecialidade.Name = "tbEspecialidade";
            this.tbEspecialidade.Size = new System.Drawing.Size(207, 23);
            this.tbEspecialidade.TabIndex = 15;
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblEstado.Location = new System.Drawing.Point(331, 237);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(128, 30);
            this.lblEstado.TabIndex = 75;
            this.lblEstado.Text = "Estado";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbEstado
            // 
            this.tbEstado.AutoCompleteCustomSource.AddRange(new string[] {
            "Acre (AC)",
            "Alagoas (AL)",
            "Amapá (AP)",
            "Amazonas (AM)",
            "Bahia (BA)",
            "Ceará (CE)",
            "Espírito Santo (ES)",
            "Goiás (GO)",
            "Maranhão (MA)",
            "Mato Grosso (MT)",
            "Mato Grosso do Sul (MS)",
            "Minas Gerais (MG)",
            "Pará (PA)",
            "Paraíba (PB)",
            "Paraná (PR)",
            "Pernambuco (PE)",
            "Piauí (PI)",
            "Rio de Janeiro (RJ)",
            "Rio Grande do Norte (RN)",
            "Rio Grande do Sul (RS)",
            "Rondônia (RO)",
            "Roraima (RR)",
            "Santa Catarina (SC)",
            "São Paulo (SP)",
            "Sergipe (SE)",
            "Tocantins (TO)",
            "Distrito Federal (DF)"});
            this.tbEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbEstado.Location = new System.Drawing.Point(465, 241);
            this.tbEstado.Name = "tbEstado";
            this.tbEstado.Size = new System.Drawing.Size(207, 23);
            this.tbEstado.TabIndex = 14;
            // 
            // lblCidade
            // 
            this.lblCidade.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCidade.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCidade.Location = new System.Drawing.Point(331, 208);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(128, 30);
            this.lblCidade.TabIndex = 73;
            this.lblCidade.Text = "Cidade";
            this.lblCidade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBairro
            // 
            this.lblBairro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBairro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblBairro.Location = new System.Drawing.Point(331, 179);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(128, 30);
            this.lblBairro.TabIndex = 72;
            this.lblBairro.Text = "Bairro";
            this.lblBairro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbCidade
            // 
            this.tbCidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbCidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.tbCidade.Location = new System.Drawing.Point(465, 212);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(207, 23);
            this.tbCidade.TabIndex = 13;
            // 
            // tbBairro
            // 
            this.tbBairro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbBairro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.tbBairro.Location = new System.Drawing.Point(465, 183);
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(207, 23);
            this.tbBairro.TabIndex = 12;
            // 
            // lblComplemento
            // 
            this.lblComplemento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblComplemento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblComplemento.Location = new System.Drawing.Point(331, 150);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(128, 30);
            this.lblComplemento.TabIndex = 69;
            this.lblComplemento.Text = "Complemento";
            this.lblComplemento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogradouro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLogradouro.Location = new System.Drawing.Point(331, 121);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(128, 30);
            this.lblLogradouro.TabIndex = 68;
            this.lblLogradouro.Text = "Logradouro";
            this.lblLogradouro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbComplemento
            // 
            this.tbComplemento.Location = new System.Drawing.Point(465, 154);
            this.tbComplemento.Name = "tbComplemento";
            this.tbComplemento.Size = new System.Drawing.Size(207, 23);
            this.tbComplemento.TabIndex = 11;
            // 
            // tbLogradouro
            // 
            this.tbLogradouro.Location = new System.Drawing.Point(465, 125);
            this.tbLogradouro.Name = "tbLogradouro";
            this.tbLogradouro.Size = new System.Drawing.Size(207, 23);
            this.tbLogradouro.TabIndex = 10;
            // 
            // lblCep
            // 
            this.lblCep.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCep.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCep.Location = new System.Drawing.Point(331, 92);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(128, 30);
            this.lblCep.TabIndex = 65;
            this.lblCep.Text = "CEP";
            this.lblCep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNascimento
            // 
            this.lblNascimento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNascimento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNascimento.Location = new System.Drawing.Point(331, 63);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(128, 30);
            this.lblNascimento.TabIndex = 64;
            this.lblNascimento.Text = "Nascimento";
            this.lblNascimento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCpf
            // 
            this.lblCpf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCpf.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCpf.Location = new System.Drawing.Point(331, 34);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(128, 30);
            this.lblCpf.TabIndex = 63;
            this.lblCpf.Text = "CPF";
            this.lblCpf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNome.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNome.Location = new System.Drawing.Point(331, 5);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(128, 30);
            this.lblNome.TabIndex = 62;
            this.lblNome.Text = "Nome";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(465, 9);
            this.tbNome.MaxLength = 50;
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(207, 23);
            this.tbNome.TabIndex = 6;
            // 
            // rbTecnico
            // 
            this.rbTecnico.AutoSize = true;
            this.rbTecnico.Location = new System.Drawing.Point(169, 35);
            this.rbTecnico.Name = "rbTecnico";
            this.rbTecnico.Size = new System.Drawing.Size(84, 20);
            this.rbTecnico.TabIndex = 2;
            this.rbTecnico.TabStop = true;
            this.rbTecnico.Text = "Técnico";
            this.rbTecnico.UseVisualStyleBackColor = true;
            this.rbTecnico.CheckedChanged += new System.EventHandler(this.rbTecnico_CheckedChanged);
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.Location = new System.Drawing.Point(169, 9);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(77, 20);
            this.rbCliente.TabIndex = 1;
            this.rbCliente.TabStop = true;
            this.rbCliente.Text = "Cliente";
            this.rbCliente.UseVisualStyleBackColor = true;
            this.rbCliente.CheckedChanged += new System.EventHandler(this.rbCliente_CheckedChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTitle.Location = new System.Drawing.Point(13, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(150, 60);
            this.lblTitle.TabIndex = 58;
            this.lblTitle.Text = "Sistema de acesso Seguros S.A.";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(684, 311);
            this.Controls.Add(this.mtbCep);
            this.Controls.Add(this.mtbCpf);
            this.Controls.Add(this.dtmNascimento);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.lblErros);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.tbConfSenha);
            this.Controls.Add(this.lblConfSenha);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblEspecialidade);
            this.Controls.Add(this.tbEspecialidade);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.tbEstado);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.tbCidade);
            this.Controls.Add(this.tbBairro);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.lblLogradouro);
            this.Controls.Add(this.tbComplemento);
            this.Controls.Add(this.tbLogradouro);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.lblNascimento);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.rbTecnico);
            this.Controls.Add(this.rbCliente);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCadastro";
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbCep;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.DateTimePicker dtmNascimento;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Label lblErros;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.TextBox tbConfSenha;
        private System.Windows.Forms.Label lblConfSenha;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblEspecialidade;
        private System.Windows.Forms.TextBox tbEspecialidade;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox tbEstado;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.TextBox tbComplemento;
        private System.Windows.Forms.TextBox tbLogradouro;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.RadioButton rbTecnico;
        private System.Windows.Forms.RadioButton rbCliente;
        private System.Windows.Forms.Label lblTitle;
    }
}
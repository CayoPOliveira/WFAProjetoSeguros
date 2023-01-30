namespace wfa_ProjetoSeguros
{
    partial class Home
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btLogin = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.llblCadastro = new System.Windows.Forms.LinkLabel();
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.rbTecnico = new System.Windows.Forms.RadioButton();
            this.mtbCep = new System.Windows.Forms.MaskedTextBox();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.dtmNascimento = new System.Windows.Forms.DateTimePicker();
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
            this.btAtualizar = new System.Windows.Forms.Button();
            this.btSolicita = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.btVizualiza = new System.Windows.Forms.Button();
            this.dGV = new System.Windows.Forms.DataGridView();
            this.btDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            this.SuspendLayout();
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(88, 86);
            this.tbLogin.MaxLength = 50;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(200, 23);
            this.tbLogin.TabIndex = 3;
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(88, 115);
            this.tbSenha.MaxLength = 50;
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(200, 23);
            this.tbSenha.TabIndex = 4;
            this.tbSenha.UseSystemPasswordChar = true;
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLogin.Location = new System.Drawing.Point(10, 82);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(72, 30);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Login";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSenha
            // 
            this.lblSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSenha.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSenha.Location = new System.Drawing.Point(10, 111);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(72, 30);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha";
            this.lblSenha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btLogin
            // 
            this.btLogin.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btLogin.Location = new System.Drawing.Point(213, 153);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(75, 23);
            this.btLogin.TabIndex = 5;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(150, 60);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Sistema de acesso Seguros S.A.";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // llblCadastro
            // 
            this.llblCadastro.AutoSize = true;
            this.llblCadastro.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.llblCadastro.Location = new System.Drawing.Point(135, 157);
            this.llblCadastro.Name = "llblCadastro";
            this.llblCadastro.Size = new System.Drawing.Size(67, 15);
            this.llblCadastro.TabIndex = 6;
            this.llblCadastro.TabStop = true;
            this.llblCadastro.Text = "Cadastro";
            this.llblCadastro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblCadastro_LinkClicked);
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.Checked = true;
            this.rbCliente.Location = new System.Drawing.Point(88, 50);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(77, 20);
            this.rbCliente.TabIndex = 1;
            this.rbCliente.TabStop = true;
            this.rbCliente.Text = "Cliente";
            this.rbCliente.UseVisualStyleBackColor = true;
            // 
            // rbTecnico
            // 
            this.rbTecnico.AutoSize = true;
            this.rbTecnico.Location = new System.Drawing.Point(204, 50);
            this.rbTecnico.Name = "rbTecnico";
            this.rbTecnico.Size = new System.Drawing.Size(84, 20);
            this.rbTecnico.TabIndex = 2;
            this.rbTecnico.Text = "Técnico";
            this.rbTecnico.UseVisualStyleBackColor = true;
            // 
            // mtbCep
            // 
            this.mtbCep.Location = new System.Drawing.Point(465, 99);
            this.mtbCep.Name = "mtbCep";
            this.mtbCep.Size = new System.Drawing.Size(207, 23);
            this.mtbCep.TabIndex = 81;
            this.mtbCep.Visible = false;
            // 
            // mtbCpf
            // 
            this.mtbCpf.Location = new System.Drawing.Point(465, 41);
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(207, 23);
            this.mtbCpf.TabIndex = 79;
            this.mtbCpf.Visible = false;
            // 
            // dtmNascimento
            // 
            this.dtmNascimento.Location = new System.Drawing.Point(465, 71);
            this.dtmNascimento.Name = "dtmNascimento";
            this.dtmNascimento.Size = new System.Drawing.Size(207, 23);
            this.dtmNascimento.TabIndex = 80;
            this.dtmNascimento.Value = new System.DateTime(2023, 1, 29, 0, 0, 0, 0);
            this.dtmNascimento.Visible = false;
            // 
            // lblEspecialidade
            // 
            this.lblEspecialidade.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEspecialidade.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblEspecialidade.Location = new System.Drawing.Point(331, 269);
            this.lblEspecialidade.Name = "lblEspecialidade";
            this.lblEspecialidade.Size = new System.Drawing.Size(128, 30);
            this.lblEspecialidade.TabIndex = 97;
            this.lblEspecialidade.Text = "Especialidade";
            this.lblEspecialidade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblEspecialidade.Visible = false;
            // 
            // tbEspecialidade
            // 
            this.tbEspecialidade.AutoCompleteCustomSource.AddRange(new string[] {
            "Carros",
            "Computadores",
            "Celulares"});
            this.tbEspecialidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbEspecialidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbEspecialidade.Location = new System.Drawing.Point(465, 273);
            this.tbEspecialidade.MaxLength = 50;
            this.tbEspecialidade.Name = "tbEspecialidade";
            this.tbEspecialidade.Size = new System.Drawing.Size(207, 23);
            this.tbEspecialidade.TabIndex = 87;
            this.tbEspecialidade.Visible = false;
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblEstado.Location = new System.Drawing.Point(331, 240);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(128, 30);
            this.lblEstado.TabIndex = 96;
            this.lblEstado.Text = "Estado";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblEstado.Visible = false;
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
            this.tbEstado.Location = new System.Drawing.Point(465, 244);
            this.tbEstado.Name = "tbEstado";
            this.tbEstado.Size = new System.Drawing.Size(207, 23);
            this.tbEstado.TabIndex = 86;
            this.tbEstado.Visible = false;
            // 
            // lblCidade
            // 
            this.lblCidade.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCidade.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCidade.Location = new System.Drawing.Point(331, 211);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(128, 30);
            this.lblCidade.TabIndex = 95;
            this.lblCidade.Text = "Cidade";
            this.lblCidade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCidade.Visible = false;
            // 
            // lblBairro
            // 
            this.lblBairro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBairro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblBairro.Location = new System.Drawing.Point(331, 182);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(128, 30);
            this.lblBairro.TabIndex = 94;
            this.lblBairro.Text = "Bairro";
            this.lblBairro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblBairro.Visible = false;
            // 
            // tbCidade
            // 
            this.tbCidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbCidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.tbCidade.Location = new System.Drawing.Point(465, 215);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(207, 23);
            this.tbCidade.TabIndex = 85;
            this.tbCidade.Visible = false;
            // 
            // tbBairro
            // 
            this.tbBairro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbBairro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.tbBairro.Location = new System.Drawing.Point(465, 186);
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(207, 23);
            this.tbBairro.TabIndex = 84;
            this.tbBairro.Visible = false;
            // 
            // lblComplemento
            // 
            this.lblComplemento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblComplemento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblComplemento.Location = new System.Drawing.Point(331, 153);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(128, 30);
            this.lblComplemento.TabIndex = 93;
            this.lblComplemento.Text = "Complemento";
            this.lblComplemento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblComplemento.Visible = false;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogradouro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLogradouro.Location = new System.Drawing.Point(331, 124);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(128, 30);
            this.lblLogradouro.TabIndex = 92;
            this.lblLogradouro.Text = "Logradouro";
            this.lblLogradouro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLogradouro.Visible = false;
            // 
            // tbComplemento
            // 
            this.tbComplemento.Location = new System.Drawing.Point(465, 157);
            this.tbComplemento.Name = "tbComplemento";
            this.tbComplemento.Size = new System.Drawing.Size(207, 23);
            this.tbComplemento.TabIndex = 83;
            this.tbComplemento.Visible = false;
            // 
            // tbLogradouro
            // 
            this.tbLogradouro.Location = new System.Drawing.Point(465, 128);
            this.tbLogradouro.Name = "tbLogradouro";
            this.tbLogradouro.Size = new System.Drawing.Size(207, 23);
            this.tbLogradouro.TabIndex = 82;
            this.tbLogradouro.Visible = false;
            // 
            // lblCep
            // 
            this.lblCep.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCep.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCep.Location = new System.Drawing.Point(331, 95);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(128, 30);
            this.lblCep.TabIndex = 91;
            this.lblCep.Text = "CEP";
            this.lblCep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCep.Visible = false;
            // 
            // lblNascimento
            // 
            this.lblNascimento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNascimento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNascimento.Location = new System.Drawing.Point(331, 66);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(128, 30);
            this.lblNascimento.TabIndex = 90;
            this.lblNascimento.Text = "Nascimento";
            this.lblNascimento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNascimento.Visible = false;
            // 
            // lblCpf
            // 
            this.lblCpf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCpf.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCpf.Location = new System.Drawing.Point(331, 37);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(128, 30);
            this.lblCpf.TabIndex = 89;
            this.lblCpf.Text = "CPF";
            this.lblCpf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCpf.Visible = false;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNome.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNome.Location = new System.Drawing.Point(331, 8);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(128, 30);
            this.lblNome.TabIndex = 88;
            this.lblNome.Text = "Nome";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNome.Visible = false;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(465, 12);
            this.tbNome.MaxLength = 50;
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(207, 23);
            this.tbNome.TabIndex = 78;
            this.tbNome.Visible = false;
            // 
            // btAtualizar
            // 
            this.btAtualizar.Location = new System.Drawing.Point(168, 204);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(150, 45);
            this.btAtualizar.TabIndex = 104;
            this.btAtualizar.Text = "Atualizar\r\nInformações";
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Visible = false;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // btSolicita
            // 
            this.btSolicita.Location = new System.Drawing.Point(12, 251);
            this.btSolicita.Name = "btSolicita";
            this.btSolicita.Size = new System.Drawing.Size(150, 45);
            this.btSolicita.TabIndex = 103;
            this.btSolicita.Text = "Solicitar\r\nServiços";
            this.btSolicita.UseVisualStyleBackColor = true;
            this.btSolicita.Visible = false;
            this.btSolicita.Click += new System.EventHandler(this.btSolicita_Click);
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(168, 251);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(150, 45);
            this.btSair.TabIndex = 105;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Visible = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btVizualiza
            // 
            this.btVizualiza.Location = new System.Drawing.Point(12, 204);
            this.btVizualiza.Name = "btVizualiza";
            this.btVizualiza.Size = new System.Drawing.Size(150, 45);
            this.btVizualiza.TabIndex = 102;
            this.btVizualiza.Text = "Vizualizar\r\nServiços";
            this.btVizualiza.UseVisualStyleBackColor = true;
            this.btVizualiza.Visible = false;
            this.btVizualiza.Click += new System.EventHandler(this.btVizualiza_Click);
            // 
            // dGV
            // 
            this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV.Location = new System.Drawing.Point(13, 41);
            this.dGV.Name = "dGV";
            this.dGV.Size = new System.Drawing.Size(305, 157);
            this.dGV.TabIndex = 100;
            this.dGV.Visible = false;
            this.dGV.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGV_CellMouseClick);
            this.dGV.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGV_CellMouseDoubleClick);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(204, 9);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(114, 25);
            this.btDelete.TabIndex = 106;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Visible = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(684, 311);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.dGV);
            this.Controls.Add(this.btVizualiza);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btSolicita);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.mtbCep);
            this.Controls.Add(this.mtbCpf);
            this.Controls.Add(this.dtmNascimento);
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
            this.Controls.Add(this.llblCadastro);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.tbLogin);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.Text = "Seguros S.A.";
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.LinkLabel llblCadastro;
        private System.Windows.Forms.RadioButton rbCliente;
        private System.Windows.Forms.RadioButton rbTecnico;
        private System.Windows.Forms.MaskedTextBox mtbCep;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.DateTimePicker dtmNascimento;
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
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Button btSolicita;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btVizualiza;
        private System.Windows.Forms.DataGridView dGV;
        private System.Windows.Forms.Button btDelete;
    }
}


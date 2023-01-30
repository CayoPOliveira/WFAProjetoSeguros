namespace wfa_ProjetoSeguros
{
    partial class FormOrdemServico
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
            this.lblTipoSeguro = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblMostraValor = new System.Windows.Forms.Label();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.btConfirmaCadastro = new System.Windows.Forms.Button();
            this.tbResposta = new System.Windows.Forms.TextBox();
            this.lblResposta = new System.Windows.Forms.Label();
            this.btConfirmaResposta = new System.Windows.Forms.Button();
            this.dGV = new System.Windows.Forms.DataGridView();
            this.tbTipoSeguro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipoSeguro
            // 
            this.lblTipoSeguro.AutoSize = true;
            this.lblTipoSeguro.Location = new System.Drawing.Point(12, 9);
            this.lblTipoSeguro.Name = "lblTipoSeguro";
            this.lblTipoSeguro.Size = new System.Drawing.Size(121, 16);
            this.lblTipoSeguro.TabIndex = 1;
            this.lblTipoSeguro.Text = "Tipo de Seguro";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(12, 286);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(134, 16);
            this.lblValor.TabIndex = 2;
            this.lblValor.Text = "Valor do Seguro:";
            // 
            // lblMostraValor
            // 
            this.lblMostraValor.AutoSize = true;
            this.lblMostraValor.Location = new System.Drawing.Point(158, 286);
            this.lblMostraValor.Name = "lblMostraValor";
            this.lblMostraValor.Size = new System.Drawing.Size(82, 16);
            this.lblMostraValor.TabIndex = 3;
            this.lblMostraValor.Text = "R$ 199,99";
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(12, 73);
            this.tbDescricao.Multiline = true;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(355, 204);
            this.tbDescricao.TabIndex = 4;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(9, 54);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(177, 16);
            this.lblDescricao.TabIndex = 5;
            this.lblDescricao.Text = "Descrição do Problema";
            // 
            // btConfirmaCadastro
            // 
            this.btConfirmaCadastro.Location = new System.Drawing.Point(257, 283);
            this.btConfirmaCadastro.Name = "btConfirmaCadastro";
            this.btConfirmaCadastro.Size = new System.Drawing.Size(110, 23);
            this.btConfirmaCadastro.TabIndex = 6;
            this.btConfirmaCadastro.Text = "Confirmar";
            this.btConfirmaCadastro.UseVisualStyleBackColor = true;
            this.btConfirmaCadastro.Click += new System.EventHandler(this.btConfirmaCadastro_Click);
            // 
            // tbResposta
            // 
            this.tbResposta.Location = new System.Drawing.Point(383, 28);
            this.tbResposta.Multiline = true;
            this.tbResposta.Name = "tbResposta";
            this.tbResposta.Size = new System.Drawing.Size(275, 249);
            this.tbResposta.TabIndex = 7;
            this.tbResposta.Visible = false;
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(380, 9);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(127, 16);
            this.lblResposta.TabIndex = 8;
            this.lblResposta.Text = "RespostaSeguro";
            this.lblResposta.Visible = false;
            // 
            // btConfirmaResposta
            // 
            this.btConfirmaResposta.Location = new System.Drawing.Point(548, 283);
            this.btConfirmaResposta.Name = "btConfirmaResposta";
            this.btConfirmaResposta.Size = new System.Drawing.Size(110, 23);
            this.btConfirmaResposta.TabIndex = 9;
            this.btConfirmaResposta.Text = "Confirmar";
            this.btConfirmaResposta.UseVisualStyleBackColor = true;
            this.btConfirmaResposta.Visible = false;
            this.btConfirmaResposta.Click += new System.EventHandler(this.btConfirmaResposta_Click);
            // 
            // dGV
            // 
            this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV.Location = new System.Drawing.Point(12, 12);
            this.dGV.Name = "dGV";
            this.dGV.Size = new System.Drawing.Size(355, 294);
            this.dGV.TabIndex = 10;
            this.dGV.Visible = false;
            this.dGV.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGV_CellMouseClick);
            this.dGV.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGV_CellMouseDoubleClick);
            // 
            // tbTipoSeguro
            // 
            this.tbTipoSeguro.Location = new System.Drawing.Point(12, 28);
            this.tbTipoSeguro.Name = "tbTipoSeguro";
            this.tbTipoSeguro.Size = new System.Drawing.Size(355, 23);
            this.tbTipoSeguro.TabIndex = 11;
            // 
            // FormOrdemServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(684, 311);
            this.Controls.Add(this.dGV);
            this.Controls.Add(this.tbTipoSeguro);
            this.Controls.Add(this.btConfirmaResposta);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.tbResposta);
            this.Controls.Add(this.btConfirmaCadastro);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.lblMostraValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblTipoSeguro);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormOrdemServico";
            this.Text = "Seguros S.A.";
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTipoSeguro;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblMostraValor;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button btConfirmaCadastro;
        private System.Windows.Forms.TextBox tbResposta;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.Button btConfirmaResposta;
        private System.Windows.Forms.DataGridView dGV;
        private System.Windows.Forms.TextBox tbTipoSeguro;
    }
}
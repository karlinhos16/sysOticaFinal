namespace SysOticaForm
{
    partial class frmListarCliente
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.buttonListar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewCliente = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Número = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomePai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeMãe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profissão = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observações = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.textBoxPesquisar = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxPesquisar);
            this.groupBox1.Controls.Add(this.buttonPesquisar);
            this.groupBox1.Controls.Add(this.buttonListar);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dataGridViewCliente);
            this.groupBox1.Location = new System.Drawing.Point(-2, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(666, 365);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Location = new System.Drawing.Point(239, 15);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(75, 23);
            this.buttonPesquisar.TabIndex = 3;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // buttonListar
            // 
            this.buttonListar.Location = new System.Drawing.Point(556, 13);
            this.buttonListar.Name = "buttonListar";
            this.buttonListar.Size = new System.Drawing.Size(75, 23);
            this.buttonListar.TabIndex = 2;
            this.buttonListar.Text = "Listar";
            this.buttonListar.UseVisualStyleBackColor = true;
            this.buttonListar.Click += new System.EventHandler(this.buttonListar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(463, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Novo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCliente
            // 
            this.dataGridViewCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.DtNascimento,
            this.CPF,
            this.RG,
            this.Telefone,
            this.Celular,
            this.Telefone2,
            this.CEP,
            this.Endereço,
            this.Número,
            this.Bairro,
            this.Cidade,
            this.UF,
            this.Email,
            this.NomePai,
            this.NomeMãe,
            this.Profissão,
            this.Observações});
            this.dataGridViewCliente.Location = new System.Drawing.Point(14, 59);
            this.dataGridViewCliente.MultiSelect = false;
            this.dataGridViewCliente.Name = "dataGridViewCliente";
            this.dataGridViewCliente.ReadOnly = true;
            this.dataGridViewCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCliente.Size = new System.Drawing.Size(626, 300);
            this.dataGridViewCliente.TabIndex = 0;
            this.dataGridViewCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCliente_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "cl_id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "cl_nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // DtNascimento
            // 
            this.DtNascimento.DataPropertyName = "cl_datanascimento";
            this.DtNascimento.HeaderText = "DtNascimento";
            this.DtNascimento.Name = "DtNascimento";
            this.DtNascimento.ReadOnly = true;
            // 
            // CPF
            // 
            this.CPF.DataPropertyName = "cl_cpf";
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            // 
            // RG
            // 
            this.RG.DataPropertyName = "cl_rg";
            this.RG.HeaderText = "RG";
            this.RG.Name = "RG";
            this.RG.ReadOnly = true;
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "cl_telefone";
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            // 
            // Celular
            // 
            this.Celular.DataPropertyName = "cl_celular";
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            // 
            // Telefone2
            // 
            this.Telefone2.DataPropertyName = "cl_telefone2";
            this.Telefone2.HeaderText = "Telefone2";
            this.Telefone2.Name = "Telefone2";
            this.Telefone2.ReadOnly = true;
            // 
            // CEP
            // 
            this.CEP.DataPropertyName = "cl_cep";
            this.CEP.HeaderText = "CEP";
            this.CEP.Name = "CEP";
            this.CEP.ReadOnly = true;
            // 
            // Endereço
            // 
            this.Endereço.DataPropertyName = "cl_endereco";
            this.Endereço.HeaderText = "Endereço";
            this.Endereço.Name = "Endereço";
            this.Endereço.ReadOnly = true;
            // 
            // Número
            // 
            this.Número.DataPropertyName = "cl_numero";
            this.Número.HeaderText = "Número";
            this.Número.Name = "Número";
            this.Número.ReadOnly = true;
            // 
            // Bairro
            // 
            this.Bairro.DataPropertyName = "cl_bairro";
            this.Bairro.HeaderText = "Bairro";
            this.Bairro.Name = "Bairro";
            this.Bairro.ReadOnly = true;
            // 
            // Cidade
            // 
            this.Cidade.DataPropertyName = "cl_cidade";
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            this.Cidade.ReadOnly = true;
            // 
            // UF
            // 
            this.UF.DataPropertyName = "cl_uf";
            this.UF.HeaderText = "UF";
            this.UF.Name = "UF";
            this.UF.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "cl_email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // NomePai
            // 
            this.NomePai.DataPropertyName = "cl_nomepai";
            this.NomePai.HeaderText = "NomePai";
            this.NomePai.Name = "NomePai";
            this.NomePai.ReadOnly = true;
            // 
            // NomeMãe
            // 
            this.NomeMãe.DataPropertyName = "cl_nomemae";
            this.NomeMãe.HeaderText = "NomeMãe";
            this.NomeMãe.Name = "NomeMãe";
            this.NomeMãe.ReadOnly = true;
            // 
            // Profissão
            // 
            this.Profissão.DataPropertyName = "cl_profissao";
            this.Profissão.HeaderText = "Profissão";
            this.Profissão.Name = "Profissão";
            this.Profissão.ReadOnly = true;
            // 
            // Observações
            // 
            this.Observações.DataPropertyName = "cl_observacoes";
            this.Observações.HeaderText = "Observações";
            this.Observações.Name = "Observações";
            this.Observações.ReadOnly = true;
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(437, 388);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterar.TabIndex = 2;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(554, 388);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluir.TabIndex = 3;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // textBoxPesquisar
            // 
            this.textBoxPesquisar.Location = new System.Drawing.Point(15, 15);
            this.textBoxPesquisar.Name = "textBoxPesquisar";
            this.textBoxPesquisar.Size = new System.Drawing.Size(218, 20);
            this.textBoxPesquisar.TabIndex = 4;
            // 
            // frmListarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 423);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmListarCliente";
            this.Text = "frmListarCliente";
            this.Load += new System.EventHandler(this.frmListarCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.Button buttonListar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn RG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereço;
        private System.Windows.Forms.DataGridViewTextBoxColumn Número;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn UF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomePai;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeMãe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profissão;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observações;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.TextBox textBoxPesquisar;
    }
}
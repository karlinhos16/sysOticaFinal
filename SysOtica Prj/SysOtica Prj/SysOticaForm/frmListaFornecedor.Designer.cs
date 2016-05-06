namespace SysOticaForm
{
    partial class frmListaFornecedor
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
            this.dataGridFornecedor = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razaosocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inscricaoestadual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fantasia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomerepresentante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularrerepresentante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonerepresentante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFornecedor)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridFornecedor
            // 
            this.dataGridFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFornecedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.razaosocial,
            this.inscricaoestadual,
            this.fantasia,
            this.endereço,
            this.cidade,
            this.uf,
            this.bairro,
            this.cep,
            this.contato,
            this.telefone,
            this.fax,
            this.email,
            this.nomerepresentante,
            this.celularrerepresentante,
            this.telefonerepresentante,
            this.observacoes,
            this.cnpj});
            this.dataGridFornecedor.Location = new System.Drawing.Point(16, 49);
            this.dataGridFornecedor.MultiSelect = false;
            this.dataGridFornecedor.Name = "dataGridFornecedor";
            this.dataGridFornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridFornecedor.Size = new System.Drawing.Size(918, 256);
            this.dataGridFornecedor.TabIndex = 0;
            this.dataGridFornecedor.DoubleClick += new System.EventHandler(this.dataGridFornecedor_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnListar);
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.btnAlterar);
            this.groupBox1.Controls.Add(this.btnSair);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.dataGridFornecedor);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(940, 354);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(824, 14);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(110, 23);
            this.btnListar.TabIndex = 7;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(717, 325);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(101, 23);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(824, 325);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(110, 23);
            this.btnAlterar.TabIndex = 5;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(16, 325);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(104, 23);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair ";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(480, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(103, 23);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite a Razão Social para pesquisar: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(217, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 20);
            this.textBox1.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "fr_id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // razaosocial
            // 
            this.razaosocial.DataPropertyName = "fr_razaosocial";
            this.razaosocial.HeaderText = "Razão Social";
            this.razaosocial.Name = "razaosocial";
            // 
            // inscricaoestadual
            // 
            this.inscricaoestadual.DataPropertyName = "fr_inscricaoestadual";
            this.inscricaoestadual.HeaderText = "Insc.  Estadual";
            this.inscricaoestadual.Name = "inscricaoestadual";
            // 
            // fantasia
            // 
            this.fantasia.DataPropertyName = "fr_fantasia";
            this.fantasia.HeaderText = "Nome fantasia";
            this.fantasia.Name = "fantasia";
            // 
            // endereço
            // 
            this.endereço.DataPropertyName = " fr_endereco";
            this.endereço.HeaderText = "Endereço";
            this.endereço.Name = "endereço";
            // 
            // cidade
            // 
            this.cidade.DataPropertyName = "fr_cidade";
            this.cidade.HeaderText = "Cidade";
            this.cidade.Name = "cidade";
            // 
            // uf
            // 
            this.uf.DataPropertyName = "fr_uf";
            this.uf.HeaderText = "UF";
            this.uf.Name = "uf";
            // 
            // bairro
            // 
            this.bairro.DataPropertyName = "fr_bairro";
            this.bairro.HeaderText = "Bairro";
            this.bairro.Name = "bairro";
            // 
            // cep
            // 
            this.cep.DataPropertyName = "fr_cep";
            this.cep.HeaderText = "CEP";
            this.cep.Name = "cep";
            // 
            // contato
            // 
            this.contato.DataPropertyName = "fr_contato";
            this.contato.HeaderText = "Contato";
            this.contato.Name = "contato";
            // 
            // telefone
            // 
            this.telefone.DataPropertyName = "fr_telefone";
            this.telefone.HeaderText = "Telefone";
            this.telefone.Name = "telefone";
            // 
            // fax
            // 
            this.fax.DataPropertyName = "fr_fax";
            this.fax.HeaderText = "Fax";
            this.fax.Name = "fax";
            // 
            // email
            // 
            this.email.DataPropertyName = "fr_email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // nomerepresentante
            // 
            this.nomerepresentante.DataPropertyName = "fr_nomerepresentante";
            this.nomerepresentante.HeaderText = "Representante";
            this.nomerepresentante.Name = "nomerepresentante";
            // 
            // celularrerepresentante
            // 
            this.celularrerepresentante.DataPropertyName = "fr_celularrepresentante";
            this.celularrerepresentante.HeaderText = "Cel. Representante";
            this.celularrerepresentante.Name = "celularrerepresentante";
            // 
            // telefonerepresentante
            // 
            this.telefonerepresentante.DataPropertyName = "fr_telefonerepresentante";
            this.telefonerepresentante.HeaderText = "Tel. Representante";
            this.telefonerepresentante.Name = "telefonerepresentante";
            // 
            // observacoes
            // 
            this.observacoes.DataPropertyName = "fr_observacoes";
            this.observacoes.HeaderText = "Observacões";
            this.observacoes.Name = "observacoes";
            // 
            // cnpj
            // 
            this.cnpj.DataPropertyName = "fr_cnpj";
            this.cnpj.HeaderText = "CNPJ";
            this.cnpj.Name = "cnpj";
            // 
            // frmListaFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 378);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmListaFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar/Alterar Fornecedores";
            this.Load += new System.EventHandler(this.frmListaFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFornecedor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridFornecedor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn razaosocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn inscricaoestadual;
        private System.Windows.Forms.DataGridViewTextBoxColumn fantasia;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereço;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn uf;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn contato;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn fax;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomerepresentante;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularrerepresentante;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonerepresentante;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpj;
    }
}
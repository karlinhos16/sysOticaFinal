namespace SysOticaForm
{
    partial class frmListarProduto
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
            this.dataGridProduto = new System.Windows.Forms.DataGridView();
            this.textPesquisa = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grife = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueminimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridProduto
            // 
            this.dataGridProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.descricao,
            this.grife,
            this.valor,
            this.estoqueminimo,
            this.categoria,
            this.qtd});
            this.dataGridProduto.Location = new System.Drawing.Point(12, 53);
            this.dataGridProduto.MultiSelect = false;
            this.dataGridProduto.Name = "dataGridProduto";
            this.dataGridProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProduto.Size = new System.Drawing.Size(744, 202);
            this.dataGridProduto.TabIndex = 0;
            this.dataGridProduto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProduto_CellDoubleClick);
            // 
            // textPesquisa
            // 
            this.textPesquisa.Location = new System.Drawing.Point(138, 14);
            this.textPesquisa.Name = "textPesquisa";
            this.textPesquisa.Size = new System.Drawing.Size(260, 20);
            this.textPesquisa.TabIndex = 1;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(681, 283);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 2;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(590, 283);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(681, 12);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 4;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnPesquisar.Location = new System.Drawing.Point(425, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Digite um produto :";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(23, 283);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "pr_id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "pr_descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            // 
            // grife
            // 
            this.grife.DataPropertyName = "pr_grife";
            this.grife.HeaderText = "Grife";
            this.grife.Name = "grife";
            // 
            // valor
            // 
            this.valor.DataPropertyName = "pr_valor";
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            // 
            // estoqueminimo
            // 
            this.estoqueminimo.DataPropertyName = "pr_estoqueminimo";
            this.estoqueminimo.HeaderText = "Estoque Minimo";
            this.estoqueminimo.Name = "estoqueminimo";
            // 
            // categoria
            // 
            this.categoria.DataPropertyName = "pr_categoria";
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            // 
            // qtd
            // 
            this.qtd.DataPropertyName = "pr_qtd";
            this.qtd.HeaderText = "Quantidade";
            this.qtd.Name = "qtd";
            // 
            // frmListarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 318);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.textPesquisa);
            this.Controls.Add(this.dataGridProduto);
            this.MaximizeBox = false;
            this.Name = "frmListarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar/Alterar Produto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridProduto;
        private System.Windows.Forms.TextBox textPesquisa;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn grife;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoqueminimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtd;
    }
}
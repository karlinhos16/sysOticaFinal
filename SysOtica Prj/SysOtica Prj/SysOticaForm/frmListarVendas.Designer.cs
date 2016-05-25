namespace SysOticaForm
{
    partial class frmListarVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListarVendas));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vn_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rc_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vn_desconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vn_valortotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vn_formapagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vn_dtsaida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pr_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pr_descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pv_preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pv_qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonListar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(0, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vendas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vn_id,
            this.cl_nome,
            this.rc_id,
            this.vn_desconto,
            this.vn_valortotal,
            this.vn_formapagamento,
            this.vn_dtsaida});
            this.dataGridView1.Location = new System.Drawing.Point(0, 20);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(792, 145);
            this.dataGridView1.TabIndex = 0;
            // 
            // vn_id
            // 
            this.vn_id.DataPropertyName = "vn_id";
            this.vn_id.HeaderText = "Nota Fiscal";
            this.vn_id.Name = "vn_id";
            this.vn_id.ReadOnly = true;
            // 
            // cl_nome
            // 
            this.cl_nome.DataPropertyName = "cl_nome";
            this.cl_nome.HeaderText = "Cliente";
            this.cl_nome.Name = "cl_nome";
            this.cl_nome.ReadOnly = true;
            this.cl_nome.Width = 150;
            // 
            // rc_id
            // 
            this.rc_id.DataPropertyName = "rc_id";
            this.rc_id.HeaderText = "Receita";
            this.rc_id.Name = "rc_id";
            this.rc_id.ReadOnly = true;
            // 
            // vn_desconto
            // 
            this.vn_desconto.DataPropertyName = "vn_desconto";
            this.vn_desconto.HeaderText = "Desconto";
            this.vn_desconto.Name = "vn_desconto";
            this.vn_desconto.ReadOnly = true;
            // 
            // vn_valortotal
            // 
            this.vn_valortotal.DataPropertyName = "vn_valortotal";
            this.vn_valortotal.HeaderText = "Valor Total";
            this.vn_valortotal.Name = "vn_valortotal";
            this.vn_valortotal.ReadOnly = true;
            // 
            // vn_formapagamento
            // 
            this.vn_formapagamento.DataPropertyName = "vn_formapagamento";
            this.vn_formapagamento.HeaderText = "Forma de Pagamento";
            this.vn_formapagamento.Name = "vn_formapagamento";
            this.vn_formapagamento.ReadOnly = true;
            // 
            // vn_dtsaida
            // 
            this.vn_dtsaida.DataPropertyName = "vn_dtsaida";
            this.vn_dtsaida.HeaderText = "Data da Compra";
            this.vn_dtsaida.Name = "vn_dtsaida";
            this.vn_dtsaida.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(0, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(798, 175);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produtos";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pr_id,
            this.pr_descrição,
            this.pv_preco,
            this.pv_qtd});
            this.dataGridView2.Location = new System.Drawing.Point(115, 10);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(541, 150);
            this.dataGridView2.TabIndex = 0;
            // 
            // pr_id
            // 
            this.pr_id.DataPropertyName = "pr_id";
            this.pr_id.HeaderText = "ID Produto";
            this.pr_id.Name = "pr_id";
            this.pr_id.ReadOnly = true;
            // 
            // pr_descrição
            // 
            this.pr_descrição.DataPropertyName = "pr_descrição";
            this.pr_descrição.HeaderText = "Produto";
            this.pr_descrição.Name = "pr_descrição";
            this.pr_descrição.ReadOnly = true;
            this.pr_descrição.Width = 200;
            // 
            // pv_preco
            // 
            this.pv_preco.DataPropertyName = "pv_preco";
            this.pv_preco.HeaderText = "Preço";
            this.pv_preco.Name = "pv_preco";
            this.pv_preco.ReadOnly = true;
            // 
            // pv_qtd
            // 
            this.pv_qtd.DataPropertyName = "pv_qtd";
            this.pv_qtd.HeaderText = "Quantidade";
            this.pv_qtd.Name = "pv_qtd";
            this.pv_qtd.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonListar);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(798, 77);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "NF";
            // 
            // buttonListar
            // 
            this.buttonListar.Location = new System.Drawing.Point(699, 19);
            this.buttonListar.Name = "buttonListar";
            this.buttonListar.Size = new System.Drawing.Size(75, 45);
            this.buttonListar.TabIndex = 3;
            this.buttonListar.Text = "Listar";
            this.buttonListar.UseVisualStyleBackColor = true;
            this.buttonListar.Click += new System.EventHandler(this.buttonListar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite o nome do Cliente:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(563, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(252, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(284, 20);
            this.textBox1.TabIndex = 0;
            // 
            // frmListarVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 418);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListarVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LISTA DE VENDAS";
            this.Load += new System.EventHandler(this.frmListarVendas_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pr_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn pr_descrição;
        private System.Windows.Forms.DataGridViewTextBoxColumn pv_preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn pv_qtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn vn_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn rc_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn vn_desconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn vn_valortotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn vn_formapagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn vn_dtsaida;
        private System.Windows.Forms.Button buttonListar;
    }
}
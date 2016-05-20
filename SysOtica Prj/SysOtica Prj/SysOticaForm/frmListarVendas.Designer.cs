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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.vn_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rc_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pr_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pr_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pv_qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vn_valortotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(1, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(889, 384);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vn_id,
            this.cl_nome,
            this.rc_id,
            this.pr_descricao,
            this.pr_valor,
            this.pv_qtd,
            this.vn_valortotal});
            this.dataGridView1.Location = new System.Drawing.Point(73, 93);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(743, 275);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(222, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(517, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // vn_id
            // 
            this.vn_id.HeaderText = "Venda ID";
            this.vn_id.Name = "vn_id";
            this.vn_id.ReadOnly = true;
            // 
            // cl_nome
            // 
            this.cl_nome.HeaderText = "Cliente";
            this.cl_nome.Name = "cl_nome";
            this.cl_nome.ReadOnly = true;
            // 
            // rc_id
            // 
            this.rc_id.HeaderText = "Receita";
            this.rc_id.Name = "rc_id";
            this.rc_id.ReadOnly = true;
            // 
            // pr_descricao
            // 
            this.pr_descricao.HeaderText = "Produto";
            this.pr_descricao.Name = "pr_descricao";
            this.pr_descricao.ReadOnly = true;
            // 
            // pr_valor
            // 
            this.pr_valor.HeaderText = "Valor";
            this.pr_valor.Name = "pr_valor";
            this.pr_valor.ReadOnly = true;
            // 
            // pv_qtd
            // 
            this.pv_qtd.HeaderText = "Quantidade";
            this.pv_qtd.Name = "pv_qtd";
            this.pv_qtd.ReadOnly = true;
            // 
            // vn_valortotal
            // 
            this.vn_valortotal.HeaderText = "Valor Total";
            this.vn_valortotal.Name = "vn_valortotal";
            this.vn_valortotal.ReadOnly = true;
            // 
            // frmListarVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 440);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmListarVendas";
            this.Text = "frmListarVendas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vn_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn rc_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn pr_descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn pr_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn pv_qtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn vn_valortotal;
    }
}
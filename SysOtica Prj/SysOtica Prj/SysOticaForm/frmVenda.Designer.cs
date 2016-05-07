namespace SysOticaForm
{
    partial class frmVenda
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
            this.label1 = new System.Windows.Forms.Label();
            this.CboCliente = new System.Windows.Forms.ComboBox();
            this.BtnNovaVenda = new System.Windows.Forms.Button();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.textBoxQtd = new System.Windows.Forms.TextBox();
            this.textBoxCdVenda = new System.Windows.Forms.TextBox();
            this.comboBoxProduto = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // CboCliente
            // 
            this.CboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCliente.FormattingEnabled = true;
            this.CboCliente.Location = new System.Drawing.Point(128, 6);
            this.CboCliente.Name = "CboCliente";
            this.CboCliente.Size = new System.Drawing.Size(408, 21);
            this.CboCliente.TabIndex = 2;
            // 
            // BtnNovaVenda
            // 
            this.BtnNovaVenda.Location = new System.Drawing.Point(563, 9);
            this.BtnNovaVenda.Name = "BtnNovaVenda";
            this.BtnNovaVenda.Size = new System.Drawing.Size(75, 23);
            this.BtnNovaVenda.TabIndex = 3;
            this.BtnNovaVenda.Text = "Nova Venda";
            this.BtnNovaVenda.UseVisualStyleBackColor = true;
            this.BtnNovaVenda.Click += new System.EventHandler(this.BtnNovaVenda_Click_1);
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.textBoxID);
            this.GroupBox.Controls.Add(this.comboBox2);
            this.GroupBox.Controls.Add(this.textBox6);
            this.GroupBox.Controls.Add(this.textBox5);
            this.GroupBox.Controls.Add(this.textBox4);
            this.GroupBox.Controls.Add(this.label9);
            this.GroupBox.Controls.Add(this.label8);
            this.GroupBox.Controls.Add(this.label7);
            this.GroupBox.Controls.Add(this.label6);
            this.GroupBox.Controls.Add(this.button5);
            this.GroupBox.Controls.Add(this.button4);
            this.GroupBox.Controls.Add(this.button3);
            this.GroupBox.Controls.Add(this.button2);
            this.GroupBox.Controls.Add(this.groupBox1);
            this.GroupBox.Controls.Add(this.dataGridView1);
            this.GroupBox.Controls.Add(this.button1);
            this.GroupBox.Controls.Add(this.textBoxValor);
            this.GroupBox.Controls.Add(this.textBoxQtd);
            this.GroupBox.Controls.Add(this.textBoxCdVenda);
            this.GroupBox.Controls.Add(this.comboBoxProduto);
            this.GroupBox.Controls.Add(this.label5);
            this.GroupBox.Controls.Add(this.label4);
            this.GroupBox.Controls.Add(this.label3);
            this.GroupBox.Controls.Add(this.label2);
            this.GroupBox.Location = new System.Drawing.Point(0, 38);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(906, 691);
            this.GroupBox.TabIndex = 4;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Nova Venda";
            this.GroupBox.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Novo Item";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(128, 89);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.ReadOnly = true;
            this.textBoxValor.Size = new System.Drawing.Size(116, 20);
            this.textBoxValor.TabIndex = 7;
            // 
            // textBoxQtd
            // 
            this.textBoxQtd.Location = new System.Drawing.Point(128, 63);
            this.textBoxQtd.Name = "textBoxQtd";
            this.textBoxQtd.Size = new System.Drawing.Size(116, 20);
            this.textBoxQtd.TabIndex = 6;
            // 
            // textBoxCdVenda
            // 
            this.textBoxCdVenda.Location = new System.Drawing.Point(128, 10);
            this.textBoxCdVenda.Name = "textBoxCdVenda";
            this.textBoxCdVenda.ReadOnly = true;
            this.textBoxCdVenda.Size = new System.Drawing.Size(63, 20);
            this.textBoxCdVenda.TabIndex = 5;
            // 
            // comboBoxProduto
            // 
            this.comboBoxProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProduto.FormattingEnabled = true;
            this.comboBoxProduto.Location = new System.Drawing.Point(128, 36);
            this.comboBoxProduto.Name = "comboBoxProduto";
            this.comboBoxProduto.Size = new System.Drawing.Size(408, 21);
            this.comboBoxProduto.TabIndex = 4;
            this.comboBoxProduto.SelectedIndexChanged += new System.EventHandler(this.comboBoxProduto_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Valor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Quantidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código da Venda:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Produto,
            this.Quantidade,
            this.Valor,
            this.ValorTotal});
            this.dataGridView1.Location = new System.Drawing.Point(0, 146);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(900, 265);
            this.dataGridView1.TabIndex = 0;
            // 
            // ValorTotal
            // 
            this.ValorTotal.HeaderText = "Valor Total";
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.ReadOnly = true;
            this.ValorTotal.Width = 200;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 150;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // Produto
            // 
            this.Produto.DataPropertyName = "pr_descricao";
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            this.Produto.Width = 300;
            // 
            // Código
            // 
            this.Código.DataPropertyName = "pr_id";
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(7, 428);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(890, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Receita";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "À Vista",
            "Débito",
            "Crédito"});
            this.comboBox2.Location = new System.Drawing.Point(434, 642);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 30;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(434, 611);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 29;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(434, 574);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 28;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(434, 543);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(320, 651);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Forma de Pagamento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(369, 614);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Valor Pago:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(369, 581);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Desconto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(391, 550);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Valor:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(657, 604);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 22;
            this.button5.Text = "Finalizar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(174, 641);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "Imprimir";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(174, 594);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Finalizar Venda";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(174, 550);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Finalizar Pedido";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(563, 36);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(63, 20);
            this.textBoxID.TabIndex = 31;
            // 
            // frmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 741);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.BtnNovaVenda);
            this.Controls.Add(this.CboCliente);
            this.Controls.Add(this.label1);
            this.Name = "frmVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.frmVenda_Load);
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboCliente;
        private System.Windows.Forms.Button BtnNovaVenda;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.TextBox textBoxQtd;
        private System.Windows.Forms.TextBox textBoxCdVenda;
        private System.Windows.Forms.ComboBox comboBoxProduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxID;
    }
}
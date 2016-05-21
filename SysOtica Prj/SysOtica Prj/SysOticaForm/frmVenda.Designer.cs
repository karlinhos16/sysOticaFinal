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
            this.textBoxPegarNome = new System.Windows.Forms.TextBox();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.dateTimePickerAtual = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxQtdMult = new System.Windows.Forms.TextBox();
            this.textBoxPegarProduto = new System.Windows.Forms.TextBox();
            this.textBoxProdID = new System.Windows.Forms.TextBox();
            this.comboBoxFP = new System.Windows.Forms.ComboBox();
            this.textBoxValorPago = new System.Windows.Forms.TextBox();
            this.textBoxDes = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIdReceita = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridRec = new System.Windows.Forms.DataGridView();
            this.id_receita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomemedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewItens = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonNovoItem = new System.Windows.Forms.Button();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.textBoxQtd = new System.Windows.Forms.TextBox();
            this.comboBoxProduto = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnNovaVenda = new System.Windows.Forms.Button();
            this.CboCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItens)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPegarNome
            // 
            this.textBoxPegarNome.Location = new System.Drawing.Point(635, 12);
            this.textBoxPegarNome.Name = "textBoxPegarNome";
            this.textBoxPegarNome.Size = new System.Drawing.Size(59, 20);
            this.textBoxPegarNome.TabIndex = 10;
            this.textBoxPegarNome.Visible = false;
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.buttonCancelar);
            this.GroupBox.Controls.Add(this.buttonExcluir);
            this.GroupBox.Controls.Add(this.dateTimePickerAtual);
            this.GroupBox.Controls.Add(this.label10);
            this.GroupBox.Controls.Add(this.textBoxQtdMult);
            this.GroupBox.Controls.Add(this.textBoxPegarProduto);
            this.GroupBox.Controls.Add(this.textBoxProdID);
            this.GroupBox.Controls.Add(this.comboBoxFP);
            this.GroupBox.Controls.Add(this.textBoxValorPago);
            this.GroupBox.Controls.Add(this.textBoxDes);
            this.GroupBox.Controls.Add(this.textBox4);
            this.GroupBox.Controls.Add(this.label9);
            this.GroupBox.Controls.Add(this.label8);
            this.GroupBox.Controls.Add(this.label7);
            this.GroupBox.Controls.Add(this.label6);
            this.GroupBox.Controls.Add(this.button5);
            this.GroupBox.Controls.Add(this.button3);
            this.GroupBox.Controls.Add(this.button2);
            this.GroupBox.Controls.Add(this.groupBox1);
            this.GroupBox.Controls.Add(this.dataGridViewItens);
            this.GroupBox.Controls.Add(this.buttonNovoItem);
            this.GroupBox.Controls.Add(this.textBoxValor);
            this.GroupBox.Controls.Add(this.textBoxQtd);
            this.GroupBox.Controls.Add(this.comboBoxProduto);
            this.GroupBox.Controls.Add(this.label5);
            this.GroupBox.Controls.Add(this.label4);
            this.GroupBox.Controls.Add(this.label3);
            this.GroupBox.Controls.Add(this.label2);
            this.GroupBox.Location = new System.Drawing.Point(1, 41);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(906, 691);
            this.GroupBox.TabIndex = 9;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Nova Venda";
            this.GroupBox.Visible = false;
            this.GroupBox.Enter += new System.EventHandler(this.GroupBox_Enter);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(616, 592);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 37;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(778, 114);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluir.TabIndex = 36;
            this.buttonExcluir.Text = "Excluir Item";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // dateTimePickerAtual
            // 
            this.dateTimePickerAtual.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePickerAtual.Enabled = false;
            this.dateTimePickerAtual.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerAtual.Location = new System.Drawing.Point(663, 555);
            this.dateTimePickerAtual.Name = "dateTimePickerAtual";
            this.dateTimePickerAtual.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePickerAtual.Size = new System.Drawing.Size(92, 20);
            this.dateTimePickerAtual.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(624, 561);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Data:";
            // 
            // textBoxQtdMult
            // 
            this.textBoxQtdMult.Location = new System.Drawing.Point(128, 116);
            this.textBoxQtdMult.Name = "textBoxQtdMult";
            this.textBoxQtdMult.Size = new System.Drawing.Size(100, 20);
            this.textBoxQtdMult.TabIndex = 33;
            this.textBoxQtdMult.Visible = false;
            // 
            // textBoxPegarProduto
            // 
            this.textBoxPegarProduto.Location = new System.Drawing.Point(595, 36);
            this.textBoxPegarProduto.Name = "textBoxPegarProduto";
            this.textBoxPegarProduto.Size = new System.Drawing.Size(240, 20);
            this.textBoxPegarProduto.TabIndex = 32;
            this.textBoxPegarProduto.Visible = false;
            // 
            // textBoxProdID
            // 
            this.textBoxProdID.Location = new System.Drawing.Point(128, 35);
            this.textBoxProdID.Name = "textBoxProdID";
            this.textBoxProdID.ReadOnly = true;
            this.textBoxProdID.Size = new System.Drawing.Size(63, 20);
            this.textBoxProdID.TabIndex = 31;
            // 
            // comboBoxFP
            // 
            this.comboBoxFP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFP.FormattingEnabled = true;
            this.comboBoxFP.Items.AddRange(new object[] {
            "À Vista",
            "Débito",
            "Crédito"});
            this.comboBoxFP.Location = new System.Drawing.Point(404, 653);
            this.comboBoxFP.Name = "comboBoxFP";
            this.comboBoxFP.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFP.TabIndex = 30;
            this.comboBoxFP.SelectedIndexChanged += new System.EventHandler(this.comboBoxFP_SelectedIndexChanged);
            // 
            // textBoxValorPago
            // 
            this.textBoxValorPago.Location = new System.Drawing.Point(404, 622);
            this.textBoxValorPago.Name = "textBoxValorPago";
            this.textBoxValorPago.ReadOnly = true;
            this.textBoxValorPago.Size = new System.Drawing.Size(100, 20);
            this.textBoxValorPago.TabIndex = 29;
            this.textBoxValorPago.TextChanged += new System.EventHandler(this.textBoxValorPago_TextChanged);
            // 
            // textBoxDes
            // 
            this.textBoxDes.Location = new System.Drawing.Point(404, 585);
            this.textBoxDes.Name = "textBoxDes";
            this.textBoxDes.Size = new System.Drawing.Size(100, 20);
            this.textBoxDes.TabIndex = 28;
            this.textBoxDes.Text = "0";
            this.textBoxDes.TextChanged += new System.EventHandler(this.textBoxDes_TextChanged);
            this.textBoxDes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDes_KeyPress);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(404, 554);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 27;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(290, 662);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Forma de Pagamento:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(339, 625);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Valor Pago:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(339, 592);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Desconto:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(361, 561);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Valor:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(697, 592);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 22;
            this.button5.Text = "Finalizar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(144, 605);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Finalizar Venda";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(144, 561);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Finalizar Pedido";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIdReceita);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.dataGridRec);
            this.groupBox1.Location = new System.Drawing.Point(7, 365);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(890, 183);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Receita";
            // 
            // txtIdReceita
            // 
            this.txtIdReceita.Enabled = false;
            this.txtIdReceita.Location = new System.Drawing.Point(121, 17);
            this.txtIdReceita.Name = "txtIdReceita";
            this.txtIdReceita.Size = new System.Drawing.Size(80, 20);
            this.txtIdReceita.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "Código da Receita:";
            // 
            // dataGridRec
            // 
            this.dataGridRec.AllowUserToAddRows = false;
            this.dataGridRec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridRec.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_receita,
            this.nomemedico,
            this.Obs,
            this.dt_entrada,
            this.validade});
            this.dataGridRec.Location = new System.Drawing.Point(9, 49);
            this.dataGridRec.MultiSelect = false;
            this.dataGridRec.Name = "dataGridRec";
            this.dataGridRec.ReadOnly = true;
            this.dataGridRec.RowHeadersVisible = false;
            this.dataGridRec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridRec.Size = new System.Drawing.Size(875, 128);
            this.dataGridRec.TabIndex = 0;
            this.dataGridRec.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRec_CellClick);
            // 
            // id_receita
            // 
            this.id_receita.DataPropertyName = "rc_id";
            this.id_receita.HeaderText = "ID Receita";
            this.id_receita.Name = "id_receita";
            this.id_receita.ReadOnly = true;
            // 
            // nomemedico
            // 
            this.nomemedico.DataPropertyName = "rc_nomemedico";
            this.nomemedico.HeaderText = "Médico";
            this.nomemedico.Name = "nomemedico";
            this.nomemedico.ReadOnly = true;
            // 
            // Obs
            // 
            this.Obs.DataPropertyName = "rc_observacoes";
            this.Obs.HeaderText = "Observações";
            this.Obs.Name = "Obs";
            this.Obs.ReadOnly = true;
            // 
            // dt_entrada
            // 
            this.dt_entrada.DataPropertyName = "rc_data";
            this.dt_entrada.HeaderText = "Data de entrada";
            this.dt_entrada.Name = "dt_entrada";
            this.dt_entrada.ReadOnly = true;
            // 
            // validade
            // 
            this.validade.DataPropertyName = "rc_dtavencimento";
            this.validade.HeaderText = "Data de Validade";
            this.validade.Name = "validade";
            this.validade.ReadOnly = true;
            // 
            // dataGridViewItens
            // 
            this.dataGridViewItens.AllowUserToAddRows = false;
            this.dataGridViewItens.AllowUserToDeleteRows = false;
            this.dataGridViewItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Produto,
            this.Quantidade,
            this.Valor,
            this.ValorTotal});
            this.dataGridViewItens.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.dataGridViewItens.Location = new System.Drawing.Point(0, 146);
            this.dataGridViewItens.MultiSelect = false;
            this.dataGridViewItens.Name = "dataGridViewItens";
            this.dataGridViewItens.ReadOnly = true;
            this.dataGridViewItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewItens.Size = new System.Drawing.Size(900, 213);
            this.dataGridViewItens.TabIndex = 0;
            // 
            // Código
            // 
            this.Código.DataPropertyName = "pr_id";
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.ReadOnly = true;
            // 
            // Produto
            // 
            this.Produto.DataPropertyName = "pr_descricao";
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            this.Produto.Width = 300;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 150;
            // 
            // ValorTotal
            // 
            this.ValorTotal.HeaderText = "Valor Total";
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.ReadOnly = true;
            this.ValorTotal.Width = 200;
            // 
            // buttonNovoItem
            // 
            this.buttonNovoItem.Location = new System.Drawing.Point(272, 87);
            this.buttonNovoItem.Name = "buttonNovoItem";
            this.buttonNovoItem.Size = new System.Drawing.Size(75, 23);
            this.buttonNovoItem.TabIndex = 8;
            this.buttonNovoItem.Text = "Novo Item";
            this.buttonNovoItem.UseVisualStyleBackColor = true;
            this.buttonNovoItem.Click += new System.EventHandler(this.buttonNovoItem_Click);
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
            this.textBoxQtd.Text = "1";
            this.textBoxQtd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxQtd_KeyPress);
            // 
            // comboBoxProduto
            // 
            this.comboBoxProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProduto.FormattingEnabled = true;
            this.comboBoxProduto.Location = new System.Drawing.Point(250, 35);
            this.comboBoxProduto.Name = "comboBoxProduto";
            this.comboBoxProduto.Size = new System.Drawing.Size(339, 21);
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
            this.label3.Location = new System.Drawing.Point(197, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código da Produto:";
            // 
            // BtnNovaVenda
            // 
            this.BtnNovaVenda.Location = new System.Drawing.Point(554, 9);
            this.BtnNovaVenda.Name = "BtnNovaVenda";
            this.BtnNovaVenda.Size = new System.Drawing.Size(75, 23);
            this.BtnNovaVenda.TabIndex = 8;
            this.BtnNovaVenda.Text = "Nova Venda";
            this.BtnNovaVenda.UseVisualStyleBackColor = true;
            this.BtnNovaVenda.Click += new System.EventHandler(this.BtnNovaVenda_Click);
            // 
            // CboCliente
            // 
            this.CboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCliente.FormattingEnabled = true;
            this.CboCliente.Location = new System.Drawing.Point(129, 9);
            this.CboCliente.Name = "CboCliente";
            this.CboCliente.Size = new System.Drawing.Size(408, 21);
            this.CboCliente.TabIndex = 7;
            this.CboCliente.SelectedIndexChanged += new System.EventHandler(this.CboCliente_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cliente:";
            // 
            // frmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 741);
            this.Controls.Add(this.textBoxPegarNome);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPegarNome;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.DateTimePicker dateTimePickerAtual;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxQtdMult;
        private System.Windows.Forms.TextBox textBoxPegarProduto;
        private System.Windows.Forms.TextBox textBoxProdID;
        private System.Windows.Forms.ComboBox comboBoxFP;
        private System.Windows.Forms.TextBox textBoxValorPago;
        private System.Windows.Forms.TextBox textBoxDes;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
        private System.Windows.Forms.Button buttonNovoItem;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.TextBox textBoxQtd;
        private System.Windows.Forms.ComboBox comboBoxProduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnNovaVenda;
        private System.Windows.Forms.ComboBox CboCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox txtIdReceita;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridRec;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_receita;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomemedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Obs;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn validade;
    }
}
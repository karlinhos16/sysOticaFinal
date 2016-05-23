namespace SysOticaForm
{
    partial class frmVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendas));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePickerAtual = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxFP = new System.Windows.Forms.ComboBox();
            this.textBoxValorPago = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtIdReceita = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridRec = new System.Windows.Forms.DataGridView();
            this.id_receita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomemedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.textBoxQtdMult = new System.Windows.Forms.TextBox();
            this.textBoxPegarProduto = new System.Windows.Forms.TextBox();
            this.textBoxProdID = new System.Windows.Forms.TextBox();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonIncluir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRec)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItens)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.dateTimePickerAtual);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.comboBoxFP);
            this.groupBox4.Controls.Add(this.textBoxValorPago);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.textBoxDes);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(9, 466);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(922, 111);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Venda";
            // 
            // button1
            // 
            this.button1.Image = global::SysOticaForm.Properties.Resources.carrinho;
            this.button1.Location = new System.Drawing.Point(20, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 73);
            this.button1.TabIndex = 73;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(803, 85);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 23);
            this.button4.TabIndex = 72;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(803, 56);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 23);
            this.button3.TabIndex = 71;
            this.button3.Text = "Nova Venda";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(802, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 70;
            this.button2.Text = "Finalizar Venda";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePickerAtual
            // 
            this.dateTimePickerAtual.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePickerAtual.Enabled = false;
            this.dateTimePickerAtual.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerAtual.Location = new System.Drawing.Point(607, 43);
            this.dateTimePickerAtual.Name = "dateTimePickerAtual";
            this.dateTimePickerAtual.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePickerAtual.Size = new System.Drawing.Size(92, 20);
            this.dateTimePickerAtual.TabIndex = 69;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(575, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 68;
            this.label10.Text = "Data:";
            // 
            // comboBoxFP
            // 
            this.comboBoxFP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFP.FormattingEnabled = true;
            this.comboBoxFP.Items.AddRange(new object[] {
            "À Vista",
            "Débito",
            "Crédito"});
            this.comboBoxFP.Location = new System.Drawing.Point(421, 39);
            this.comboBoxFP.Name = "comboBoxFP";
            this.comboBoxFP.Size = new System.Drawing.Size(117, 21);
            this.comboBoxFP.TabIndex = 67;
            // 
            // textBoxValorPago
            // 
            this.textBoxValorPago.Location = new System.Drawing.Point(185, 74);
            this.textBoxValorPago.Name = "textBoxValorPago";
            this.textBoxValorPago.ReadOnly = true;
            this.textBoxValorPago.Size = new System.Drawing.Size(97, 20);
            this.textBoxValorPago.TabIndex = 66;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(304, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 65;
            this.label9.Text = "Forma de Pagamento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(112, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 64;
            this.label8.Text = "Valor Pago:";
            // 
            // textBoxDes
            // 
            this.textBoxDes.Location = new System.Drawing.Point(185, 40);
            this.textBoxDes.Name = "textBoxDes";
            this.textBoxDes.Size = new System.Drawing.Size(63, 20);
            this.textBoxDes.TabIndex = 63;
            this.textBoxDes.Text = "0";
            this.textBoxDes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDes_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 61;
            this.label7.Text = "Desconto:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(755, 247);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(141, 20);
            this.textBox4.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(664, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "Valor Total:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtIdReceita);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.dataGridRec);
            this.groupBox3.Location = new System.Drawing.Point(9, 340);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(922, 120);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Receita";
            // 
            // txtIdReceita
            // 
            this.txtIdReceita.Enabled = false;
            this.txtIdReceita.Location = new System.Drawing.Point(127, 12);
            this.txtIdReceita.Name = "txtIdReceita";
            this.txtIdReceita.Size = new System.Drawing.Size(80, 20);
            this.txtIdReceita.TabIndex = 43;
            this.txtIdReceita.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 13);
            this.label11.TabIndex = 44;
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
            this.dataGridRec.Location = new System.Drawing.Point(11, 38);
            this.dataGridRec.MultiSelect = false;
            this.dataGridRec.Name = "dataGridRec";
            this.dataGridRec.ReadOnly = true;
            this.dataGridRec.RowHeadersVisible = false;
            this.dataGridRec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridRec.Size = new System.Drawing.Size(888, 76);
            this.dataGridRec.TabIndex = 42;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonExcluir);
            this.groupBox2.Controls.Add(this.textBoxQtdMult);
            this.groupBox2.Controls.Add(this.textBoxPegarProduto);
            this.groupBox2.Controls.Add(this.textBoxProdID);
            this.groupBox2.Controls.Add(this.dataGridViewItens);
            this.groupBox2.Controls.Add(this.buttonNovoItem);
            this.groupBox2.Controls.Add(this.textBoxValor);
            this.groupBox2.Controls.Add(this.textBoxQtd);
            this.groupBox2.Controls.Add(this.comboBoxProduto);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(9, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(922, 277);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Itens da Venda";
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Image = global::SysOticaForm.Properties.Resources.retirar;
            this.buttonExcluir.Location = new System.Drawing.Point(837, 75);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(45, 47);
            this.buttonExcluir.TabIndex = 49;
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // textBoxQtdMult
            // 
            this.textBoxQtdMult.Location = new System.Drawing.Point(132, 98);
            this.textBoxQtdMult.Name = "textBoxQtdMult";
            this.textBoxQtdMult.Size = new System.Drawing.Size(100, 20);
            this.textBoxQtdMult.TabIndex = 48;
            this.textBoxQtdMult.Visible = false;
            // 
            // textBoxPegarProduto
            // 
            this.textBoxPegarProduto.Location = new System.Drawing.Point(599, 18);
            this.textBoxPegarProduto.Name = "textBoxPegarProduto";
            this.textBoxPegarProduto.Size = new System.Drawing.Size(240, 20);
            this.textBoxPegarProduto.TabIndex = 47;
            this.textBoxPegarProduto.Visible = false;
            // 
            // textBoxProdID
            // 
            this.textBoxProdID.Location = new System.Drawing.Point(132, 17);
            this.textBoxProdID.Name = "textBoxProdID";
            this.textBoxProdID.ReadOnly = true;
            this.textBoxProdID.Size = new System.Drawing.Size(63, 20);
            this.textBoxProdID.TabIndex = 46;
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
            this.dataGridViewItens.Location = new System.Drawing.Point(23, 128);
            this.dataGridViewItens.MultiSelect = false;
            this.dataGridViewItens.Name = "dataGridViewItens";
            this.dataGridViewItens.ReadOnly = true;
            this.dataGridViewItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewItens.Size = new System.Drawing.Size(876, 108);
            this.dataGridViewItens.TabIndex = 37;
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
            this.buttonNovoItem.Image = ((System.Drawing.Image)(resources.GetObject("buttonNovoItem.Image")));
            this.buttonNovoItem.Location = new System.Drawing.Point(768, 75);
            this.buttonNovoItem.Name = "buttonNovoItem";
            this.buttonNovoItem.Size = new System.Drawing.Size(48, 47);
            this.buttonNovoItem.TabIndex = 45;
            this.buttonNovoItem.UseVisualStyleBackColor = true;
            this.buttonNovoItem.Click += new System.EventHandler(this.buttonNovoItem_Click);
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(132, 71);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.ReadOnly = true;
            this.textBoxValor.Size = new System.Drawing.Size(63, 20);
            this.textBoxValor.TabIndex = 44;
            // 
            // textBoxQtd
            // 
            this.textBoxQtd.Location = new System.Drawing.Point(132, 45);
            this.textBoxQtd.Name = "textBoxQtd";
            this.textBoxQtd.Size = new System.Drawing.Size(63, 20);
            this.textBoxQtd.TabIndex = 43;
            this.textBoxQtd.Text = "1";
            this.textBoxQtd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxQtd_KeyPress);
            // 
            // comboBoxProduto
            // 
            this.comboBoxProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProduto.FormattingEnabled = true;
            this.comboBoxProduto.Location = new System.Drawing.Point(254, 17);
            this.comboBoxProduto.Name = "comboBoxProduto";
            this.comboBoxProduto.Size = new System.Drawing.Size(339, 21);
            this.comboBoxProduto.TabIndex = 42;
            this.comboBoxProduto.SelectedIndexChanged += new System.EventHandler(this.comboBoxProduto_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Valor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Quantidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Código da Produto:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonIncluir);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.comboBoxCliente);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(9, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(922, 56);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // buttonIncluir
            // 
            this.buttonIncluir.Image = global::SysOticaForm.Properties.Resources.save;
            this.buttonIncluir.Location = new System.Drawing.Point(616, 7);
            this.buttonIncluir.Name = "buttonIncluir";
            this.buttonIncluir.Size = new System.Drawing.Size(52, 40);
            this.buttonIncluir.TabIndex = 12;
            this.buttonIncluir.UseVisualStyleBackColor = true;
            this.buttonIncluir.Click += new System.EventHandler(this.buttonIncluir_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(53, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.Visible = false;
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(192, 19);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(408, 21);
            this.comboBoxCliente.TabIndex = 10;
            this.comboBoxCliente.SelectedIndexChanged += new System.EventHandler(this.comboBoxCliente_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(144, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Cliente:";
            // 
            // frmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 587);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VENDAS";
            this.Load += new System.EventHandler(this.frmVendas_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRec)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItens)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePickerAtual;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxFP;
        private System.Windows.Forms.TextBox textBoxValorPago;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxDes;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtIdReceita;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridRec;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_receita;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomemedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Obs;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn validade;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.TextBox textBoxQtdMult;
        private System.Windows.Forms.TextBox textBoxPegarProduto;
        private System.Windows.Forms.TextBox textBoxProdID;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxCliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonIncluir;
    }
}
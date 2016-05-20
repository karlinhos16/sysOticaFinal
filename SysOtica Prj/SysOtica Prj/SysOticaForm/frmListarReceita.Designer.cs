namespace SysOticaForm
{
    partial class frmListarReceita
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
            this.DataGridreceita = new System.Windows.Forms.DataGridView();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lodesferico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eesferico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.podesferico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poeesferico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lodcilindrico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loecilindrico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.podcilindrico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poecilindirco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lodeixo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loeeixo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.podeixo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poeeixo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lodaltura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loealtura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.podaltura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poealtura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loddnp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loednp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poddnp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poednp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomemedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtvalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridreceita)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridreceita
            // 
            this.DataGridreceita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridreceita.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.lodesferico,
            this.eesferico,
            this.podesferico,
            this.poeesferico,
            this.lodcilindrico,
            this.loecilindrico,
            this.podcilindrico,
            this.poecilindirco,
            this.lodeixo,
            this.loeeixo,
            this.podeixo,
            this.poeeixo,
            this.lodaltura,
            this.loealtura,
            this.podaltura,
            this.poealtura,
            this.loddnp,
            this.loednp,
            this.poddnp,
            this.poednp,
            this.observa,
            this.nomemedico,
            this.data,
            this.dtvalidade});
            this.DataGridreceita.Location = new System.Drawing.Point(12, 64);
            this.DataGridreceita.MultiSelect = false;
            this.DataGridreceita.Name = "DataGridreceita";
            this.DataGridreceita.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridreceita.Size = new System.Drawing.Size(958, 340);
            this.DataGridreceita.TabIndex = 1;
            this.DataGridreceita.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.receitaDataGridView_CellDoubleClick);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(206, 29);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(252, 20);
            this.txtPesquisa.TabIndex = 2;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(895, 410);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(814, 410);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(12, 410);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(895, 27);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 6;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(486, 27);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 7;
            this.btnPesquisar.Text = "Pesquisa";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Digite o nome do médico :";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(733, 410);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "rc_id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // lodesferico
            // 
            this.lodesferico.DataPropertyName = "rc_lodesferico";
            this.lodesferico.HeaderText = "Longe OD. Esférico";
            this.lodesferico.Name = "lodesferico";
            // 
            // eesferico
            // 
            this.eesferico.DataPropertyName = "rc_loeesferico";
            this.eesferico.HeaderText = "Longe OE. Esférico";
            this.eesferico.Name = "eesferico";
            // 
            // podesferico
            // 
            this.podesferico.DataPropertyName = "rc_podesferico";
            this.podesferico.HeaderText = "Perto OD. Esférico";
            this.podesferico.Name = "podesferico";
            // 
            // poeesferico
            // 
            this.poeesferico.DataPropertyName = "rc_poeesferico";
            this.poeesferico.HeaderText = "Perto OE. Esférico";
            this.poeesferico.Name = "poeesferico";
            // 
            // lodcilindrico
            // 
            this.lodcilindrico.DataPropertyName = "rc_lodcilindrico";
            this.lodcilindrico.HeaderText = "Longe OD. cilindrico";
            this.lodcilindrico.Name = "lodcilindrico";
            // 
            // loecilindrico
            // 
            this.loecilindrico.DataPropertyName = "rc_loecilindrico";
            this.loecilindrico.HeaderText = "Longe OE. cilíndrico";
            this.loecilindrico.Name = "loecilindrico";
            // 
            // podcilindrico
            // 
            this.podcilindrico.DataPropertyName = "rc_podcilindrico";
            this.podcilindrico.HeaderText = "Perto OD. cilindrico";
            this.podcilindrico.Name = "podcilindrico";
            // 
            // poecilindirco
            // 
            this.poecilindirco.DataPropertyName = "rc_poecilindrico";
            this.poecilindirco.HeaderText = "Perto OE. cilindrico";
            this.poecilindirco.Name = "poecilindirco";
            // 
            // lodeixo
            // 
            this.lodeixo.DataPropertyName = "rc_lodeixo";
            this.lodeixo.HeaderText = "Longe OD. eixo";
            this.lodeixo.Name = "lodeixo";
            // 
            // loeeixo
            // 
            this.loeeixo.DataPropertyName = "rc_loeeixo";
            this.loeeixo.HeaderText = "Longe OE. eixo";
            this.loeeixo.Name = "loeeixo";
            // 
            // podeixo
            // 
            this.podeixo.DataPropertyName = "rc_podeixo";
            this.podeixo.HeaderText = "Perto OD. eixo";
            this.podeixo.Name = "podeixo";
            // 
            // poeeixo
            // 
            this.poeeixo.DataPropertyName = "rc_poeeixo";
            this.poeeixo.HeaderText = "Perto OE. eixo";
            this.poeeixo.Name = "poeeixo";
            // 
            // lodaltura
            // 
            this.lodaltura.DataPropertyName = "rc_lodaltura";
            this.lodaltura.HeaderText = "Longe OD. altura";
            this.lodaltura.Name = "lodaltura";
            // 
            // loealtura
            // 
            this.loealtura.DataPropertyName = "rc_loealtura";
            this.loealtura.HeaderText = "Longe OE. altura";
            this.loealtura.Name = "loealtura";
            // 
            // podaltura
            // 
            this.podaltura.DataPropertyName = "rc_podaltura";
            this.podaltura.HeaderText = "Perto OD. altura";
            this.podaltura.Name = "podaltura";
            // 
            // poealtura
            // 
            this.poealtura.DataPropertyName = "rc_poealtura";
            this.poealtura.HeaderText = "Perto OD. altura";
            this.poealtura.Name = "poealtura";
            // 
            // loddnp
            // 
            this.loddnp.DataPropertyName = "rc_loddnp";
            this.loddnp.HeaderText = "Longe OD. dnp";
            this.loddnp.Name = "loddnp";
            // 
            // loednp
            // 
            this.loednp.DataPropertyName = "rc_loednp";
            this.loednp.HeaderText = "Longe OE. dnp";
            this.loednp.Name = "loednp";
            // 
            // poddnp
            // 
            this.poddnp.DataPropertyName = "rc_poddnp";
            this.poddnp.HeaderText = "Perto OD. dnp";
            this.poddnp.Name = "poddnp";
            // 
            // poednp
            // 
            this.poednp.DataPropertyName = "rc_poednp";
            this.poednp.HeaderText = "Perto OE. dnp";
            this.poednp.Name = "poednp";
            // 
            // observa
            // 
            this.observa.DataPropertyName = "rc_observacoes";
            this.observa.HeaderText = "Observações";
            this.observa.Name = "observa";
            // 
            // nomemedico
            // 
            this.nomemedico.DataPropertyName = "rc_nomemedico";
            this.nomemedico.HeaderText = "Nome do médico";
            this.nomemedico.Name = "nomemedico";
            // 
            // data
            // 
            this.data.DataPropertyName = "rc_data";
            this.data.HeaderText = "Data de entrada";
            this.data.Name = "data";
            // 
            // dtvalidade
            // 
            this.dtvalidade.DataPropertyName = "rc_dtavencimento";
            this.dtvalidade.HeaderText = "Validade ";
            this.dtvalidade.Name = "dtvalidade";
            // 
            // frmListarReceita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 458);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.DataGridreceita);
            this.MaximizeBox = false;
            this.Name = "frmListarReceita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar/Alterar Receita";
            this.Load += new System.EventHandler(this.frmListarReceita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridreceita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DataGridreceita;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn lodesferico;
        private System.Windows.Forms.DataGridViewTextBoxColumn eesferico;
        private System.Windows.Forms.DataGridViewTextBoxColumn podesferico;
        private System.Windows.Forms.DataGridViewTextBoxColumn poeesferico;
        private System.Windows.Forms.DataGridViewTextBoxColumn lodcilindrico;
        private System.Windows.Forms.DataGridViewTextBoxColumn loecilindrico;
        private System.Windows.Forms.DataGridViewTextBoxColumn podcilindrico;
        private System.Windows.Forms.DataGridViewTextBoxColumn poecilindirco;
        private System.Windows.Forms.DataGridViewTextBoxColumn lodeixo;
        private System.Windows.Forms.DataGridViewTextBoxColumn loeeixo;
        private System.Windows.Forms.DataGridViewTextBoxColumn podeixo;
        private System.Windows.Forms.DataGridViewTextBoxColumn poeeixo;
        private System.Windows.Forms.DataGridViewTextBoxColumn lodaltura;
        private System.Windows.Forms.DataGridViewTextBoxColumn loealtura;
        private System.Windows.Forms.DataGridViewTextBoxColumn podaltura;
        private System.Windows.Forms.DataGridViewTextBoxColumn poealtura;
        private System.Windows.Forms.DataGridViewTextBoxColumn loddnp;
        private System.Windows.Forms.DataGridViewTextBoxColumn loednp;
        private System.Windows.Forms.DataGridViewTextBoxColumn poddnp;
        private System.Windows.Forms.DataGridViewTextBoxColumn poednp;
        private System.Windows.Forms.DataGridViewTextBoxColumn observa;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomemedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtvalidade;
    }
}
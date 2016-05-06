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
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historico = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.adicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomemedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtvalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridreceita)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridreceita
            // 
            this.DataGridreceita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridreceita.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.historico,
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
            this.adicao,
            this.obs,
            this.nomemedico,
            this.data,
            this.dtvalidade});
            this.DataGridreceita.Location = new System.Drawing.Point(12, 64);
            this.DataGridreceita.MultiSelect = false;
            this.DataGridreceita.Name = "DataGridreceita";
            this.DataGridreceita.ReadOnly = true;
            this.DataGridreceita.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridreceita.Size = new System.Drawing.Size(958, 340);
            this.DataGridreceita.TabIndex = 1;
            this.DataGridreceita.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.receitaDataGridView_CellDoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "rc_id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // historico
            // 
            this.historico.DataPropertyName = "rc_historico";
            this.historico.HeaderText = "Histórico";
            this.historico.Name = "historico";
            this.historico.ReadOnly = true;
            // 
            // lodesferico
            // 
            this.lodesferico.DataPropertyName = "rc_lodesferico";
            this.lodesferico.HeaderText = "Longe OD. Esférico";
            this.lodesferico.Name = "lodesferico";
            this.lodesferico.ReadOnly = true;
            // 
            // eesferico
            // 
            this.eesferico.DataPropertyName = "rc_loeesferico";
            this.eesferico.HeaderText = "Longe OE. Esférico";
            this.eesferico.Name = "eesferico";
            this.eesferico.ReadOnly = true;
            // 
            // podesferico
            // 
            this.podesferico.DataPropertyName = "rc_podesferico";
            this.podesferico.HeaderText = "Perto OD. Esférico";
            this.podesferico.Name = "podesferico";
            this.podesferico.ReadOnly = true;
            // 
            // poeesferico
            // 
            this.poeesferico.DataPropertyName = "rc_poeesferico";
            this.poeesferico.HeaderText = "Perto OE. Esférico";
            this.poeesferico.Name = "poeesferico";
            this.poeesferico.ReadOnly = true;
            // 
            // lodcilindrico
            // 
            this.lodcilindrico.DataPropertyName = "rc_lodcilindrico";
            this.lodcilindrico.HeaderText = "Longe OD. cilindrico";
            this.lodcilindrico.Name = "lodcilindrico";
            this.lodcilindrico.ReadOnly = true;
            // 
            // loecilindrico
            // 
            this.loecilindrico.DataPropertyName = "rc_loecilindrico";
            this.loecilindrico.HeaderText = "Longe OE. cilíndrico";
            this.loecilindrico.Name = "loecilindrico";
            this.loecilindrico.ReadOnly = true;
            // 
            // podcilindrico
            // 
            this.podcilindrico.DataPropertyName = "rc_podcilindrico";
            this.podcilindrico.HeaderText = "Perto OD. cilindrico";
            this.podcilindrico.Name = "podcilindrico";
            this.podcilindrico.ReadOnly = true;
            // 
            // poecilindirco
            // 
            this.poecilindirco.DataPropertyName = "rc_poecilindrico";
            this.poecilindirco.HeaderText = "Perto OE. cilindrico";
            this.poecilindirco.Name = "poecilindirco";
            this.poecilindirco.ReadOnly = true;
            // 
            // lodeixo
            // 
            this.lodeixo.DataPropertyName = "rc_lodeixo";
            this.lodeixo.HeaderText = "Longe OD. eixo";
            this.lodeixo.Name = "lodeixo";
            this.lodeixo.ReadOnly = true;
            // 
            // loeeixo
            // 
            this.loeeixo.DataPropertyName = "rc_loeeixo";
            this.loeeixo.HeaderText = "Longe OE. eixo";
            this.loeeixo.Name = "loeeixo";
            this.loeeixo.ReadOnly = true;
            // 
            // podeixo
            // 
            this.podeixo.DataPropertyName = "rc_podeixo";
            this.podeixo.HeaderText = "Perto OD. eixo";
            this.podeixo.Name = "podeixo";
            this.podeixo.ReadOnly = true;
            // 
            // poeeixo
            // 
            this.poeeixo.DataPropertyName = "rc_poeeixo";
            this.poeeixo.HeaderText = "Perto OE. eixo";
            this.poeeixo.Name = "poeeixo";
            this.poeeixo.ReadOnly = true;
            // 
            // lodaltura
            // 
            this.lodaltura.DataPropertyName = "rc_lodaltura";
            this.lodaltura.HeaderText = "Longe OD. altura";
            this.lodaltura.Name = "lodaltura";
            this.lodaltura.ReadOnly = true;
            // 
            // loealtura
            // 
            this.loealtura.DataPropertyName = "rc_loealtura";
            this.loealtura.HeaderText = "Longe OE. altura";
            this.loealtura.Name = "loealtura";
            this.loealtura.ReadOnly = true;
            // 
            // podaltura
            // 
            this.podaltura.DataPropertyName = "rc_podaltura";
            this.podaltura.HeaderText = "Perto OD. altura";
            this.podaltura.Name = "podaltura";
            this.podaltura.ReadOnly = true;
            // 
            // poealtura
            // 
            this.poealtura.DataPropertyName = "rc_poealtura";
            this.poealtura.HeaderText = "Perto OD. altura";
            this.poealtura.Name = "poealtura";
            this.poealtura.ReadOnly = true;
            // 
            // loddnp
            // 
            this.loddnp.DataPropertyName = "rc_loddnp";
            this.loddnp.HeaderText = "Longe OD. dnp";
            this.loddnp.Name = "loddnp";
            this.loddnp.ReadOnly = true;
            // 
            // loednp
            // 
            this.loednp.DataPropertyName = "rc_loednp, ";
            this.loednp.HeaderText = "Longe OE. dnp";
            this.loednp.Name = "loednp";
            this.loednp.ReadOnly = true;
            // 
            // poddnp
            // 
            this.poddnp.DataPropertyName = "rc_poddnp";
            this.poddnp.HeaderText = "Perto OD. dnp";
            this.poddnp.Name = "poddnp";
            this.poddnp.ReadOnly = true;
            // 
            // poednp
            // 
            this.poednp.DataPropertyName = "rc_poednp";
            this.poednp.HeaderText = "Perto OE. dnp";
            this.poednp.Name = "poednp";
            this.poednp.ReadOnly = true;
            // 
            // adicao
            // 
            this.adicao.DataPropertyName = "rc_adicao";
            this.adicao.HeaderText = "Adição";
            this.adicao.Name = "adicao";
            this.adicao.ReadOnly = true;
            // 
            // obs
            // 
            this.obs.DataPropertyName = "rc_observacoes ";
            this.obs.HeaderText = "Observações";
            this.obs.Name = "obs";
            this.obs.ReadOnly = true;
            // 
            // nomemedico
            // 
            this.nomemedico.DataPropertyName = "rc_nomemedico";
            this.nomemedico.HeaderText = "Nome do médico";
            this.nomemedico.Name = "nomemedico";
            this.nomemedico.ReadOnly = true;
            // 
            // data
            // 
            this.data.DataPropertyName = "rc_data";
            this.data.HeaderText = "Data de entrada";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            // 
            // dtvalidade
            // 
            this.dtvalidade.DataPropertyName = "rc_dtavalidade";
            this.dtvalidade.HeaderText = "Validade ";
            this.dtvalidade.Name = "dtvalidade";
            this.dtvalidade.ReadOnly = true;
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
            // frmListarReceita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 458);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.DataGridreceita);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn historico;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn adicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn obs;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomemedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtvalidade;
    }
}
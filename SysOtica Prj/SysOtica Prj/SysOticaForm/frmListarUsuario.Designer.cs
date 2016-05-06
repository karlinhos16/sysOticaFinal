namespace SysOticaForm
{
    partial class frmListarUsuario
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
            this.dataGridUsuario = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.textPesquisa = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuario)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridUsuario
            // 
            this.dataGridUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.usuario,
            this.senha,
            this.nome,
            this.tipo,
            this.endereco,
            this.telefone});
            this.dataGridUsuario.Location = new System.Drawing.Point(20, 48);
            this.dataGridUsuario.Name = "dataGridUsuario";
            this.dataGridUsuario.Size = new System.Drawing.Size(743, 195);
            this.dataGridUsuario.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnPesquisa);
            this.groupBox1.Controls.Add(this.btnListar);
            this.groupBox1.Controls.Add(this.btnSair);
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.btnAlterar);
            this.groupBox1.Controls.Add(this.textPesquisa);
            this.groupBox1.Controls.Add(this.dataGridUsuario);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 311);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Digite o nome do usuario: ";
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(411, 19);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisa.TabIndex = 6;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(688, 18);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 5;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(20, 261);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(596, 261);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(688, 261);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 2;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // textPesquisa
            // 
            this.textPesquisa.Location = new System.Drawing.Point(156, 21);
            this.textPesquisa.Name = "textPesquisa";
            this.textPesquisa.Size = new System.Drawing.Size(249, 20);
            this.textPesquisa.TabIndex = 1;
            // 
            // id
            // 
            this.id.DataPropertyName = "us_id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "us_usuario";
            this.usuario.HeaderText = "Usuario";
            this.usuario.Name = "usuario";
            // 
            // senha
            // 
            this.senha.DataPropertyName = "us_senha";
            this.senha.HeaderText = "Senha";
            this.senha.Name = "senha";
            // 
            // nome
            // 
            this.nome.DataPropertyName = "us_nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            // 
            // tipo
            // 
            this.tipo.DataPropertyName = "us_tipo";
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            // 
            // endereco
            // 
            this.endereco.DataPropertyName = "us_endereco";
            this.endereco.HeaderText = "Endereço";
            this.endereco.Name = "endereco";
            // 
            // telefone
            // 
            this.telefone.DataPropertyName = "us_telefone";
            this.telefone.HeaderText = "Telefone";
            this.telefone.Name = "telefone";
            // 
            // frmListarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 336);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmListarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListarUsuario";
            this.Load += new System.EventHandler(this.frmListarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuario)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox textPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
    }
}
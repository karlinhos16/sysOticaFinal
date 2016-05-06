namespace SysOticaForm
{
    partial class formProduto
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
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbEstoqueMinimo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbQuantidade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbGrife = new System.Windows.Forms.ComboBox();
            this.cbGrupo = new System.Windows.Forms.ComboBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.cmbUnidade = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descrição";
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(6, 34);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(393, 20);
            this.tbDescricao.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbUnidade);
            this.groupBox1.Controls.Add(this.tbEstoqueMinimo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbQuantidade);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbValor);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbDescricao);
            this.groupBox1.Controls.Add(this.cbGrife);
            this.groupBox1.Controls.Add(this.cbGrupo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 264);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tbEstoqueMinimo
            // 
            this.tbEstoqueMinimo.Location = new System.Drawing.Point(234, 214);
            this.tbEstoqueMinimo.Name = "tbEstoqueMinimo";
            this.tbEstoqueMinimo.Size = new System.Drawing.Size(108, 20);
            this.tbEstoqueMinimo.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(234, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Estoque Mínimo";
            // 
            // tbQuantidade
            // 
            this.tbQuantidade.Location = new System.Drawing.Point(120, 214);
            this.tbQuantidade.Name = "tbQuantidade";
            this.tbQuantidade.Size = new System.Drawing.Size(108, 20);
            this.tbQuantidade.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(120, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Quantidade";
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(6, 214);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(108, 20);
            this.tbValor.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Valor (R$)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Grife";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Grupo";
            // 
            // cbGrife
            // 
            this.cbGrife.FormattingEnabled = true;
            this.cbGrife.Location = new System.Drawing.Point(6, 156);
            this.cbGrife.Name = "cbGrife";
            this.cbGrife.Size = new System.Drawing.Size(268, 21);
            this.cbGrife.TabIndex = 8;
            // 
            // cbGrupo
            // 
            this.cbGrupo.FormattingEnabled = true;
            this.cbGrupo.Location = new System.Drawing.Point(6, 100);
            this.cbGrupo.Name = "cbGrupo";
            this.cbGrupo.Size = new System.Drawing.Size(268, 21);
            this.cbGrupo.TabIndex = 3;
            this.cbGrupo.SelectedIndexChanged += new System.EventHandler(this.cbGrupo_SelectedIndexChanged);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(12, 282);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 1;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click_1);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(102, 282);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpar.TabIndex = 2;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click_1);
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(511, 282);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 23);
            this.buttonSair.TabIndex = 3;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click_1);
            // 
            // cmbUnidade
            // 
            this.cmbUnidade.FormattingEnabled = true;
            this.cmbUnidade.Items.AddRange(new object[] {
            "PR",
            "UN"});
            this.cmbUnidade.Location = new System.Drawing.Point(470, 34);
            this.cmbUnidade.Name = "cmbUnidade";
            this.cmbUnidade.Size = new System.Drawing.Size(80, 21);
            this.cmbUnidade.Sorted = true;
            this.cmbUnidade.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Unidade:";
            // 
            // formProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 318);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "formProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos - Novo Cadastro";
            this.Load += new System.EventHandler(this.formProduto_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbEstoqueMinimo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbQuantidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbGrife;
        private System.Windows.Forms.ComboBox cbGrupo;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.ComboBox cmbUnidade;
        private System.Windows.Forms.Label label2;
    }
}
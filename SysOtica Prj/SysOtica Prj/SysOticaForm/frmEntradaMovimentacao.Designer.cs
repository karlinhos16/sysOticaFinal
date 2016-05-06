namespace SysOticaForm
{
    partial class frmEntradaMovimentacao
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
            this.richTextObs = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textquantidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cmbEntrada = new System.Windows.Forms.ComboBox();
            this.dateTimedtEntrada = new System.Windows.Forms.DateTimePicker();
            this.cmbFornecedor = new System.Windows.Forms.ComboBox();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextObs);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textquantidade);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.cmbEntrada);
            this.groupBox1.Controls.Add(this.dateTimedtEntrada);
            this.groupBox1.Controls.Add(this.cmbFornecedor);
            this.groupBox1.Controls.Add(this.cmbProduto);
            this.groupBox1.Location = new System.Drawing.Point(2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 315);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // richTextObs
            // 
            this.richTextObs.Location = new System.Drawing.Point(336, 160);
            this.richTextObs.Name = "richTextObs";
            this.richTextObs.Size = new System.Drawing.Size(371, 96);
            this.richTextObs.TabIndex = 14;
            this.richTextObs.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(424, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Quantidade";
            // 
            // textquantidade
            // 
            this.textquantidade.Location = new System.Drawing.Point(427, 109);
            this.textquantidade.Name = "textquantidade";
            this.textquantidade.Size = new System.Drawing.Size(100, 20);
            this.textquantidade.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Observações";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tipo de Entrada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Data da Entrada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fornecedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Produto";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(529, 280);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(632, 280);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cmbEntrada
            // 
            this.cmbEntrada.FormattingEnabled = true;
            this.cmbEntrada.Items.AddRange(new object[] {
            "Entrada",
            "Troca",
            "Devolução"});
            this.cmbEntrada.Location = new System.Drawing.Point(33, 163);
            this.cmbEntrada.Name = "cmbEntrada";
            this.cmbEntrada.Size = new System.Drawing.Size(121, 21);
            this.cmbEntrada.TabIndex = 3;
            // 
            // dateTimedtEntrada
            // 
            this.dateTimedtEntrada.Location = new System.Drawing.Point(30, 106);
            this.dateTimedtEntrada.Name = "dateTimedtEntrada";
            this.dateTimedtEntrada.Size = new System.Drawing.Size(200, 20);
            this.dateTimedtEntrada.TabIndex = 2;
            // 
            // cmbFornecedor
            // 
            this.cmbFornecedor.FormattingEnabled = true;
            this.cmbFornecedor.Location = new System.Drawing.Point(424, 50);
            this.cmbFornecedor.Name = "cmbFornecedor";
            this.cmbFornecedor.Size = new System.Drawing.Size(283, 21);
            this.cmbFornecedor.TabIndex = 1;
            // 
            // cmbProduto
            // 
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(30, 50);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(296, 21);
            this.cmbProduto.TabIndex = 0;
            // 
            // frmEntradaMovimentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 349);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEntradaMovimentacao";
            this.Text = "frmEntradaMovimentacao";
            this.Load += new System.EventHandler(this.frmEntradaMovimentacao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cmbEntrada;
        private System.Windows.Forms.DateTimePicker dateTimedtEntrada;
        private System.Windows.Forms.ComboBox cmbFornecedor;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textquantidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextObs;
    }
}
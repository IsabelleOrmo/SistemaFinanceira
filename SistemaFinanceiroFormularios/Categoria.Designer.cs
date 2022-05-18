
namespace SistemaFinanceiroFormularios
{
    partial class Categoria
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
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpCategoria = new System.Windows.Forms.GroupBox();
            this.chkAtiva = new System.Windows.Forms.CheckBox();
            this.labelChkAtiva = new System.Windows.Forms.Label();
            this.rdDespesa = new System.Windows.Forms.RadioButton();
            this.rdReceita = new System.Windows.Forms.RadioButton();
            this.labelRd = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.labelTxtDesc = new System.Windows.Forms.Label();
            this.labelTxtNome = new System.Windows.Forms.Label();
            this.grpCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(12, 215);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(93, 29);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(111, 215);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(93, 29);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(259, 215);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(93, 29);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(358, 215);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(93, 29);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Visible = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(457, 215);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 29);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // grpCategoria
            // 
            this.grpCategoria.Controls.Add(this.chkAtiva);
            this.grpCategoria.Controls.Add(this.labelChkAtiva);
            this.grpCategoria.Controls.Add(this.rdDespesa);
            this.grpCategoria.Controls.Add(this.rdReceita);
            this.grpCategoria.Controls.Add(this.labelRd);
            this.grpCategoria.Controls.Add(this.txtDesc);
            this.grpCategoria.Controls.Add(this.txtNome);
            this.grpCategoria.Controls.Add(this.labelTxtDesc);
            this.grpCategoria.Controls.Add(this.labelTxtNome);
            this.grpCategoria.Enabled = false;
            this.grpCategoria.Location = new System.Drawing.Point(12, 7);
            this.grpCategoria.Name = "grpCategoria";
            this.grpCategoria.Size = new System.Drawing.Size(539, 202);
            this.grpCategoria.TabIndex = 14;
            this.grpCategoria.TabStop = false;
            // 
            // chkAtiva
            // 
            this.chkAtiva.AutoSize = true;
            this.chkAtiva.Checked = true;
            this.chkAtiva.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAtiva.Location = new System.Drawing.Point(77, 174);
            this.chkAtiva.Name = "chkAtiva";
            this.chkAtiva.Size = new System.Drawing.Size(50, 17);
            this.chkAtiva.TabIndex = 5;
            this.chkAtiva.Text = "Ativa";
            this.chkAtiva.UseVisualStyleBackColor = true;
            this.chkAtiva.CheckedChanged += new System.EventHandler(this.chkAtiva_CheckedChanged);
            // 
            // labelChkAtiva
            // 
            this.labelChkAtiva.AutoSize = true;
            this.labelChkAtiva.Location = new System.Drawing.Point(6, 178);
            this.labelChkAtiva.Name = "labelChkAtiva";
            this.labelChkAtiva.Size = new System.Drawing.Size(37, 13);
            this.labelChkAtiva.TabIndex = 16;
            this.labelChkAtiva.Text = "Status";
            // 
            // rdDespesa
            // 
            this.rdDespesa.AutoSize = true;
            this.rdDespesa.Location = new System.Drawing.Point(170, 142);
            this.rdDespesa.Name = "rdDespesa";
            this.rdDespesa.Size = new System.Drawing.Size(67, 17);
            this.rdDespesa.TabIndex = 4;
            this.rdDespesa.TabStop = true;
            this.rdDespesa.Text = "Despesa";
            this.rdDespesa.UseVisualStyleBackColor = true;
            // 
            // rdReceita
            // 
            this.rdReceita.AutoSize = true;
            this.rdReceita.Location = new System.Drawing.Point(77, 142);
            this.rdReceita.Name = "rdReceita";
            this.rdReceita.Size = new System.Drawing.Size(62, 17);
            this.rdReceita.TabIndex = 3;
            this.rdReceita.TabStop = true;
            this.rdReceita.Text = "Receita";
            this.rdReceita.UseVisualStyleBackColor = true;
            // 
            // labelRd
            // 
            this.labelRd.AutoSize = true;
            this.labelRd.Location = new System.Drawing.Point(6, 144);
            this.labelRd.Name = "labelRd";
            this.labelRd.Size = new System.Drawing.Size(28, 13);
            this.labelRd.TabIndex = 13;
            this.labelRd.Text = "Tipo";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(77, 50);
            this.txtDesc.MaxLength = 100;
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(451, 74);
            this.txtDesc.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(77, 13);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(451, 20);
            this.txtNome.TabIndex = 0;
            // 
            // labelTxtDesc
            // 
            this.labelTxtDesc.AutoSize = true;
            this.labelTxtDesc.Location = new System.Drawing.Point(6, 53);
            this.labelTxtDesc.Name = "labelTxtDesc";
            this.labelTxtDesc.Size = new System.Drawing.Size(55, 13);
            this.labelTxtDesc.TabIndex = 10;
            this.labelTxtDesc.Text = "Descrição";
            // 
            // labelTxtNome
            // 
            this.labelTxtNome.AutoSize = true;
            this.labelTxtNome.Location = new System.Drawing.Point(6, 16);
            this.labelTxtNome.Name = "labelTxtNome";
            this.labelTxtNome.Size = new System.Drawing.Size(35, 13);
            this.labelTxtNome.TabIndex = 9;
            this.labelTxtNome.Text = "Nome";
            // 
            // Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 258);
            this.Controls.Add(this.grpCategoria);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Categoria";
            this.Text = "Categoria";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Categoria_FormClosing);
            this.Load += new System.EventHandler(this.Categoria_Load);
            this.grpCategoria.ResumeLayout(false);
            this.grpCategoria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox grpCategoria;
        private System.Windows.Forms.CheckBox chkAtiva;
        private System.Windows.Forms.Label labelChkAtiva;
        private System.Windows.Forms.RadioButton rdDespesa;
        private System.Windows.Forms.RadioButton rdReceita;
        private System.Windows.Forms.Label labelRd;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label labelTxtDesc;
        private System.Windows.Forms.Label labelTxtNome;
    }
}
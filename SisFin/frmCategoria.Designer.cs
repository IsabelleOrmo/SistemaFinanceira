
namespace SistemaFinanceiroFormularios
{
    partial class frmCategoria
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
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.categoriaLabelStatus = new System.Windows.Forms.Label();
            this.rdDespesa = new System.Windows.Forms.RadioButton();
            this.rdReceita = new System.Windows.Forms.RadioButton();
            this.categoriaLabelTipo = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.categoriaLabelDescricao = new System.Windows.Forms.Label();
            this.categoriaLabelNome = new System.Windows.Forms.Label();
            this.dgCategoria = new System.Windows.Forms.DataGridView();
            this.grpCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(12, 437);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(93, 29);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.novoRegistro);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(111, 437);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(93, 29);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.altRegistro);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(294, 437);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(93, 29);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.exclCadastro);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(393, 437);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(93, 29);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Visible = false;
            this.btnSalvar.Click += new System.EventHandler(this.salvarCadastro);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(492, 437);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 29);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.cancCadastro);
            // 
            // grpCategoria
            // 
            this.grpCategoria.Controls.Add(this.chkStatus);
            this.grpCategoria.Controls.Add(this.categoriaLabelStatus);
            this.grpCategoria.Controls.Add(this.rdDespesa);
            this.grpCategoria.Controls.Add(this.rdReceita);
            this.grpCategoria.Controls.Add(this.categoriaLabelTipo);
            this.grpCategoria.Controls.Add(this.txtDescricao);
            this.grpCategoria.Controls.Add(this.txtNome);
            this.grpCategoria.Controls.Add(this.categoriaLabelDescricao);
            this.grpCategoria.Controls.Add(this.categoriaLabelNome);
            this.grpCategoria.Enabled = false;
            this.grpCategoria.Location = new System.Drawing.Point(12, 7);
            this.grpCategoria.Name = "grpCategoria";
            this.grpCategoria.Size = new System.Drawing.Size(573, 202);
            this.grpCategoria.TabIndex = 14;
            this.grpCategoria.TabStop = false;
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Checked = true;
            this.chkStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStatus.Location = new System.Drawing.Point(77, 174);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(50, 17);
            this.chkStatus.TabIndex = 5;
            this.chkStatus.Text = "Ativa";
            this.chkStatus.UseVisualStyleBackColor = true;
            // 
            // categoriaLabelStatus
            // 
            this.categoriaLabelStatus.AutoSize = true;
            this.categoriaLabelStatus.Location = new System.Drawing.Point(6, 178);
            this.categoriaLabelStatus.Name = "categoriaLabelStatus";
            this.categoriaLabelStatus.Size = new System.Drawing.Size(37, 13);
            this.categoriaLabelStatus.TabIndex = 16;
            this.categoriaLabelStatus.Text = "Status";
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
            // categoriaLabelTipo
            // 
            this.categoriaLabelTipo.AutoSize = true;
            this.categoriaLabelTipo.Location = new System.Drawing.Point(6, 144);
            this.categoriaLabelTipo.Name = "categoriaLabelTipo";
            this.categoriaLabelTipo.Size = new System.Drawing.Size(28, 13);
            this.categoriaLabelTipo.TabIndex = 13;
            this.categoriaLabelTipo.Text = "Tipo";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(77, 50);
            this.txtDescricao.MaxLength = 100;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(490, 74);
            this.txtDescricao.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(77, 13);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(490, 20);
            this.txtNome.TabIndex = 0;
            // 
            // categoriaLabelDescricao
            // 
            this.categoriaLabelDescricao.AutoSize = true;
            this.categoriaLabelDescricao.Location = new System.Drawing.Point(6, 53);
            this.categoriaLabelDescricao.Name = "categoriaLabelDescricao";
            this.categoriaLabelDescricao.Size = new System.Drawing.Size(55, 13);
            this.categoriaLabelDescricao.TabIndex = 10;
            this.categoriaLabelDescricao.Text = "Descrição";
            // 
            // categoriaLabelNome
            // 
            this.categoriaLabelNome.AutoSize = true;
            this.categoriaLabelNome.Location = new System.Drawing.Point(6, 16);
            this.categoriaLabelNome.Name = "categoriaLabelNome";
            this.categoriaLabelNome.Size = new System.Drawing.Size(35, 13);
            this.categoriaLabelNome.TabIndex = 9;
            this.categoriaLabelNome.Text = "Nome";
            // 
            // dgCategoria
            // 
            this.dgCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCategoria.Location = new System.Drawing.Point(12, 215);
            this.dgCategoria.Name = "dgCategoria";
            this.dgCategoria.Size = new System.Drawing.Size(573, 216);
            this.dgCategoria.TabIndex = 15;
            this.dgCategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCategoria_CellContentClick);
            this.dgCategoria.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCategoria_RowEnter);
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 478);
            this.Controls.Add(this.dgCategoria);
            this.Controls.Add(this.grpCategoria);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCategoria";
            this.Text = "Categoria";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fechaForm);
            this.Load += new System.EventHandler(this.Categoria_Load);
            this.grpCategoria.ResumeLayout(false);
            this.grpCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox grpCategoria;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.Label categoriaLabelStatus;
        private System.Windows.Forms.RadioButton rdDespesa;
        private System.Windows.Forms.RadioButton rdReceita;
        private System.Windows.Forms.Label categoriaLabelTipo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label categoriaLabelDescricao;
        private System.Windows.Forms.Label categoriaLabelNome;
        private System.Windows.Forms.DataGridView dgCategoria;
    }
}
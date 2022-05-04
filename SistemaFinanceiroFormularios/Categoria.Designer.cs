
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
            this.categoriaBotaoNovo = new System.Windows.Forms.Button();
            this.categoriaBotaoAlterar = new System.Windows.Forms.Button();
            this.categoriaBotaoExcluir = new System.Windows.Forms.Button();
            this.categoriaBotaoSalvar = new System.Windows.Forms.Button();
            this.categoriaBotaoCancelar = new System.Windows.Forms.Button();
            this.categoriaGroupInfo = new System.Windows.Forms.GroupBox();
            this.categoriaCheckStatus = new System.Windows.Forms.CheckBox();
            this.categoriaLabelStatus = new System.Windows.Forms.Label();
            this.categoriaRadioTipoDespesa = new System.Windows.Forms.RadioButton();
            this.categoriaRadioTipoReceita = new System.Windows.Forms.RadioButton();
            this.categoriaLabelTipo = new System.Windows.Forms.Label();
            this.categoriaTextDescricao = new System.Windows.Forms.TextBox();
            this.categoriaTextNome = new System.Windows.Forms.TextBox();
            this.categoriaLabelDescricao = new System.Windows.Forms.Label();
            this.categoriaLabelNome = new System.Windows.Forms.Label();
            this.categoriaGroupInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoriaBotaoNovo
            // 
            this.categoriaBotaoNovo.Location = new System.Drawing.Point(12, 215);
            this.categoriaBotaoNovo.Name = "categoriaBotaoNovo";
            this.categoriaBotaoNovo.Size = new System.Drawing.Size(93, 29);
            this.categoriaBotaoNovo.TabIndex = 9;
            this.categoriaBotaoNovo.Text = "Novo";
            this.categoriaBotaoNovo.UseVisualStyleBackColor = true;
            this.categoriaBotaoNovo.Click += new System.EventHandler(this.categoriaBotaoNovo_Click);
            // 
            // categoriaBotaoAlterar
            // 
            this.categoriaBotaoAlterar.Location = new System.Drawing.Point(111, 215);
            this.categoriaBotaoAlterar.Name = "categoriaBotaoAlterar";
            this.categoriaBotaoAlterar.Size = new System.Drawing.Size(93, 29);
            this.categoriaBotaoAlterar.TabIndex = 10;
            this.categoriaBotaoAlterar.Text = "Alterar";
            this.categoriaBotaoAlterar.UseVisualStyleBackColor = true;
            this.categoriaBotaoAlterar.Click += new System.EventHandler(this.categoriaBotaoAlterar_Click);
            // 
            // categoriaBotaoExcluir
            // 
            this.categoriaBotaoExcluir.Location = new System.Drawing.Point(259, 215);
            this.categoriaBotaoExcluir.Name = "categoriaBotaoExcluir";
            this.categoriaBotaoExcluir.Size = new System.Drawing.Size(93, 29);
            this.categoriaBotaoExcluir.TabIndex = 11;
            this.categoriaBotaoExcluir.Text = "Excluir";
            this.categoriaBotaoExcluir.UseVisualStyleBackColor = true;
            this.categoriaBotaoExcluir.Visible = false;
            this.categoriaBotaoExcluir.Click += new System.EventHandler(this.categoriaBotaoExcluir_Click);
            // 
            // categoriaBotaoSalvar
            // 
            this.categoriaBotaoSalvar.Location = new System.Drawing.Point(358, 215);
            this.categoriaBotaoSalvar.Name = "categoriaBotaoSalvar";
            this.categoriaBotaoSalvar.Size = new System.Drawing.Size(93, 29);
            this.categoriaBotaoSalvar.TabIndex = 12;
            this.categoriaBotaoSalvar.Text = "Salvar";
            this.categoriaBotaoSalvar.UseVisualStyleBackColor = true;
            this.categoriaBotaoSalvar.Visible = false;
            this.categoriaBotaoSalvar.Click += new System.EventHandler(this.categoriaBotaoSalvar_Click);
            // 
            // categoriaBotaoCancelar
            // 
            this.categoriaBotaoCancelar.Location = new System.Drawing.Point(457, 215);
            this.categoriaBotaoCancelar.Name = "categoriaBotaoCancelar";
            this.categoriaBotaoCancelar.Size = new System.Drawing.Size(93, 29);
            this.categoriaBotaoCancelar.TabIndex = 13;
            this.categoriaBotaoCancelar.Text = "Cancelar";
            this.categoriaBotaoCancelar.UseVisualStyleBackColor = true;
            this.categoriaBotaoCancelar.Visible = false;
            this.categoriaBotaoCancelar.Click += new System.EventHandler(this.categoriaBotaoCancelar_Click);
            // 
            // categoriaGroupInfo
            // 
            this.categoriaGroupInfo.Controls.Add(this.categoriaCheckStatus);
            this.categoriaGroupInfo.Controls.Add(this.categoriaLabelStatus);
            this.categoriaGroupInfo.Controls.Add(this.categoriaRadioTipoDespesa);
            this.categoriaGroupInfo.Controls.Add(this.categoriaRadioTipoReceita);
            this.categoriaGroupInfo.Controls.Add(this.categoriaLabelTipo);
            this.categoriaGroupInfo.Controls.Add(this.categoriaTextDescricao);
            this.categoriaGroupInfo.Controls.Add(this.categoriaTextNome);
            this.categoriaGroupInfo.Controls.Add(this.categoriaLabelDescricao);
            this.categoriaGroupInfo.Controls.Add(this.categoriaLabelNome);
            this.categoriaGroupInfo.Enabled = false;
            this.categoriaGroupInfo.Location = new System.Drawing.Point(12, 7);
            this.categoriaGroupInfo.Name = "categoriaGroupInfo";
            this.categoriaGroupInfo.Size = new System.Drawing.Size(539, 202);
            this.categoriaGroupInfo.TabIndex = 14;
            this.categoriaGroupInfo.TabStop = false;
            // 
            // categoriaCheckStatus
            // 
            this.categoriaCheckStatus.AutoSize = true;
            this.categoriaCheckStatus.Checked = true;
            this.categoriaCheckStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.categoriaCheckStatus.Location = new System.Drawing.Point(77, 174);
            this.categoriaCheckStatus.Name = "categoriaCheckStatus";
            this.categoriaCheckStatus.Size = new System.Drawing.Size(50, 17);
            this.categoriaCheckStatus.TabIndex = 17;
            this.categoriaCheckStatus.Text = "Ativa";
            this.categoriaCheckStatus.UseVisualStyleBackColor = true;
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
            // categoriaRadioTipoDespesa
            // 
            this.categoriaRadioTipoDespesa.AutoSize = true;
            this.categoriaRadioTipoDespesa.Location = new System.Drawing.Point(170, 142);
            this.categoriaRadioTipoDespesa.Name = "categoriaRadioTipoDespesa";
            this.categoriaRadioTipoDespesa.Size = new System.Drawing.Size(67, 17);
            this.categoriaRadioTipoDespesa.TabIndex = 15;
            this.categoriaRadioTipoDespesa.TabStop = true;
            this.categoriaRadioTipoDespesa.Text = "Despesa";
            this.categoriaRadioTipoDespesa.UseVisualStyleBackColor = true;
            // 
            // categoriaRadioTipoReceita
            // 
            this.categoriaRadioTipoReceita.AutoSize = true;
            this.categoriaRadioTipoReceita.Location = new System.Drawing.Point(77, 142);
            this.categoriaRadioTipoReceita.Name = "categoriaRadioTipoReceita";
            this.categoriaRadioTipoReceita.Size = new System.Drawing.Size(62, 17);
            this.categoriaRadioTipoReceita.TabIndex = 14;
            this.categoriaRadioTipoReceita.TabStop = true;
            this.categoriaRadioTipoReceita.Text = "Receita";
            this.categoriaRadioTipoReceita.UseVisualStyleBackColor = true;
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
            // categoriaTextDescricao
            // 
            this.categoriaTextDescricao.Location = new System.Drawing.Point(77, 50);
            this.categoriaTextDescricao.Multiline = true;
            this.categoriaTextDescricao.Name = "categoriaTextDescricao";
            this.categoriaTextDescricao.Size = new System.Drawing.Size(451, 74);
            this.categoriaTextDescricao.TabIndex = 12;
            // 
            // categoriaTextNome
            // 
            this.categoriaTextNome.Location = new System.Drawing.Point(77, 13);
            this.categoriaTextNome.Name = "categoriaTextNome";
            this.categoriaTextNome.Size = new System.Drawing.Size(451, 20);
            this.categoriaTextNome.TabIndex = 11;
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
            // Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 258);
            this.Controls.Add(this.categoriaGroupInfo);
            this.Controls.Add(this.categoriaBotaoCancelar);
            this.Controls.Add(this.categoriaBotaoSalvar);
            this.Controls.Add(this.categoriaBotaoExcluir);
            this.Controls.Add(this.categoriaBotaoAlterar);
            this.Controls.Add(this.categoriaBotaoNovo);
            this.Name = "Categoria";
            this.Text = "categoria";
            this.Load += new System.EventHandler(this.Categoria_Load);
            this.categoriaGroupInfo.ResumeLayout(false);
            this.categoriaGroupInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button categoriaBotaoNovo;
        private System.Windows.Forms.Button categoriaBotaoAlterar;
        private System.Windows.Forms.Button categoriaBotaoExcluir;
        private System.Windows.Forms.Button categoriaBotaoSalvar;
        private System.Windows.Forms.Button categoriaBotaoCancelar;
        private System.Windows.Forms.GroupBox categoriaGroupInfo;
        private System.Windows.Forms.CheckBox categoriaCheckStatus;
        private System.Windows.Forms.Label categoriaLabelStatus;
        private System.Windows.Forms.RadioButton categoriaRadioTipoDespesa;
        private System.Windows.Forms.RadioButton categoriaRadioTipoReceita;
        private System.Windows.Forms.Label categoriaLabelTipo;
        private System.Windows.Forms.TextBox categoriaTextDescricao;
        private System.Windows.Forms.TextBox categoriaTextNome;
        private System.Windows.Forms.Label categoriaLabelDescricao;
        private System.Windows.Forms.Label categoriaLabelNome;
    }
}
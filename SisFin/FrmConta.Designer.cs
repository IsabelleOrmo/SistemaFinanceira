
namespace SisFin
{
    partial class FrmConta
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
            this.labelNome = new System.Windows.Forms.Label();
            this.gpBoxConta = new System.Windows.Forms.GroupBox();
            this.checkBoxStatus = new System.Windows.Forms.CheckBox();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gpBoxConta.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(8, 17);
            this.labelNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(45, 16);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            // 
            // gpBoxConta
            // 
            this.gpBoxConta.Controls.Add(this.checkBoxStatus);
            this.gpBoxConta.Controls.Add(this.comboBoxCategoria);
            this.gpBoxConta.Controls.Add(this.labelCategoria);
            this.gpBoxConta.Controls.Add(this.txtDescricao);
            this.gpBoxConta.Controls.Add(this.labelDescricao);
            this.gpBoxConta.Controls.Add(this.txtNome);
            this.gpBoxConta.Controls.Add(this.labelNome);
            this.gpBoxConta.Location = new System.Drawing.Point(13, 13);
            this.gpBoxConta.Margin = new System.Windows.Forms.Padding(4);
            this.gpBoxConta.Name = "gpBoxConta";
            this.gpBoxConta.Padding = new System.Windows.Forms.Padding(4);
            this.gpBoxConta.Size = new System.Drawing.Size(622, 184);
            this.gpBoxConta.TabIndex = 1;
            this.gpBoxConta.TabStop = false;
            this.gpBoxConta.Enter += new System.EventHandler(this.gpBoxConta_Enter);
            // 
            // checkBoxStatus
            // 
            this.checkBoxStatus.AutoSize = true;
            this.checkBoxStatus.Location = new System.Drawing.Point(551, 153);
            this.checkBoxStatus.Name = "checkBoxStatus";
            this.checkBoxStatus.Size = new System.Drawing.Size(64, 20);
            this.checkBoxStatus.TabIndex = 6;
            this.checkBoxStatus.Text = "Status";
            this.checkBoxStatus.UseVisualStyleBackColor = true;
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(8, 153);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(345, 24);
            this.comboBoxCategoria.TabIndex = 5;
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(5, 134);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(67, 16);
            this.labelCategoria.TabIndex = 4;
            this.labelCategoria.Text = "Categoria";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(7, 94);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(608, 22);
            this.txtDescricao.TabIndex = 3;
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(8, 75);
            this.labelDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(70, 16);
            this.labelDescricao.TabIndex = 2;
            this.labelDescricao.Text = "Descrição";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(8, 37);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(559, 22);
            this.txtNome.TabIndex = 1;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(12, 250);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(99, 38);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(118, 250);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(99, 38);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(431, 250);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(99, 38);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(536, 250);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 38);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(326, 250);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(99, 38);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // FrmConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 300);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.gpBoxConta);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmConta";
            this.Text = "FrmConta";
            this.gpBoxConta.ResumeLayout(false);
            this.gpBoxConta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.GroupBox gpBoxConta;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.CheckBox checkBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
    }
}
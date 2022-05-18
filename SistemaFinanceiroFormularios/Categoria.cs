using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFinanceiroFormularios
{
    public partial class Categoria : Form
    {
        private bool Insercao = false;
        private bool Edicao = false;

        public Categoria()
        {
            InitializeComponent();
            
        }

        private void Categoria_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Edicao || Insercao)
            {
                e.Cancel = true;
                MessageBox.Show("Rimani qui!", "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CamposLimpar()
        {
            categoriaTextNome.Clear();
            categoriaTextDescricao.Clear();
            categoriaRadioTipoDespesa.Checked = false;
            categoriaRadioTipoReceita.Checked = false;
            categoriaCheckStatus.Checked = false;
        }

        private void CamposReset()
        {
            grpCategoria.Enabled = false;
            btnAlterar.Enabled = true;
            btnNovo.Enabled = true;
            btnCancelar.Visible = false;
            btnSalvar.Visible = false;
            btnExcluir.Visible = true;
            Insercao = false;
            Edicao = false;

            btnNovo.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            grpCategoria.Enabled = true;        // Ativar a caixa de grupo
            CamposLimpar();                           // Limpar campos do formulário
            categoriaTextNome.Focus();                // Foco no campo Nome
            btnNovo.Enabled = false;       // Desabilitar botão novo
            btnAlterar.Enabled = false;    // Desabiitar botão alterar
            btnCancelar.Visible = true;    // Tornar visível o botão cancelar
            btnSalvar.Visible = true;      // Tornar visível o botão salvar
            btnExcluir.Visible = false;    // Ocultar o botão excluir

            categoriaCheckStatus.Checked = true;      // Automaticamente define o status como ativo
            
            // Definição das variáveis booleanas da classe
            Insercao = true;
            Edicao = false;
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            grpCategoria.Enabled = true;        // Ativa a caixa de grupo
            categoriaTextNome.Focus();                // Foco no campo Nome
            btnAlterar.Enabled = false;    // Desabilitar o botão alterar
            btnNovo.Enabled = false;       // Ocultar o botão novo
            btnCancelar.Visible = true;    // Tornar visível o botão cancelar
            btnSalvar.Visible = true;      // Tornar visível o botão salvar
            btnExcluir.Visible = false;    // Ocultar o botão excluir

            // Definição das variáveis booleanas da classe
            Insercao = true;
            Edicao = false;
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo excluir essa entrada?", "Mensagem do sistema ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                CamposLimpar();
                MessageBox.Show("Registro excluído com sucesso.", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNovo.Focus();
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo cancelar?", "Mensagem do sistema ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CamposLimpar();
                CamposReset();

                Insercao = true;
                Edicao = false;
            }
        }
        
        private void Categoria_Load(object sender, EventArgs e)
        {
            categoriaTextNome.Text = "Combustível";
            categoriaTextDescricao.Text = "Consumo de combustivéis em um ano pelo consumidor";
            categoriaRadioTipoDespesa.Checked = true;
            categoriaCheckStatus.Checked = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registro salvo com sucesso!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CamposReset();
        }

        private void categoriaCheckStatus_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

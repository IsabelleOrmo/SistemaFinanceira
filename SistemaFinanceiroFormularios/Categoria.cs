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
            categoriaGroupInfo.Enabled = false;
            categoriaBotaoAlterar.Enabled = true;
            categoriaBotaoNovo.Enabled = true;
            categoriaBotaoCancelar.Visible = false;
            categoriaBotaoSalvar.Visible = false;
            categoriaBotaoExcluir.Visible = true;
            Insercao = false;
            Edicao = false;

            categoriaBotaoNovo.Focus();
        }

        private void categoriaBotaoNovo_Click(object sender, EventArgs e)
        {
            categoriaGroupInfo.Enabled = true;        // Ativar a caixa de grupo
            CamposLimpar();                           // Limpar campos do formulário
            categoriaTextNome.Focus();                // Foco no campo Nome
            categoriaBotaoNovo.Enabled = false;       // Desabilitar botão novo
            categoriaBotaoAlterar.Enabled = false;    // Desabiitar botão alterar
            categoriaBotaoCancelar.Visible = true;    // Tornar visível o botão cancelar
            categoriaBotaoSalvar.Visible = true;      // Tornar visível o botão salvar
            categoriaBotaoExcluir.Visible = false;    // Ocultar o botão excluir

            categoriaCheckStatus.Checked = true;      // Automaticamente define o status como ativo
            
            // Definição das variáveis booleanas da classe
            Insercao = true;
            Edicao = false;
        }
        private void categoriaBotaoAlterar_Click(object sender, EventArgs e)
        {
            categoriaGroupInfo.Enabled = true;        // Ativa a caixa de grupo
            categoriaTextNome.Focus();                // Foco no campo Nome
            categoriaBotaoAlterar.Enabled = false;    // Desabilitar o botão alterar
            categoriaBotaoNovo.Enabled = false;       // Ocultar o botão novo
            categoriaBotaoCancelar.Visible = true;    // Tornar visível o botão cancelar
            categoriaBotaoSalvar.Visible = true;      // Tornar visível o botão salvar
            categoriaBotaoExcluir.Visible = false;    // Ocultar o botão excluir

            // Definição das variáveis booleanas da classe
            Insercao = false;
            Edicao = true;
        }


        private void categoriaBotaoExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo excluir essa entrada?", "Mensagem do sistema ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                CamposLimpar();
                MessageBox.Show("Registro excluído com sucesso.", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                categoriaBotaoNovo.Focus();
            }
        }


        private void categoriaBotaoCancelar_Click(object sender, EventArgs e)
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

        private void categoriaBotaoSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registro salvo com sucesso!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CamposReset();
        }

        private void categoriaCheckStatus_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

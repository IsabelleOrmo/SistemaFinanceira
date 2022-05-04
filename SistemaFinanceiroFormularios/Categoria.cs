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

        }

        private void categoriaBotaoNovo_Click(object sender, EventArgs e)
        {
            categoriaGroupInfo.Enabled = true;
            CamposLimpar();
            categoriaTextNome.Focus();
            categoriaBotaoAlterar.Enabled = false;
            categoriaBotaoCancelar.Visible = true;
            categoriaBotaoSalvar.Visible = true;
            categoriaBotaoExcluir.Visible = false;
            categoriaBotaoNovo.Enabled = false;
            Insercao = true;
            Edicao = false;
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
            CamposLimpar();
            categoriaGroupInfo.Enabled = false;
            categoriaBotaoAlterar.Enabled = true;
            categoriaBotaoNovo.Enabled = true;
            categoriaBotaoCancelar.Visible = false;
            categoriaBotaoSalvar.Visible = false;
            categoriaBotaoExcluir.Visible = false;
            Insercao = false;
            Edicao = false;
        }

        private void categoriaBotaoExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo excluir?", "Mensagem do sistema ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CamposLimpar();
                CamposReset();
            }
        }

        private void categoriaBotaoAlterar_Click(object sender, EventArgs e)
        {
            categoriaGroupInfo.Enabled = true;
            categoriaTextNome.Focus();
            categoriaBotaoAlterar.Enabled = false;
            categoriaBotaoCancelar.Visible = true;
            categoriaBotaoSalvar.Visible = true;
            categoriaBotaoExcluir.Visible = true;
            categoriaBotaoNovo.Enabled = false;
            Insercao = true;
            Edicao = false;
        }

        private void categoriaBotaoCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "Mensagem do sistema ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
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
            categoriaBotaoExcluir.Visible = true;
        }
    }
}

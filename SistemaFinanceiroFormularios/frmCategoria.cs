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
    public partial class frmCategoria : Form
    {
        private bool Insercao = false;
        private bool Edicao = false;

        public frmCategoria()
        {
            InitializeComponent();
            
        }

        private void fechaForm(object sender, FormClosingEventArgs e)
        {
            if (Edicao || Insercao)
            {
                /* 
                No começo eu queria muito trocar esse "Rimani qui!"; por achar que ele cobraria
                até o nome das coisas perfeitamente igual.
                Mas não acho que ele vai fazer isso mais, e, depois de tanto ver essa string,
                passei a gostar dela, então, vai ficar aqui, mesmo. 

                "Rimani qui!" it is.
                */
                e.Cancel = true;
                MessageBox.Show("Rimani qui!", "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Não é lindo?
            }
        }

        private void CamposLimpar()
        {
            txtNome.Clear();
            txtDesc.Clear();
            rdDespesa.Checked = false;
            rdReceita.Checked = false;
            chkAtiva.Checked = false;
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

        private void novoRegistro(object sender, EventArgs e)
        {
            grpCategoria.Enabled = true;   // Ativar a caixa de grupo
            CamposLimpar();                // Limpar campos do formulário
            txtNome.Focus();               // Foco no campo Nome
            btnNovo.Enabled = false;       // Desabilitar botão novo
            btnAlterar.Enabled = false;    // Desabiitar botão alterar
            btnCancelar.Visible = true;    // Tornar visível o botão cancelar
            btnSalvar.Visible = true;      // Tornar visível o botão salvar
            btnExcluir.Visible = false;    // Ocultar o botão excluir

            chkAtiva.Checked = true;       // Automaticamente define o status como ativo
            
            // Definição das variáveis booleanas da classe
            Insercao = true;
            Edicao = false;
        }
        private void altCadastro(object sender, EventArgs e)
        {
            grpCategoria.Enabled = true;   // Ativa a caixa de grupo
            txtNome.Focus();               // Foco no campo Nome
            btnAlterar.Enabled = false;    // Desabilitar o botão alterar
            btnNovo.Enabled = false;       // Ocultar o botão novo
            btnCancelar.Visible = true;    // Tornar visível o botão cancelar
            btnSalvar.Visible = true;      // Tornar visível o botão salvar
            btnExcluir.Visible = false;    // Ocultar o botão excluir

            // Definição das variáveis booleanas da classe
            Insercao = false;
            Edicao = true;
        }
        

        private void exclCadastro(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo excluir essa entrada?", "Mensagem do sistema ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                CamposLimpar();
                MessageBox.Show("Registro excluído com sucesso.", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNovo.Focus();
            }
        }


        private void cancCadastro(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo cancelar?", "Mensagem do sistema ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CamposLimpar();
                CamposReset();

                Insercao = true;
                Edicao = false;
            }
        }
        
        private void frmCategoria_Load(object sender, EventArgs e)
        {
            txtNome.Text = "Combustível";
            txtDesc.Text = "Consumo de combustivéis em um ano pelo consumidor";
            rdDespesa.Checked = true;
            chkAtiva.Checked = true;
        }

        private void salvarCadastro(object sender, EventArgs e)
        {
            MessageBox.Show("Registro salvo com sucesso!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CamposReset();
        }

        private void chkAtiva_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

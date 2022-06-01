using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaFinanceiroFormularios
{
    public partial class frmCategoria : Form
    {
        private bool Insercao = false;
        private bool Edicao = false;

        private bool ButtonHiding = true; // Define se os botões devem ser ocultados com a tela vazia

        private Categoria categoria = new Categoria();
        private List<Categoria> lstCategoria = new List<Categoria>();
        private BindingSource bsCategoria;



        public frmCategoria()
        {
            InitializeComponent();
            lstCategoria = categoria.GeraCategorias();
        }

        private void Categoria_Load(object sender, EventArgs e)
        {
            //magica. nao mexa.
            dgCategoria.ColumnCount = 5;
            dgCategoria.AutoGenerateColumns = false;
            dgCategoria.Columns[0].Width = 50;
            dgCategoria.Columns[0].HeaderText = "ID";
            dgCategoria.Columns[0].DataPropertyName = "Id";
            dgCategoria.Columns[0].Visible = false;
            dgCategoria.Columns[1].Width = 200;
            dgCategoria.Columns[1].HeaderText = "NOME";
            dgCategoria.Columns[1].DataPropertyName = "Nome";
            dgCategoria.Columns[2].Width = 400;
            dgCategoria.Columns[2].HeaderText = "DESCRIÇÃO";
            dgCategoria.Columns[2].DataPropertyName = "Descricao";
            dgCategoria.Columns[3].Width = 50;
            dgCategoria.Columns[3].HeaderText = "TIPO";
            dgCategoria.Columns[3].DataPropertyName = "Tipo";
            dgCategoria.Columns[4].Width = 50;
            dgCategoria.Columns[4].HeaderText = "STATUS";
            dgCategoria.Columns[4].DataPropertyName = "Status";

            dgCategoria.AllowUserToAddRows = false;
            dgCategoria.AllowUserToDeleteRows = false;
            dgCategoria.MultiSelect = false;
            dgCategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // FullRow e LowTra

            carregaGridCategoria();
        }

        private bool hasGridItems()
        {
            return lstCategoria.Count > 0 && dgCategoria.RowCount > 0;
        }

        private bool emptyError()
        {
            if (!hasGridItems())
            {
                MessageBox.Show("Impossível realizar ação: Tabela vazia", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return hasGridItems();
        }

        private void emptyChecker()
        {
            if (ButtonHiding) { return; } // Encerra função e a impede de fazer qualquer coisa

            if (hasGridItems())
            {
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
            }
            else
            {
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
            }
        }

        private void fechaForm(object sender, FormClosingEventArgs e)
        {
            if (Edicao || Insercao)
            {
                e.Cancel = true;
                MessageBox.Show("Rimani qui!", "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CamposLimpar()
        {
            txtNome.Clear();
            txtDescricao.Clear();
            rdDespesa.Checked = false;
            rdReceita.Checked = false;
            chkStatus.Checked = false;
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
            grpCategoria.Enabled = true;
            CamposLimpar();
            txtNome.Focus();
            btnAlterar.Enabled = false;
            btnCancelar.Visible = true;
            btnSalvar.Visible = true;
            btnExcluir.Visible = false;
            btnNovo.Enabled = false;
            dgCategoria.Enabled = false; //novo
            Insercao = true;
            Edicao = false;
        }
        private void alteraRegistro(object sender, EventArgs e)
        {
            if (emptyError())
            {
                btnNovo.Enabled = false;
                btnAlterar.Enabled = false;
                grpCategoria.Enabled = true;
                txtNome.Enabled = false;
                txtDescricao.Focus();
                btnSalvar.Visible = true;
                btnCancelar.Visible = true;
                btnExcluir.Visible = false;
                dgCategoria.Enabled = false; //novo
                Edicao = true;
                Insercao = false;
            }
        }

        private void exclRegistro(object sender, EventArgs e)
        {
            if (emptyError() && MessageBox.Show("Confirma exclusão?", "Aviso do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                lstCategoria.RemoveAt(dgCategoria.CurrentRow.Index);
                // dgCategoria.Rows.RemoveAt(dgCategoria.CurrentRow.Index);
                carregaGridCategoria();
                MessageBox.Show("Registro excluído com sucesso!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNovo.Focus();
                emptyChecker();
            }
        }

        private void cancRegistro(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo cancelar?", "Mensagem do sistema ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CamposReset();
                btnNovo.Enabled = true;
                btnNovo.Focus();
                grpCategoria.Enabled = false;
                btnAlterar.Enabled = true;
                btnCancelar.Visible = false;
                btnSalvar.Visible = false;
                btnExcluir.Visible = true;
                dgCategoria.Enabled = true; //novo
                Insercao = false;
                Edicao = false;

                emptyChecker();

                if (hasGridItems()) { preencheCampos(); }
            }
        }



        private void preencheCampos()
        {
            txtNome.Text = dgCategoria.Rows[dgCategoria.CurrentRow.Index].Cells[1].Value.ToString();
            txtDescricao.Text = dgCategoria.Rows[dgCategoria.CurrentRow.Index].Cells[2].Value.ToString();

            if (Convert.ToInt16(dgCategoria.Rows[dgCategoria.CurrentRow.Index].Cells[3].Value.ToString()) == 1)
                rdReceita.Checked = true;
            else
                rdDespesa.Checked = true;

            if (Convert.ToInt16(dgCategoria.Rows[dgCategoria.CurrentRow.Index].Cells[4].Value.ToString()) == 1)
                chkStatus.Checked = true;
            else
                chkStatus.Checked = false;
        }

        private void carregaGridCategoria()
        {
            bsCategoria = new BindingSource();
            bsCategoria.DataSource = lstCategoria;
            // dgCategoria.Rows.Clear();
            dgCategoria.DataSource = bsCategoria;
            dgCategoria.Refresh();
        }

        private void salvarRegistro(object sender, EventArgs e)
        {
            if (Insercao)
            {
                var nome = txtNome.Text.Trim();
                var descr = txtDescricao.Text.Trim();
                var tipo = rdReceita.Checked ? 1 : 2;
                var status = chkStatus.Checked ? 1 : 0;
                categoria.AddToList(3, nome, descr, tipo, status);
            }

            if (Edicao && emptyError())
            {
                Categoria ct = lstCategoria.Find(item => item.Nome == txtNome.Text.Trim());
                if (ct != null)
                {
                    ct.Descricao = txtDescricao.Text.Trim();
                    ct.Tipo = rdReceita.Checked ? 1 : 2;
                    ct.Status = chkStatus.Checked ? 1 : 0;
                }
            }

            carregaGridCategoria();

            MessageBox.Show("Registro salvo com sucesso!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // nn sei se tem q por isso julgue depois gata  CamposReset();

            btnNovo.Enabled = true;
            btnNovo.Focus();
            txtNome.Enabled = true;
            grpCategoria.Enabled = false;
            btnAlterar.Enabled = true;
            btnCancelar.Visible = false;
            btnSalvar.Visible = false;
            btnExcluir.Visible = true;
            dgCategoria.Enabled = true; //novo

            Insercao = false;
            Edicao = false;

            emptyChecker();

        }

        // NOVO ====================
        private void dgCategoria_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (hasGridItems())
            {
                txtNome.Text = dgCategoria.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDescricao.Text = dgCategoria.Rows[e.RowIndex].Cells[2].Value.ToString();

                if (Convert.ToInt16(dgCategoria.Rows[e.RowIndex].Cells[3].Value.ToString()) == 1)
                    rdReceita.Checked = true;
                else
                    rdDespesa.Checked = true;

                if (Convert.ToInt16(dgCategoria.Rows[e.RowIndex].Cells[4].Value.ToString()) == 1)
                    chkStatus.Checked = true;
                else
                    chkStatus.Checked = false;
            }
        }

        private void dgCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
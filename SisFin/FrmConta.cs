using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisFin
{
    public partial class FrmConta : Form
    {
        private List<Categoria> LstCategoria;
        private BindingSource BsCategoria;
        private Conta conta;
        private BindingSource BsConta;
        private List<Conta> LstConta;
        private Categoria categoria;

        private bool edicao;
        private bool insercao;

        public FrmConta()
        {
            InitializeComponent();
            
            categoria = new Categoria();
            conta = new Conta();
            LstCategoria = categoria.GeraCategorias();
            LstConta = conta.GeraContas();
        }

        private void Limpar()
        {
            txtNome.Text = "";
            txtDescricao.Text = "";
            checkBoxStatus.Checked = false;
            comboBoxCategoria.SelectedIndex = 0;
        }

        private bool IsEmpty()
        {
            return LstCategoria.Count == 0 || dgContas.RowCount == 0;
        }

        private bool EmptyError()
        {
            if (IsEmpty())
            {
                MessageBox.Show("Impossível realizar ação: Tabela vazia", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return IsEmpty();
        }

        private void EmptyChecker()
        {
            if (!IsEmpty())
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

        private void FrmConta_Load(object sender, EventArgs e)
        {
            /*
            dgContas.ColumnCount = 3;
            dgContas.AutoGenerateColumns = false;
            dgContas.Columns[0].Width = 50;
            dgContas.Columns[0].HeaderText = "ID";
            dgContas.Columns[0].DataPropertyName = "Id";

            dgContas.Columns[1].Width = 300;
            dgContas.Columns[1].HeaderText = "NOME";
            dgContas.Columns[1].DataPropertyName = "Nome";

            dgContas.Columns[2].Width = 300;
            dgContas.Columns[2].HeaderText = "DESCRIÇÃO";
            dgContas.Columns[2].DataPropertyName = "Descricao";

            dgContas.AllowUserToAddRows = false;
            dgContas.AllowUserToDeleteRows = false;
            dgContas.MultiSelect = false;
            dgContas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            */
            checkBoxStatus.Checked = true;

            dgContas.AllowUserToAddRows = false;
            dgContas.AllowUserToDeleteRows = false;
            dgContas.MultiSelect = false;
            dgContas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgContas.AutoGenerateColumns = false;
            dgContas.ColumnCount = 4;
            dgContas.Columns[0].Width = 50;
            dgContas.Columns[0].HeaderText = "ID";
            dgContas.Columns[0].DataPropertyName = "Id";
            dgContas.Columns[0].Visible = false;
            dgContas.Columns[1].Width = 250;
            dgContas.Columns[1].HeaderText = "NOME";
            dgContas.Columns[1].DataPropertyName = "Nome";
            dgContas.Columns[2].Width = 400;
            dgContas.Columns[2].HeaderText = "DESCRIÇÃO";
            dgContas.Columns[2].DataPropertyName = "Descricao";
            dgContas.Columns[3].Width = 50;
            dgContas.Columns[3].Visible = false;
            dgContas.Columns[3].HeaderText = "STATUS";
            dgContas.Columns[3].DataPropertyName = "Status";

            CarregaCBCategorias();
            CarregaGridContas();
        }

        private void CarregaGridContas()
        {
            BsConta = new BindingSource();
            BsConta.DataSource = LstConta;
            dgContas.DataSource = BsConta;
            dgContas.Refresh();
        }

        private void CarregaCBCategorias(int id = 0)
        {
            BsCategoria = new BindingSource();
            BsCategoria.DataSource = LstCategoria;
            comboBoxCategoria.DataSource = BsCategoria;
            comboBoxCategoria.DisplayMember = "Nome";
            comboBoxCategoria.SelectedItem = "id";

            if (id > 0)
            {
                foreach (var c in LstCategoria)
                {
                    if (c.Id == id)
                    {
                        int index = comboBoxCategoria.FindString(c.Nome);
                        comboBoxCategoria.SelectedIndex = index;
                    }
                }
            }
            comboBoxCategoria.Refresh();
        }

        private void dgContas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!IsEmpty())
            {
                Conta selectedConta = LstConta.ElementAt(e.RowIndex);
                txtNome.Text = selectedConta.Nome;
                txtDescricao.Text = selectedConta.Descricao;
                checkBoxStatus.Checked = selectedConta.Status == 1;
                comboBoxCategoria.SelectedIndex = selectedConta.Id_Categoria;
                btnExcluir.Enabled = true;
            } 
        }

        private void PreencherCampos()
        {
            if (!IsEmpty())
            {
                Conta selectedConta = LstConta.ElementAt(dgContas.CurrentRow.Index);
                txtNome.Text = selectedConta.Nome;
                txtDescricao.Text = selectedConta.Descricao;
                checkBoxStatus.Checked = selectedConta.Status == 1;
                comboBoxCategoria.SelectedIndex = selectedConta.Id_Categoria;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (!EmptyError() && MessageBox.Show("Confirma exclusão?", "Aviso do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                LstConta.RemoveAt(dgContas.CurrentRow.Index);

                if (IsEmpty()) { Limpar(); }
                
                CarregaGridContas();
                MessageBox.Show("Registro excluído com sucesso!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNovo.Focus();
            }

            EmptyChecker();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            gpBoxConta.Enabled = true;
            Limpar();
            txtNome.Focus();
            btnAlterar.Enabled = false;
            btnCancelar.Visible = true;
            btnSalvar.Visible = true;
            btnExcluir.Visible = false;
            btnNovo.Enabled = false;
            dgContas.Enabled = false; //novo
            insercao = true;
            edicao = false;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (!EmptyError())
            {
                btnNovo.Enabled = false;
                btnAlterar.Enabled = false;
                gpBoxConta.Enabled = true;
                txtNome.Enabled = false;
                txtDescricao.Focus();
                btnSalvar.Visible = true;
                btnCancelar.Visible = true;
                btnExcluir.Visible = false;
                dgContas.Enabled = false; //novo
                edicao = true;
                insercao = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo cancelar?", "Mensagem do sistema ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                btnNovo.Enabled = true;
                btnNovo.Focus();
                gpBoxConta.Enabled = false;
                btnAlterar.Enabled = true;
                btnCancelar.Visible = false;
                btnSalvar.Visible = false;
                btnExcluir.Visible = true;
                dgContas.Enabled = true; //novo
                insercao = false;
                edicao = false;

                PreencherCampos();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (insercao)
            {
                Conta insertConta = new Conta();

                insertConta.Nome = txtNome.Text.Trim();
                insertConta.Descricao = txtDescricao.Text.Trim();
                insertConta.Status = checkBoxStatus.Checked ? 1 : 0;
                insertConta.Id_Categoria = comboBoxCategoria.SelectedIndex;
                insertConta.Id = IsEmpty() ? 1 : LstConta.Last().Id + 1;

                conta.addToList(insertConta);
            }

            if (edicao && EmptyError())
            {
                //  int editedItem = LstConta.IndexOf(LstConta.Find(item => item.Nome == txtNome.Text.Trim()));
                // Conta editConta = LstConta.ElementAt(editedItem);

                Conta editConta = LstConta.Find(item  => item.Nome == txtNome.Text.Trim());

                // Aviso para o Matioli...
                MessageBox.Show("Não consegui fazer o alterar funcionar, mas não é obrigatório, de qualquer jeito. Se puder olhar o código e me informar qual meu erro, agradeceria imensamente!", "Aviso da dupla", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (editConta != null)
                {
                    editConta.Descricao = txtDescricao.Text.Trim();
                    editConta.Id_Categoria = comboBoxCategoria.SelectedIndex;
                    editConta.Status = checkBoxStatus.Checked ? 1 : 0;
                }

            }

            CarregaGridContas();

            btnNovo.Enabled = true;
            btnNovo.Focus();
            txtNome.Enabled = true;
            gpBoxConta.Enabled = false;
            btnAlterar.Enabled = true;
            btnCancelar.Visible = false;
            btnSalvar.Visible = false;
            btnExcluir.Visible = true;
            dgContas.Enabled = true; //novo

            insercao = false;
            edicao = false;

            EmptyChecker();
        }

        private void FrmConta_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (edicao || insercao)
            {
                e.Cancel = true;
                MessageBox.Show("Rimani qui!", "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

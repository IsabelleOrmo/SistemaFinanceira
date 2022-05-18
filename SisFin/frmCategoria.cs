﻿using System;
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

        private Categoria categoria = new Categoria();
        private List<Categoria> lstCategoria = new List<Categoria>();
        private BindingSource bsCategoria;

       

        public frmCategoria()
        {
            InitializeComponent();
            lstCategoria = categoria.GeraCategorias();

        }

        private void fechaForm(object sender, FormClosingEventArgs e)
        {
            if (Edicao || Insercao)
            {
                e.Cancel = true;
                MessageBox.Show("Rimani qui!", "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (Insercao)
           
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

        private void novoRegistro(object sender, EventArgs e)
        {
            grpCategoria.Enabled = true;   // Ativar a caixa de grupo
            CamposLimpar();                // Limpar campos do formulário
            categoriaTextNome.Focus();     // Foco no campo Nome
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
        private void altRegistro(object sender, EventArgs e)
        {
            grpCategoria.Enabled = true;   // Ativa a caixa de grupo
            categoriaTextNome.Focus();     // Foco no campo Nome
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
            if (MessageBox.Show("Confirma exclusão?", "Aviso do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                CamposLimpar();
                MessageBox.Show("Registro excluído com sucesso!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNovo.Focus();
            }
        }

        private void cancCadastro(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo cancelar?", "Mensagem do sistema ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CamposLimpar();
                CamposReset();

                Insercao = false;
                Edicao = false;
            }
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



            categoriaTextNome.Text = "Combustível";
            categoriaTextDescricao.Text = "Consumo de combustivéis em um ano pelo consumidor";
            categoriaRadioTipoDespesa.Checked = true;
            categoriaCheckStatus.Checked = true;
        }

        private void carregaGridCategoria()
        {
            bsCategoria = new BindingSource();
            bsCategoria.DataSource = lstCategoria;
            // dgCategoria.Rows.Clear();
            dgCategoria.DataSource = bsCategoria;
            dgCategoria.Refresh();
        }

        private void salvarCadastro(object sender, EventArgs e)
        {
          
            if (Insercao)
            {
                var nome = categoriaTextNome.Text.Trim();
                var descr = categoriaTextDescricao.Text.Trim();
                var tipo = categoriaRadioTipoReceita.Checked ? 1 : 2;
                var status = categoriaCheckStatus.Checked ? 1 : 0;
                categoria.AddToList(3, nome, descr, tipo, status);
            }

            if (Edicao)
            {
                Categoria ct = lstCategoria.Find(item => item.Nome == categoriaTextNome.Text.Trim());
                if (ct != null)
                {
                    ct.Descricao = categoriaTextDescricao.Text.Trim();
                    ct.Tipo = categoriaRadioTipoReceita.Checked ? 1 : 2;
                    ct.Status = categoriaCheckStatus.Checked ? 1 : 0;
                }

            }

            carregaGridCategoria();
            
            MessageBox.Show("Registro salvo com sucesso!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // nn sei se tem q por isso julgue depois gata  CamposReset();

            btnNovo.Enabled = true;
            btnNovo.Focus();
            categoriaTextNome.Enabled = true;
            grpCategoria.Enabled = false;
            btnAlterar.Enabled = true;
            btnCancelar.Visible = false;
            btnSalvar.Visible = false;
            btnExcluir.Visible = true;
            dgCategoria.Enabled = Capture; //novo

            Insercao = false;
            Edicao = false;

        }

        private void dgCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
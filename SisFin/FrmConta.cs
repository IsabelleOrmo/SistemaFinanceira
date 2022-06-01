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
        public FrmConta()
        {
            InitializeComponent();
        }

        private void gpBoxConta_Enter(object sender, EventArgs e)
        {

        }

        private void FrmConta_Load(object sender, EventArgs e)
        {
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
        }
    }
}

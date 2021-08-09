using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormPresetaionLayer.Atualizar
{
    public partial class FormAtualizarFuncionario : Form
    {
        public FormAtualizarFuncionario()
        {
            InitializeComponent();
            buscarModalidade();
        }

        private void PegarValorCheckBox()
        {
            foreach (DataGridViewRow row in dgvModalidade.Rows)
            {
                if (row.IsNewRow) continue;

                if (Convert.ToBoolean(row.Cells["Coluna"].FormattedValue))
                {
                    // Capture os valores aqui 
                }
            }
        }

        public void buscarModalidade()
        {
            var col = new DataGridViewCheckBoxColumn();
            col.Name = "Coluna";
            col.HeaderText = "Selecionado";
            col.FalseValue = false;
            col.TrueValue = true;

            //Make the default checked
            col.CellTemplate.Value = true;
            col.CellTemplate.Style.NullValue = false;

            dgvModalidade.Columns.Insert(0, col);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            
        }
    }
}

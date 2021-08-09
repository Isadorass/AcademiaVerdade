using BussinesLogicalLayer;
using Entites;
using Shared;
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

        private ModalidadesBLL modalidadesBLL = new ModalidadesBLL();

        public FormAtualizarFuncionario()
        {
            InitializeComponent();
            BuscarModalidades();
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

        private void BuscarModalidades()
        {
            DataResponse<Modalidades> response = modalidadesBLL.GetAll();
            List<Modalidades> listaModalidades = new List<Modalidades>();


            foreach (Modalidades modalidade in response.Data)
            {
                Modalidades modalidades = new Modalidades();

                modalidades.ID = modalidade.ID;
                modalidades.Descricao = modalidade.Descricao;
                modalidades.Valor = modalidade.Valor;

                listaModalidades.Add(modalidades);
            }
            if (response.Success)
            {
                var dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
                dataGridViewCheckBoxColumn.Name = "Checkbox";
                dataGridViewCheckBoxColumn.HeaderText = "Selecionado";
                dataGridViewCheckBoxColumn.FalseValue = false;
                dataGridViewCheckBoxColumn.TrueValue = true;

                //Make the default checked
                dataGridViewCheckBoxColumn.CellTemplate.Value = true;
                dataGridViewCheckBoxColumn.CellTemplate.Style.NullValue = false;

                dgvModalidade.Columns.Insert(0, dataGridViewCheckBoxColumn);

                this.dgvModalidade.DataSource = listaModalidades;
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            
        }
    }
}

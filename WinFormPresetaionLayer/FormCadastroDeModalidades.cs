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

namespace WinFormsPresentationLayer
{
    public partial class FormCadastroDeModalidades : Form
    {
        private StandardValidation standardValidation = new StandardValidation();
        private ModalidadesBLL modalidadesBLL = new ModalidadesBLL();

        public FormCadastroDeModalidades()
        {
            InitializeComponent();
            backgroundBtn();
        }

        private void backgroundBtn()
        {
            Color colorBtn = Color.FromArgb(26, 175, 235);
            btnCadastrar.BackColor = colorBtn;
            btnAtualizar.BackColor = colorBtn;
            btnExcluir.BackColor = colorBtn;
            btnEditar.BackColor = colorBtn;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            bool nomeModalidade, descricaoModalidade;

            if (standardValidation.ValidationsNome(txtNomeModalidade.Text).Equals(""))
            {
                lblNomeModalidade.ForeColor = Color.Red;
                nomeModalidade = false;
            }
            else
            {
                lblNomeModalidade.ForeColor = Color.Black;
                nomeModalidade = true;
            }

            if (standardValidation.ValidationsNome(txtDescricaoModalidade.Text).Equals(""))
            {
                lblDescricaoModalidade.ForeColor = Color.Red;
                descricaoModalidade = false;
            }
            else
            {
                lblDescricaoModalidade.ForeColor = Color.Black;
                descricaoModalidade = true;
            }
        }

        private void AtualizarGrid()
        {
            DataResponse<Modalidades> response = modalidadesBLL.GetAll();
            if (response.Success)
            {
                this.dgvCadastroModalidades.DataSource = response.Data;
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Response r = modalidadesBLL.Delete(int.Parse(txtNomeModalidade.Text));
            MessageBox.Show(r.Message);
            if (r.Success)
            {
                this.Close();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Response r = modalidadesBLL.Update(new Modalidades()
            {
                ID = int.Parse(txtNomeModalidade.Text),
                Nome = txtNomeModalidade.Text
            });
            MessageBox.Show(r.Message);
            if (r.Success)
            {
                this.Close();
            }
        }
    }
}

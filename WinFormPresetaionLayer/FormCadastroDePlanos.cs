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
    public partial class FormCadastroDePlanos : Form
    {

        private StandardValidation standardValidation = new StandardValidation();
        private PlanosBLL planosBLL = new PlanosBLL();
        private ModalidadesBLL modalidadeBLL = new ModalidadesBLL();


        public FormCadastroDePlanos()
        {
            InitializeComponent();
            BackgroundBtn();
            this.dgvCadastroPlanos.DataError += DgvCadastroPlanos_DataError;
        }


        private List<Label> CriarListaLabel()
        {
            List<Label> listaLabel = new List<Label>();

            listaLabel.Add(lblModalidade);
            listaLabel.Add(lblDuracao);
            listaLabel.Add(lblQntsVezes);
            listaLabel.Add(lblValor);

            return listaLabel;
        }

        private bool ValidarCampos()
        {
            lblModalidade.ForeColor = standardValidation.ValidationsLabel(standardValidation.ValidationNullOrWhiteSpace(cmbModalidade.Text));
            lblDuracao.ForeColor = standardValidation.ValidationsLabel(standardValidation.ValidationNumero(txtDuracao.Text));
            lblQntsVezes.ForeColor = standardValidation.ValidationsLabel(standardValidation.ValidationQuantidadeVezes(txtQntdVezes.Text));
            lblValor.ForeColor = standardValidation.ValidationsLabel(standardValidation.ValidationValor(txtValor.Text));

            if ((standardValidation.ValidationColor(CriarListaLabel())))
            {
                return true;
            }
            return false;
        }

        private void DgvCadastroPlanos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void BackgroundBtn()
        {
            Color colorBtn = Color.FromArgb(26, 175, 235);
            btnCadastrar.BackColor = colorBtn;
            btnAtualizar.BackColor = colorBtn;
            btnDesativar.BackColor = colorBtn;
            btnEditar.BackColor = colorBtn;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Planos p = new Planos();

                p.Modalidade.ID = (int) cmbModalidade.SelectedValue;
                p.Duracao = txtDuracao.Text.ToInt();
                p.QtdVezes = txtQntdVezes.Text.ToInt();
                p.Valor = txtValor.Text.ToDouble();

                Response response = planosBLL.Insert(p);

                MessageBox.Show(response.Message);
            }
        }

        private void AtualizarGrid()
        {
            DataResponse<Planos> response = planosBLL.GetAll();
            if (response.Success)
            {
                this.dgvCadastroPlanos.DataSource = response.Data;
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

            int id = (int)dgvCadastroPlanos.SelectedRows[0].DataBoundItem;
            Response r = planosBLL.Delete(int.Parse(cmbModalidade.Text));
            MessageBox.Show(r.Message);
            if (r.Success)
            {
                this.Close();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            Planos plano = new Planos();

            plano.Valor = Convert.ToDouble(txtValor.Text);
            plano.Duracao = Convert.ToInt32(txtDuracao.Text);
            plano.QtdVezes = Convert.ToInt32(txtQntdVezes.Text);
            plano.Modalidade.Nome = cmbModalidade.Text; 

            Response r = planosBLL.Update(plano);
            MessageBox.Show(r.Message);
            if (r.Success)
            {
                this.Close();
            }
        }

        private void FormCadastroDePlanos_Load(object sender, EventArgs e)
        {

            DataResponse<Modalidades> response = modalidadeBLL.GetAll();
            if (response.Success)
            {
                cmbModalidade.DataSource = response.Data;
                cmbModalidade.ValueMember = "ID";
                cmbModalidade.DisplayMember = "Nome"; 
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }
    }
}

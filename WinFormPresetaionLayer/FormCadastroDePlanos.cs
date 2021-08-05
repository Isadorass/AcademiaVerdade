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

        public FormCadastroDePlanos()
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
            bool modalidade, valor, duracao, qntdVezes;

            if (standardValidation.ValidationsNome(cmbModalidade.Text).Equals(""))
            {
                lblModalidade.ForeColor = Color.Red;
                modalidade = false;
            }
            else
            {
                lblModalidade.ForeColor = Color.Black;
                modalidade = true;
            }

            if (standardValidation.ValidationsNome(txtValor.Text).Equals(""))
            {
                lblValor.ForeColor = Color.Red;
                valor = false;
            }
            else
            {
                lblValor.ForeColor = Color.Black;
                valor = true;
            }

            if (standardValidation.ValidationsNome(txtDuracao.Text).Equals(""))
            {
                lblDuracao.ForeColor = Color.Red;
                duracao = false;
            }
            else
            {
                lblDuracao.ForeColor = Color.Black;
                duracao = true;
            }

            if (standardValidation.ValidationsNome(txtQntdVezes.Text).Equals(""))
            {
                lblQntsVezes.ForeColor = Color.Red;
                qntdVezes = false;
            }
            else
            {
                lblQntsVezes.ForeColor = Color.Black;
                qntdVezes = true;
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
    }
}

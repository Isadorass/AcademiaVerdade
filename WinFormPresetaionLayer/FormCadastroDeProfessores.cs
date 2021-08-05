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
    public partial class FormCadastroDeProfessores : Form
    {
        private StandardValidation standardValidation = new StandardValidation();
        private ProfessoresBLL professoresBLL = new ProfessoresBLL();

        public FormCadastroDeProfessores()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            bool nome, cpf, rg, telefone, email, dataNascimento, genero,
                 salario, comissao, rua, bairro, cidade, numero, complemento;

            if (standardValidation.ValidationsNome(txtNome.Text).Equals(""))
            {
                lblNome.ForeColor = Color.Red;
                nome = false;
            }
            else
            {
                lblNome.ForeColor = Color.Black;
                nome = true;
            }

            if (standardValidation.ValidationsCpf(txtCPF.Text))
            {
                lblCPF.ForeColor = Color.Black;
                cpf = true;
            }
            else
            {
                lblCPF.ForeColor = Color.Red;
                cpf = false;
            }

            if (standardValidation.ValidationsRg(txtRG.Text))
            {
                lblRG.ForeColor = Color.Black;
                rg = true;
            }
            else
            {
                lblRG.ForeColor = Color.Red;
                rg = false;
            }

            if (standardValidation.ValidationsTelefone(txtTelefone.Text))
            {
                lblTelefone.ForeColor = Color.Black;
                telefone = true;
            }
            else
            {
                lblTelefone.ForeColor = Color.Red;
                telefone = false;
            }

            if (standardValidation.ValidationsEmail(txtEmail.Text))
            {
                lblEmail.ForeColor = Color.Black;
                email = true;
            }
            else
            {
                lblEmail.ForeColor = Color.Red;
                email = false;
            }

            if (standardValidation.ValidationsDataNascimento(dtpDataNascimento.Text))
            {
                lblDataNascimento.ForeColor = Color.Black;
                dataNascimento = true;
            }
            else
            {
                lblDataNascimento.ForeColor = Color.Red;
                dataNascimento = false;
            }

            if (standardValidation.ValidationsGenero(cmbGenero.Text))
            {
                lblGenero.ForeColor = Color.Black;
                genero = true;
            }
            else
            {
                lblGenero.ForeColor = Color.Red;
                genero = false;
            }

            if (standardValidation.ValidationsSalario(txtSalario.Text))
            {
                lblSalario.ForeColor = Color.Black;
                salario = true;
            }
            else
            {
                lblSalario.ForeColor = Color.Red;
                salario = false;
            }            

            if (standardValidation.ValidationsRua(txtRua.Text))
            {
                lblRua.ForeColor = Color.Black;
                rua = true;
            }
            else
            {
                lblRua.ForeColor = Color.Red;
                rua = false;
            }

            if (standardValidation.ValidationsBairro(txtBairro.Text))
            {
                lblBairro.ForeColor = Color.Black;
                bairro = true;
            }
            else
            {
                lblBairro.ForeColor = Color.Red;
                bairro = false;
            }

            if (standardValidation.ValidationsCidade(txtCidade.Text))
            {
                lblCidade.ForeColor = Color.Black;
                cidade = true;
            }
            else
            {
                lblCidade.ForeColor = Color.Red;
                cidade = false;
            }

            if (standardValidation.ValidationNumero(txtNumero.Text))
            {
                lblNumero.ForeColor = Color.Black;
                numero = true;
            }
            else
            {
                lblNumero.ForeColor = Color.Red;
                numero = false;
            }

            if (standardValidation.ValidationsComplementoNumero(txtComplemento.Text, txtNumero.Text))
            {
                lblComplemento.ForeColor = Color.Black;
                complemento = true;
            }
            else
            {
                lblComplemento.ForeColor = Color.Red;
                complemento = false;
            }
        }

        private void AtualizarGrid()
        {
            DataResponse<Professores> response = professoresBLL.GetAll();
            if (response.Success)
            {
                this.dgvCadastroProfessores.DataSource = response.Data;
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
            Response r = professoresBLL.Delete(int.Parse(txtNome.Text));
            MessageBox.Show(r.Message);
            if (r.Success)
            {
                this.Close();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Response r = professoresBLL.Update(new Professores()
            {
                ID = int.Parse(txtNome.Text),
                Nome = txtNome.Text
            });
            MessageBox.Show(r.Message);
            if (r.Success)
            {
                this.Close();
            }
        }
    }
}

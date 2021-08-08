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
            backgroundBtn();
        }

        private void backgroundBtn()
        {
            Color colorBtn = Color.FromArgb(26, 175, 235);
            btnCadastrar.BackColor = colorBtn;
            btnAtualizar.BackColor = colorBtn;
        }


        private List<Label> CriarListaLabel()
        {
            List<Label> listaLabel = new List<Label>();

            listaLabel.Add(lblNome);
            listaLabel.Add(lblEmail);
            listaLabel.Add(lblTelefone);
            listaLabel.Add(lblCPF);
            listaLabel.Add(lblRG);
            listaLabel.Add(lblSalario);
            listaLabel.Add(lblRua);
            listaLabel.Add(lblNumero);
            listaLabel.Add(lblBairro);
            listaLabel.Add(lblCidade);
            listaLabel.Add(lblComplemento);

            return listaLabel;
        }

        private bool ValidarCampos()
        {
            lblNome.ForeColor = standardValidation.ValidationsLabel(standardValidation.ValidationsNome(txtNome.Text));
            lblEmail.ForeColor = standardValidation.ValidationsLabel(standardValidation.ValidationsEmail(txtEmail.Text));
            lblTelefone.ForeColor = standardValidation.ValidationsLabel(standardValidation.ValidationsTelefone(txtTelefone.Text));
            lblCPF.ForeColor = standardValidation.ValidationsLabel(standardValidation.ValidationsCpf(txtCPF.Text));
            lblRG.ForeColor = standardValidation.ValidationsLabel(standardValidation.ValidationsRua(txtRG.Text));
            lblSalario.ForeColor = standardValidation.ValidationsLabel(standardValidation.ValidationsSalario(txtSalario.Text));
            lblRua.ForeColor = standardValidation.ValidationsLabel(standardValidation.ValidationsRua(txtRua.Text));
            lblNumero.ForeColor = standardValidation.ValidationsLabel(standardValidation.ValidationNumero(txtNumero.Text));
            lblBairro.ForeColor = standardValidation.ValidationsLabel(standardValidation.ValidationsBairro(txtBairro.Text));
            lblCidade.ForeColor = standardValidation.ValidationsLabel(standardValidation.ValidationsCidade(txtCidade.Text));
            lblComplemento.ForeColor = standardValidation.ValidationsLabel(standardValidation.ValidationNullOrWhiteSpace(txtComplemento.Text));


            if ((standardValidation.ValidationColor(CriarListaLabel())))
            {
                return true;
            }
            return false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            /*if (ValidarCampos())
            {
                Professores professores = new Professores();

                professores.Nome = txtNome.Text;
                professores.Email = (txtEmail.Text);
                professores.Telefone = (txtTelefone.Text);
                professores.CPF = (txtCPF.Text);
                professores.RG = (txtRG.Text);
                professores.DataNascimento = Convert.ToDateTime(dtpDataNascimento.Text);
                professores.Salario = Convert.ToDouble(txtSalario.Text);
                professores.Ativo = true;
                professores.Usuarios.ID = clientesBLL.SearchClienteInUsuario(txtEmail.Text);
                professores.Genero = cmbGenero.Text;

                clientesBLL.Insert(professores);
            }*/

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
    }
}

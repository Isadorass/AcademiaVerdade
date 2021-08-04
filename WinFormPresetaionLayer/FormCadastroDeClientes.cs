using BussinesLogicalLayer;
using Entites;
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
    public partial class FormCadastroDeClientes : Form
    {

        private StandardValidation standardValidation = new StandardValidation();
        private ClientesBLL clientesBLL = new ClientesBLL();

        public FormCadastroDeClientes()
        {
            InitializeComponent();
            backgroundBtn();
            borderTxt();
        }

        private void backgroundBtn()
        {
            Color colorBtn = Color.FromArgb(26, 175, 235);
            btnCadastrar.BackColor = colorBtn;
            btnAtualizar.BackColor = colorBtn;
            btnExcluir.BackColor = colorBtn;
            btnEditar.BackColor = colorBtn;
        }

        private void borderTxt()
        {
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
            bool nome, cpf, rg, telefoneCelular, telefoneFixo, email, dataNascimento,
                dataMatricula, usuario, genero;

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

            if (standardValidation.ValidationsTelefone(txtTelefoneCelular.Text))
            {
                lblTelefoneCelular.ForeColor = Color.Black;
                telefoneCelular = true;
            }
            else
            {
                lblTelefoneCelular.ForeColor = Color.Red;
                telefoneCelular = false;
            }

            if (standardValidation.ValidationsTelefone(txtTelefoneFixo.Text))
            {
                lblTelefoneFixo.ForeColor = Color.Black;
                telefoneFixo = true;
            }
            else
            {
                lblTelefoneFixo.ForeColor = Color.Red;
                telefoneFixo = false;

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

            if (standardValidation.ValidationsData(dtpDataNascimento.Text))
            {
                lblDataNascimento.ForeColor = Color.Black;
                dataNascimento = true;
            }
            else
            {
                lblDataNascimento.ForeColor = Color.Red;
                dataNascimento = false;
            }

            if (standardValidation.ValidationsData(dtpDataMatricula.Text))
            {
                lblDataMatricula.ForeColor = Color.Black;
                dataMatricula = true;
            }
            else
            {
                lblDataMatricula.ForeColor = Color.Red;
                dataMatricula = false;
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

            if (clientesBLL.SearchClienteInUsuario(txtEmail.Text) != 0)
            {
                usuario = true;
                lblMensagem.Text = "Preencha todos os campos corretamente para cadastrar o cliente";
            } 
            else
            {
                usuario = false;
                lblMensagem.Text = "Este cliente ainda não possui um usuário." +
                    "\rCadastre o cliente com o mesmo email do usuário.";
            }

            if (nome && cpf && rg && telefoneCelular 
                && telefoneFixo
                && email && dataMatricula 
                && dataNascimento && usuario
                && genero)
            {
                Clientes cliente = new Clientes();

                cliente.Nome = txtNome.Text;
                cliente.CPF = Convert.ToInt32(txtCPF.Text);
                cliente.RG = Convert.ToInt32(txtRG.Text);
                cliente.TelefoneCelualar = Convert.ToInt32(txtTelefoneCelular.Text);
                cliente.TelefoneFixo = Convert.ToInt32(txtTelefoneFixo.Text);
                cliente.Email = txtEmail.Text;
                cliente.DataNascimento = Convert.ToDateTime(dtpDataNascimento.Text);
                cliente.DataMatricula = Convert.ToDateTime(dtpDataMatricula.Text);
                cliente.Ativo = true;
                cliente.Usuarios.ID = clientesBLL.SearchClienteInUsuario(txtEmail.Text);
                cliente.Genero = cmbGenero.Text;

                clientesBLL.Insert(cliente);
            }
        }
    }
}

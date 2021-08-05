using BussinesLogicalLayer;
using Entites;
using Entities.DTO;
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
    public partial class FormCadastroDeClientes : Form
    {

        private StandardValidation standardValidation = new StandardValidation();
        private ClientesBLL clientesBLL = new ClientesBLL();

        public FormCadastroDeClientes()
        {
            InitializeComponent();
            backgroundBtn();
            toolTipBtnAtualizarGrid();
            colorirPanel();
        }

        private bool validarCampos()
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

            if (standardValidation.ValidationsDataMatricula(dtpDataMatricula.Text))
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
                return true;
            }
            return false;
        }

        private void colorirPanel()
        {
            Color colorPanel = Color.FromArgb(26, 175, 235);
            panelFundoMensagem.BackColor = colorPanel;
        }

        private void backgroundBtn()
        {
            Color colorBtn = Color.FromArgb(26, 175, 235);
            btnCadastrar.BackColor = colorBtn;
            btnAtualizar.BackColor = colorBtn;
            btnExcluir.BackColor = colorBtn;
            btnEditar.BackColor = colorBtn;
        }

        private void toolTipBtnAtualizarGrid()
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.btnAtualizar, "Atualizar Tabela");
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (validarCampos()) { 
                Clientes cliente = new Clientes();
                Usuarios usuario = new Usuarios();

                cliente.Nome = txtNome.Text;
                cliente.CPF = (txtCPF.Text);
                cliente.RG = (txtRG.Text);
                cliente.TelefoneCelular = (txtTelefoneCelular.Text);
                cliente.TelefoneFixo = (txtTelefoneFixo.Text);
                cliente.Email = txtEmail.Text;
                cliente.DataNascimento = Convert.ToDateTime(dtpDataNascimento.Text);
                cliente.DataMatricula = Convert.ToDateTime(dtpDataMatricula.Text);
                cliente.Ativo = true;
                usuario.ID = clientesBLL.SearchClienteInUsuario(txtEmail.Text);
                cliente.Usuarios = usuario; 
                cliente.Genero = cmbGenero.Text;

                clientesBLL.Insert(cliente);
            }
        }

        private void AtualizarGrid()
        {
            DataResponse<Clientes> response = clientesBLL.GetAll();
            List<ClienteDTO> listaClienteDTO = new List<ClienteDTO>();

            foreach(Clientes cliente in response.Data)
            {
                ClienteDTO clienteDTO = new ClienteDTO();

                clienteDTO.Nome = cliente.Nome;
                clienteDTO.CPF = cliente.CPF;
                clienteDTO.RG = cliente.RG;
                clienteDTO.TelefoneCelular = cliente.TelefoneCelular;
                clienteDTO.TelefoneFixo = cliente.TelefoneFixo;
                clienteDTO.Email = cliente.Email;
                clienteDTO.DataNascimento = cliente.DataNascimento;
                clienteDTO.DataMatricula = cliente.DataMatricula;
                clienteDTO.Genero = cliente.Genero;
                clienteDTO.Ativo = cliente.Ativo;

                listaClienteDTO.Add(clienteDTO);
            }

            if (response.Success)
            {
                this.dgvCadastroClientes.DataSource = listaClienteDTO;
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
            if (standardValidation.ValidationsCpf(txtCPF.Text))
            {
                lblCPF.ForeColor = Color.Black;
                clientesBLL.Delete(txtCPF.Text);
            }
            else
            {
                lblCPF.ForeColor = Color.Red;
                
            }            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                Clientes cliente = new Clientes();
                Usuarios usuario = new Usuarios();

                cliente.Nome = txtNome.Text;
                cliente.CPF = (txtCPF.Text);
                cliente.RG = (txtRG.Text);
                cliente.TelefoneCelular = (txtTelefoneCelular.Text);
                cliente.TelefoneFixo = (txtTelefoneFixo.Text);
                cliente.Email = txtEmail.Text;
                cliente.DataNascimento = Convert.ToDateTime(dtpDataNascimento.Text);
                cliente.DataMatricula = Convert.ToDateTime(dtpDataMatricula.Text);
                cliente.Ativo = true;
                usuario.ID = clientesBLL.SearchClienteInUsuario(txtEmail.Text);
                cliente.Usuarios = usuario;
                cliente.Genero = cmbGenero.Text;

                clientesBLL.Update(cliente);
            }
        }
    }
}

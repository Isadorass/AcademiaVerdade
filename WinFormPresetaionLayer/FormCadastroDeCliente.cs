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
            BackgroundBtn();
            ToolTipBtnAtualizarGrid();
            ColorirPanel();
        }

        private List<Label> CriarListaLabel()
        {
            List<Label> listaLabel = new List<Label>();

            listaLabel.Add(lblNome);
            listaLabel.Add(lblCPF);
            listaLabel.Add(lblRG);
            listaLabel.Add(lblTelefoneCelular);
            listaLabel.Add(lblTelefoneFixo);
            listaLabel.Add(lblEmail);
            listaLabel.Add(lblDataMatricula);
            listaLabel.Add(lblDataNascimento);
            listaLabel.Add(lblGenero);

            return listaLabel;
        }

        private bool ValidarCampos()
        {
            lblNome.ForeColor = standardValidation.ValidationsLabel(standardValidation.ValidationsNome(txtNome.Text));
            lblCPF.ForeColor = standardValidation.ValidationsLabel(standardValidation.ValidationsCpf(txtCPF.Text));
            lblRG.ForeColor = standardValidation.ValidationsLabel(standardValidation.ValidationsRg(txtRG.Text));
            lblTelefoneCelular.ForeColor = standardValidation.ValidationsLabel(standardValidation.ValidationsTelefone(txtTelefoneCelular.Text));
            lblTelefoneFixo.ForeColor = standardValidation.ValidationsLabel(standardValidation.ValidationsTelefone(txtTelefoneFixo.Text));
            lblEmail.ForeColor = standardValidation.ValidationsLabel(standardValidation.ValidationsEmail(txtEmail.Text));
            lblDataMatricula.ForeColor = standardValidation.ValidationsLabel(standardValidation.ValidationsDataMatricula(dtpDataMatricula.Text));
            lblDataNascimento.ForeColor = standardValidation.ValidationsLabel(standardValidation.ValidationsDataNascimento(dtpDataNascimento.Text));
            lblGenero.ForeColor = standardValidation.ValidationsLabel(standardValidation.ValidationsGenero(cmbGenero.Text));

            if ((standardValidation.ValidationColor(CriarListaLabel())))
            {
                return true;              
            }
            return false;
        }

        private void ColorirPanel()
        {
            Color colorPanel = Color.FromArgb(26, 175, 235);
            panelFundoMensagem.BackColor = colorPanel;
        }

        private void BackgroundBtn()
        {
            Color colorBtn = Color.FromArgb(26, 175, 235);
            btnCadastrar.BackColor = colorBtn;
            btnAtualizar.BackColor = colorBtn;
        }

        private void ToolTipBtnAtualizarGrid()
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.btnAtualizar, "Atualizar Tabela");
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            { 
                Clientes cliente = new Clientes();

                cliente.Nome = (txtNome.Text);
                cliente.CPF = (txtCPF.Text);
                cliente.RG = (txtRG.Text);
                cliente.TelefoneCelular = (txtTelefoneCelular.Text);
                cliente.TelefoneFixo = (txtTelefoneFixo.Text);
                cliente.Email = txtEmail.Text;
                cliente.DataNascimento = Convert.ToDateTime(dtpDataNascimento.Text);
                cliente.DataMatricula = Convert.ToDateTime(dtpDataMatricula.Text);
                cliente.Ativo = true;
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

        private void PegarValorCheckBox()
        {
            foreach (DataGridViewRow row in dgvCadastroClientes.Rows)
            {
                if (row.IsNewRow) continue;

                if (Convert.ToBoolean(row.Cells["Coluna"].FormattedValue))
                {
                    // Capture os valores aqui 
                }
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

            var col = new DataGridViewCheckBoxColumn();
            col.Name = "Coluna";
            col.HeaderText = "Selecionado";
            col.FalseValue = "0";
            col.TrueValue = "1";

            //Make the default checked
            col.CellTemplate.Value = true;
            col.CellTemplate.Style.NullValue = false;

            dgvCadastroClientes.Columns.Insert(0, col);


            AtualizarGrid();
        }

        private void FormCadastroDeClientes_Load(object sender, EventArgs e)
        {

        }
    }
}

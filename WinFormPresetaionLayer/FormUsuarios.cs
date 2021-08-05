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
    public partial class FormUsuarios : Form
    {
        private StandardValidation standardValidation = new StandardValidation();
        private UsuariosBLL usuariosBLL = new UsuariosBLL();

        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            bool nome, email, senha, papel;

            if (standardValidation.ValidationsEmail(txtNome.Text).Equals(""))
            {
                lblNome.ForeColor = Color.Red;
                nome = false;
            }
            else
            {
                lblNome.ForeColor = Color.Black;
                nome = true;
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

            if (standardValidation.ValidationsSenha(txtSenha.Text))
            {
                lblSenha.ForeColor = Color.Black;
                senha = true;
            }
            else
            {
                lblSenha.ForeColor = Color.Red;
                senha = false;
            }

            if (standardValidation.ValidationsPapel(cmbPapel.Text))
            {
                lblPapel.ForeColor = Color.Black;
                papel = true;
            }
            else
            {
                lblPapel.ForeColor = Color.Red;
                papel = false;
            }
        }

        private void AtualizarGrid()
        {
            DataResponse<Usuarios> response = usuariosBLL.GetAll();
            if (response.Success)
            {
                this.dgvCadastrarUsuarios.DataSource = response.Data;
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
            Response r = usuariosBLL.Delete(int.Parse(txtNome.Text));
            MessageBox.Show(r.Message);
            if (r.Success)
            {
                this.Close();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Response r = usuariosBLL.Update(new Usuarios()
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

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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsuarios formUsuarios = new FormUsuarios();
            formUsuarios.Visible = true;
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormCadastroDeClientes formCadastroDeClientes = new FormCadastroDeClientes();
            formCadastroDeClientes.Visible = true;
        }
    }
}

using BussinesLogicalLayer;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsPresentationLayer
{
    public partial class FormLogin : Form
    {
        private FuncionarioBLL funcionarioBLL = new FuncionarioBLL();

        public FormLogin()
        {
            InitializeComponent();
            BackgroundBtn();
        }

        private void BackgroundBtn()
        {
            Color colorBtn = Color.FromArgb(26, 175, 235);
            btnEntrar.BackColor = colorBtn;
        }

        private bool Logar(string email, string senha)
        {
            return funcionarioBLL.Logar(email, senha);
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (Logar(txtEmail.Text, txtSenha.Text))
            {
                this.Hide();
                FormMenu formMenu = new FormMenu();
                FormLogin formLogin = new FormLogin();
                formLogin.Closed += (s, args) => this.Close();
                formMenu.Show();
            }
            else
            {
                MessageBox.Show("Email ou senhas incorretos." +
                    "\nVerifique e tente novamente", "Dados inválidos!");
            }
        }
    }
}

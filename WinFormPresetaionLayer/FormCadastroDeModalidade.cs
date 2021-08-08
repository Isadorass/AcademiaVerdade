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

namespace WinFormPresetaionLayer
{
    public partial class FormCadastroDeModalidade : Form
    {

        private StandardValidation standardValidation = new StandardValidation();
        private ModalidadesBLL modalidadesBLL = new ModalidadesBLL();

        public FormCadastroDeModalidade()
        {
            InitializeComponent();
            BackgroundBtn();
        }

        private List<Label> CriarListaLabel()
        {
            List<Label> listaLabel = new List<Label>();

            listaLabel.Add(lblDescricao);
            listaLabel.Add(lblValor);

            return listaLabel;
        }

        private bool ValidarCampos()
        {
            lblDescricao.ForeColor = standardValidation.ValidationsLabel(standardValidation.ValidationsDescricao(txtDescricao.Text));
            lblValor.ForeColor = standardValidation.ValidationsLabel(standardValidation.ValidationValor(txtValor.Text));

            if ((standardValidation.ValidationColor(CriarListaLabel())))
            {
                return true;
            }
            return false;
        }

        private void BackgroundBtn()
        {
            Color colorBtn = Color.FromArgb(26, 175, 235);
            btnCadastrar.BackColor = colorBtn;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Modalidades modalidades = new Modalidades();

                modalidades.Descricao = txtDescricao.Text;
                modalidades.Valor = (txtValor.Text).ToDouble();

                modalidadesBLL.Insert(modalidades);
            }
        }
    }
}

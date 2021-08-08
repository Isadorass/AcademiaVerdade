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
    public partial class FormCadastroDeProdutos : Form
    {
        private StandardValidation standardValidation = new StandardValidation();
        private ProdutosBLL produtosBLL = new ProdutosBLL();

        public FormCadastroDeProdutos()
        {
            InitializeComponent();
            backgroundBtn();
        }

        private void backgroundBtn()
        {
            Color colorBtn = Color.FromArgb(26, 175, 235);
            btnCadastrar.BackColor = colorBtn;
        }

        private List<Label> CriarListaLabel()
        {
            List<Label> listaLabel = new List<Label>();

            listaLabel.Add(lblCategoria);
            listaLabel.Add(lblDescricaoProduto);
            listaLabel.Add(lblNomeProduto);

            return listaLabel;
        }
        
        private bool ValidarCampos()
        {
            lblCategoria.ForeColor = standardValidation.ValidationsLabel(standardValidation.ValidationNullOrWhiteSpace(cmbCategoria.Text));
            lblDescricaoProduto.ForeColor = standardValidation.ValidationsLabel(standardValidation.ValidationsCaracteres(txtDescricaoProduto.Text));
            lblNomeProduto.ForeColor = standardValidation.ValidationsLabel(standardValidation.ValidationsCaracteres(txtNomeProduto.Text));

            if ((standardValidation.ValidationColor(CriarListaLabel())))
            {
                return true;
            }
            return false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Produtos p = new Produtos();

                p.Categoria.ID = (int)cmbCategoria.SelectedValue;
                p.Descricao = txtDescricaoProduto.Text;

                Response response = produtosBLL.Insert(p);

                MessageBox.Show(response.Message);
            }
        }
    }
}

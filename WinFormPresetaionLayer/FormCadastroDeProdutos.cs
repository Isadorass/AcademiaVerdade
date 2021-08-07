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
            btnAtualizar.BackColor = colorBtn;
            btnExcluir.BackColor = colorBtn;
            btnEditar.BackColor = colorBtn;
        }

        private List<Label> CriarListaLabel()
        {
            List<Label> listaLabel = new List<Label>();

            listaLabel.Add(lblCategoria);
            listaLabel.Add(lblDescricaoProduto);
            listaLabel.Add(lblEstoque);
            listaLabel.Add(lblNomeProduto);
            listaLabel.Add(lblPreco);

            return listaLabel;
        }
        
        private bool ValidarCampos()
        {
            lblCategoria.ForeColor = standardValidation.ValidationsLabel(standardValidation.ValidationNullOrWhiteSpace(cmbCategoria.Text));
            lblDescricaoProduto.ForeColor = standardValidation.ValidationsLabel(standardValidation.ValidationsCaracteres(txtDescricaoProduto.Text));
            lblEstoque.ForeColor = standardValidation.ValidationsLabel(standardValidation.ValidationNullOrWhiteSpace(txtEstoque.Text));
            lblNomeProduto.ForeColor = standardValidation.ValidationsLabel(standardValidation.ValidationsCaracteres(txtNomeProduto.Text));
            lblPreco.ForeColor = standardValidation.ValidationsLabel(standardValidation.ValidationValor(txtPreco.Text));

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
                p.Estoque = txtEstoque.Text.ToInt();
                p.Preco = txtPreco.Text.ToDouble();

                Response response = produtosBLL.Insert(p);

                MessageBox.Show(response.Message);
            }

        }

        private void AtualizarGrid()
        {
            DataResponse<Produtos> response = produtosBLL.GetAll();
            if (response.Success)
            {
                this.dgvCadastroProdutos.DataSource = response.Data;
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
            Response r = produtosBLL.Delete(int.Parse(txtNomeProduto.Text));
            MessageBox.Show(r.Message);
            if (r.Success)
            {
                this.Close();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Response r = produtosBLL.Update(new Produtos()
            {
                ID = int.Parse(txtNomeProduto.Text),
                Nome = txtNomeProduto.Text
            });
            MessageBox.Show(r.Message);
            if (r.Success)
            {
                this.Close();
            }
        }

        
    }
}

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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            bool nomeProduto, qntdEstoque, descricaoProduto, suplementos, 
                 mantimentos, acessorios;

            if (standardValidation.ValidationsNome(txtNomeProduto.Text).Equals(""))
            {
                lblNomeProduto.ForeColor = Color.Red;
                nomeProduto = false;
            }
            else
            {
                lblNomeProduto.ForeColor = Color.Black;
                nomeProduto = true;
            }

            if (standardValidation.ValidationsNome(txtQntdEstoqueProduto.Text).Equals(""))
            {
                lblEstoque.ForeColor = Color.Red;
                qntdEstoque = false;
            }
            else
            {
                lblEstoque.ForeColor = Color.Black;
                qntdEstoque = true;
            }

            if (standardValidation.ValidationsNome(txtDescricaoProduto.Text).Equals(""))
            {
                lblDescricaoProduto.ForeColor = Color.Red;
                descricaoProduto = false;
            }
            else
            {
                lblDescricaoProduto.ForeColor = Color.Black;
                descricaoProduto = true;
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

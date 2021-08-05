
namespace WinFormsPresentationLayer
{
    partial class FormCadastroDeProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDescricaoProduto = new System.Windows.Forms.Label();
            this.txtDescricaoProduto = new System.Windows.Forms.TextBox();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.txtQntdEstoqueProduto = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.chMantimentos = new System.Windows.Forms.CheckBox();
            this.chSuplementos = new System.Windows.Forms.CheckBox();
            this.chAcessorios = new System.Windows.Forms.CheckBox();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dgvCadastroProdutos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescricaoProduto
            // 
            this.lblDescricaoProduto.AutoSize = true;
            this.lblDescricaoProduto.BackColor = System.Drawing.Color.Transparent;
            this.lblDescricaoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoProduto.ForeColor = System.Drawing.Color.Black;
            this.lblDescricaoProduto.Location = new System.Drawing.Point(28, 88);
            this.lblDescricaoProduto.Name = "lblDescricaoProduto";
            this.lblDescricaoProduto.Size = new System.Drawing.Size(152, 18);
            this.lblDescricaoProduto.TabIndex = 43;
            this.lblDescricaoProduto.Text = "Descrição do produto";
            // 
            // txtDescricaoProduto
            // 
            this.txtDescricaoProduto.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescricaoProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricaoProduto.Location = new System.Drawing.Point(31, 109);
            this.txtDescricaoProduto.Name = "txtDescricaoProduto";
            this.txtDescricaoProduto.Size = new System.Drawing.Size(339, 20);
            this.txtDescricaoProduto.TabIndex = 41;
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProduto.ForeColor = System.Drawing.Color.Black;
            this.lblNomeProduto.Location = new System.Drawing.Point(28, 30);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(49, 18);
            this.lblNomeProduto.TabIndex = 44;
            this.lblNomeProduto.Text = "Nome";
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.BackColor = System.Drawing.Color.Transparent;
            this.lblEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoque.ForeColor = System.Drawing.Color.Black;
            this.lblEstoque.Location = new System.Drawing.Point(209, 30);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(161, 18);
            this.lblEstoque.TabIndex = 46;
            this.lblEstoque.Text = "Quantidade no estoque";
            // 
            // txtQntdEstoqueProduto
            // 
            this.txtQntdEstoqueProduto.BackColor = System.Drawing.SystemColors.Window;
            this.txtQntdEstoqueProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQntdEstoqueProduto.Location = new System.Drawing.Point(209, 52);
            this.txtQntdEstoqueProduto.Name = "txtQntdEstoqueProduto";
            this.txtQntdEstoqueProduto.Size = new System.Drawing.Size(161, 20);
            this.txtQntdEstoqueProduto.TabIndex = 45;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.Black;
            this.lblCategoria.Location = new System.Drawing.Point(28, 146);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(76, 18);
            this.lblCategoria.TabIndex = 47;
            this.lblCategoria.Text = "Categoria:";
            // 
            // chMantimentos
            // 
            this.chMantimentos.AutoSize = true;
            this.chMantimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chMantimentos.Location = new System.Drawing.Point(31, 209);
            this.chMantimentos.Name = "chMantimentos";
            this.chMantimentos.Size = new System.Drawing.Size(120, 24);
            this.chMantimentos.TabIndex = 48;
            this.chMantimentos.Text = "Mantimentos";
            this.chMantimentos.UseVisualStyleBackColor = true;
            // 
            // chSuplementos
            // 
            this.chSuplementos.AutoSize = true;
            this.chSuplementos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chSuplementos.Location = new System.Drawing.Point(31, 179);
            this.chSuplementos.Name = "chSuplementos";
            this.chSuplementos.Size = new System.Drawing.Size(122, 24);
            this.chSuplementos.TabIndex = 49;
            this.chSuplementos.Text = "Suplementos";
            this.chSuplementos.UseVisualStyleBackColor = true;
            // 
            // chAcessorios
            // 
            this.chAcessorios.AutoSize = true;
            this.chAcessorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chAcessorios.Location = new System.Drawing.Point(31, 236);
            this.chAcessorios.Name = "chAcessorios";
            this.chAcessorios.Size = new System.Drawing.Size(106, 24);
            this.chAcessorios.TabIndex = 50;
            this.chAcessorios.Text = "Acessórios";
            this.chAcessorios.UseVisualStyleBackColor = true;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.BackColor = System.Drawing.SystemColors.Window;
            this.txtNomeProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeProduto.Location = new System.Drawing.Point(31, 52);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(172, 20);
            this.txtNomeProduto.TabIndex = 51;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(294, 274);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(76, 34);
            this.btnEditar.TabIndex = 57;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(213, 274);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 34);
            this.btnExcluir.TabIndex = 56;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.Location = new System.Drawing.Point(126, 274);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(81, 34);
            this.btnAtualizar.TabIndex = 55;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(31, 274);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(89, 34);
            this.btnCadastrar.TabIndex = 54;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dgvCadastroProdutos
            // 
            this.dgvCadastroProdutos.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dgvCadastroProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadastroProdutos.Location = new System.Drawing.Point(389, 52);
            this.dgvCadastroProdutos.Name = "dgvCadastroProdutos";
            this.dgvCadastroProdutos.Size = new System.Drawing.Size(240, 256);
            this.dgvCadastroProdutos.TabIndex = 58;
            // 
            // FormCadastroDeProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 359);
            this.Controls.Add(this.dgvCadastroProdutos);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.chAcessorios);
            this.Controls.Add(this.chSuplementos);
            this.Controls.Add(this.chMantimentos);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.txtQntdEstoqueProduto);
            this.Controls.Add(this.lblDescricaoProduto);
            this.Controls.Add(this.txtDescricaoProduto);
            this.Controls.Add(this.lblNomeProduto);
            this.Name = "FormCadastroDeProdutos";
            this.Text = "Cadastrar Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescricaoProduto;
        private System.Windows.Forms.TextBox txtDescricaoProduto;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.TextBox txtQntdEstoqueProduto;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.CheckBox chMantimentos;
        private System.Windows.Forms.CheckBox chSuplementos;
        private System.Windows.Forms.CheckBox chAcessorios;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView dgvCadastroProdutos;
    }
}

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
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricaoProduto = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.txtQntdEstoque = new System.Windows.Forms.TextBox();
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
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.BackColor = System.Drawing.Color.Transparent;
            this.lblDescricao.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDescricao.Location = new System.Drawing.Point(32, 103);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(109, 13);
            this.lblDescricao.TabIndex = 43;
            this.lblDescricao.Text = "Descrição do produto";
            // 
            // txtDescricaoProduto
            // 
            this.txtDescricaoProduto.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescricaoProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricaoProduto.Location = new System.Drawing.Point(35, 119);
            this.txtDescricaoProduto.Name = "txtDescricaoProduto";
            this.txtDescricaoProduto.Size = new System.Drawing.Size(325, 20);
            this.txtDescricaoProduto.TabIndex = 41;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.ForeColor = System.Drawing.SystemColors.Window;
            this.lblNome.Location = new System.Drawing.Point(32, 50);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 44;
            this.lblNome.Text = "Nome";
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.BackColor = System.Drawing.Color.Transparent;
            this.lblEstoque.ForeColor = System.Drawing.SystemColors.Window;
            this.lblEstoque.Location = new System.Drawing.Point(210, 50);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(118, 13);
            this.lblEstoque.TabIndex = 46;
            this.lblEstoque.Text = "Quantidade no estoque";
            // 
            // txtQntdEstoque
            // 
            this.txtQntdEstoque.BackColor = System.Drawing.SystemColors.Window;
            this.txtQntdEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQntdEstoque.Location = new System.Drawing.Point(213, 66);
            this.txtQntdEstoque.Name = "txtQntdEstoque";
            this.txtQntdEstoque.Size = new System.Drawing.Size(147, 20);
            this.txtQntdEstoque.TabIndex = 45;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoria.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCategoria.Location = new System.Drawing.Point(32, 157);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 47;
            this.lblCategoria.Text = "Categoria:";
            // 
            // chMantimentos
            // 
            this.chMantimentos.AutoSize = true;
            this.chMantimentos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.chMantimentos.Location = new System.Drawing.Point(35, 188);
            this.chMantimentos.Name = "chMantimentos";
            this.chMantimentos.Size = new System.Drawing.Size(86, 17);
            this.chMantimentos.TabIndex = 48;
            this.chMantimentos.Text = "Mantimentos";
            this.chMantimentos.UseVisualStyleBackColor = false;
            // 
            // chSuplementos
            // 
            this.chSuplementos.AutoSize = true;
            this.chSuplementos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.chSuplementos.Location = new System.Drawing.Point(35, 220);
            this.chSuplementos.Name = "chSuplementos";
            this.chSuplementos.Size = new System.Drawing.Size(87, 17);
            this.chSuplementos.TabIndex = 49;
            this.chSuplementos.Text = "Suplementos";
            this.chSuplementos.UseVisualStyleBackColor = false;
            // 
            // chAcessorios
            // 
            this.chAcessorios.AutoSize = true;
            this.chAcessorios.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.chAcessorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chAcessorios.Location = new System.Drawing.Point(35, 252);
            this.chAcessorios.Name = "chAcessorios";
            this.chAcessorios.Size = new System.Drawing.Size(85, 19);
            this.chAcessorios.TabIndex = 50;
            this.chAcessorios.Text = "Acessórios";
            this.chAcessorios.UseVisualStyleBackColor = false;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.BackColor = System.Drawing.SystemColors.Window;
            this.txtNomeProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeProduto.Location = new System.Drawing.Point(35, 66);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(172, 20);
            this.txtNomeProduto.TabIndex = 51;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(284, 288);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(76, 34);
            this.btnEditar.TabIndex = 57;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(213, 288);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(65, 34);
            this.btnExcluir.TabIndex = 56;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(126, 288);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(81, 34);
            this.btnAtualizar.TabIndex = 55;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(31, 288);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(89, 34);
            this.btnCadastrar.TabIndex = 54;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // dgvCadastroProdutos
            // 
            this.dgvCadastroProdutos.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dgvCadastroProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadastroProdutos.Location = new System.Drawing.Point(389, 66);
            this.dgvCadastroProdutos.Name = "dgvCadastroProdutos";
            this.dgvCadastroProdutos.Size = new System.Drawing.Size(240, 256);
            this.dgvCadastroProdutos.TabIndex = 58;
            // 
            // FormCadastroDeProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.Controls.Add(this.txtQntdEstoque);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtDescricaoProduto);
            this.Controls.Add(this.lblNome);
            this.Name = "FormCadastroDeProdutos";
            this.Text = "Cadastrar Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricaoProduto;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.TextBox txtQntdEstoque;
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
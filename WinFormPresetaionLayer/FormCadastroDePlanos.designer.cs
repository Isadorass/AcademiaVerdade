
namespace WinFormsPresentationLayer
{
    partial class FormCadastroDePlanos
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
            this.lblModalidade = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblQntsVezes = new System.Windows.Forms.Label();
            this.txtQntdVezes = new System.Windows.Forms.TextBox();
            this.lblDuracao = new System.Windows.Forms.Label();
            this.txtDuracao = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDesativar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dgvCadastroPlanos = new System.Windows.Forms.DataGridView();
            this.cmbModalidade = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroPlanos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblModalidade
            // 
            this.lblModalidade.AutoSize = true;
            this.lblModalidade.BackColor = System.Drawing.Color.Transparent;
            this.lblModalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModalidade.ForeColor = System.Drawing.Color.Black;
            this.lblModalidade.Location = new System.Drawing.Point(27, 26);
            this.lblModalidade.Name = "lblModalidade";
            this.lblModalidade.Size = new System.Drawing.Size(84, 18);
            this.lblModalidade.TabIndex = 52;
            this.lblModalidade.Text = "Modalidade";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.BackColor = System.Drawing.Color.Transparent;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.Black;
            this.lblValor.Location = new System.Drawing.Point(246, 26);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(42, 18);
            this.lblValor.TabIndex = 55;
            this.lblValor.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(249, 47);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(191, 20);
            this.txtValor.TabIndex = 54;
            // 
            // lblQntsVezes
            // 
            this.lblQntsVezes.AutoSize = true;
            this.lblQntsVezes.BackColor = System.Drawing.Color.Transparent;
            this.lblQntsVezes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQntsVezes.ForeColor = System.Drawing.Color.Black;
            this.lblQntsVezes.Location = new System.Drawing.Point(246, 85);
            this.lblQntsVezes.Name = "lblQntsVezes";
            this.lblQntsVezes.Size = new System.Drawing.Size(148, 18);
            this.lblQntsVezes.TabIndex = 57;
            this.lblQntsVezes.Text = "Quantidade de Vezes";
            // 
            // txtQntdVezes
            // 
            this.txtQntdVezes.Location = new System.Drawing.Point(249, 106);
            this.txtQntdVezes.Name = "txtQntdVezes";
            this.txtQntdVezes.Size = new System.Drawing.Size(191, 20);
            this.txtQntdVezes.TabIndex = 56;
            // 
            // lblDuracao
            // 
            this.lblDuracao.AutoSize = true;
            this.lblDuracao.BackColor = System.Drawing.Color.Transparent;
            this.lblDuracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuracao.ForeColor = System.Drawing.Color.Black;
            this.lblDuracao.Location = new System.Drawing.Point(27, 85);
            this.lblDuracao.Name = "lblDuracao";
            this.lblDuracao.Size = new System.Drawing.Size(65, 18);
            this.lblDuracao.TabIndex = 59;
            this.lblDuracao.Text = "Duração";
            // 
            // txtDuracao
            // 
            this.txtDuracao.Location = new System.Drawing.Point(30, 106);
            this.txtDuracao.Name = "txtDuracao";
            this.txtDuracao.Size = new System.Drawing.Size(214, 20);
            this.txtDuracao.TabIndex = 58;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditar.Location = new System.Drawing.Point(348, 347);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(95, 34);
            this.btnEditar.TabIndex = 68;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDesativar
            // 
            this.btnDesativar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnDesativar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesativar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesativar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesativar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDesativar.Location = new System.Drawing.Point(249, 347);
            this.btnDesativar.Name = "btnDesativar";
            this.btnDesativar.Size = new System.Drawing.Size(93, 34);
            this.btnDesativar.TabIndex = 67;
            this.btnDesativar.Text = "Desativar";
            this.btnDesativar.UseVisualStyleBackColor = false;
            this.btnDesativar.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAtualizar.Location = new System.Drawing.Point(140, 347);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(93, 34);
            this.btnAtualizar.TabIndex = 66;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCadastrar.Location = new System.Drawing.Point(30, 347);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(93, 34);
            this.btnCadastrar.TabIndex = 65;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dgvCadastroPlanos
            // 
            this.dgvCadastroPlanos.AllowUserToAddRows = false;
            this.dgvCadastroPlanos.AllowUserToDeleteRows = false;
            this.dgvCadastroPlanos.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dgvCadastroPlanos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadastroPlanos.Location = new System.Drawing.Point(29, 145);
            this.dgvCadastroPlanos.Name = "dgvCadastroPlanos";
            this.dgvCadastroPlanos.ReadOnly = true;
            this.dgvCadastroPlanos.Size = new System.Drawing.Size(414, 196);
            this.dgvCadastroPlanos.TabIndex = 64;
            // 
            // cmbModalidade
            // 
            this.cmbModalidade.FormattingEnabled = true;
            this.cmbModalidade.Location = new System.Drawing.Point(30, 47);
            this.cmbModalidade.Name = "cmbModalidade";
            this.cmbModalidade.Size = new System.Drawing.Size(213, 21);
            this.cmbModalidade.TabIndex = 69;
            // 
            // FormCadastroDePlanos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 387);
            this.Controls.Add(this.cmbModalidade);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnDesativar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dgvCadastroPlanos);
            this.Controls.Add(this.lblDuracao);
            this.Controls.Add(this.txtDuracao);
            this.Controls.Add(this.lblQntsVezes);
            this.Controls.Add(this.txtQntdVezes);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblModalidade);
            this.Name = "FormCadastroDePlanos";
            this.Text = "Cadastrar Planos";
            this.Load += new System.EventHandler(this.FormCadastroDePlanos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroPlanos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblModalidade;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblQntsVezes;
        private System.Windows.Forms.TextBox txtQntdVezes;
        private System.Windows.Forms.Label lblDuracao;
        private System.Windows.Forms.TextBox txtDuracao;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDesativar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView dgvCadastroPlanos;
        private System.Windows.Forms.ComboBox cmbModalidade;
    }
}

namespace WinFormsPresentationLayer
{
    partial class FormCadastroDeModalidades
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
            this.txtNomeModalidade = new System.Windows.Forms.TextBox();
            this.lblDescricaoModalidade = new System.Windows.Forms.Label();
            this.txtDescricaoModalidade = new System.Windows.Forms.TextBox();
            this.lblNomeModalidade = new System.Windows.Forms.Label();
            this.dgvCadastroModalidades = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroModalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeModalidade
            // 
            this.txtNomeModalidade.BackColor = System.Drawing.SystemColors.Window;
            this.txtNomeModalidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeModalidade.Location = new System.Drawing.Point(27, 41);
            this.txtNomeModalidade.Name = "txtNomeModalidade";
            this.txtNomeModalidade.Size = new System.Drawing.Size(190, 20);
            this.txtNomeModalidade.TabIndex = 55;
            // 
            // lblDescricaoModalidade
            // 
            this.lblDescricaoModalidade.AutoSize = true;
            this.lblDescricaoModalidade.BackColor = System.Drawing.Color.Transparent;
            this.lblDescricaoModalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoModalidade.ForeColor = System.Drawing.Color.Black;
            this.lblDescricaoModalidade.Location = new System.Drawing.Point(234, 20);
            this.lblDescricaoModalidade.Name = "lblDescricaoModalidade";
            this.lblDescricaoModalidade.Size = new System.Drawing.Size(156, 18);
            this.lblDescricaoModalidade.TabIndex = 53;
            this.lblDescricaoModalidade.Text = "Descrição Modalidade";
            // 
            // txtDescricaoModalidade
            // 
            this.txtDescricaoModalidade.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescricaoModalidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricaoModalidade.Location = new System.Drawing.Point(237, 41);
            this.txtDescricaoModalidade.Name = "txtDescricaoModalidade";
            this.txtDescricaoModalidade.Size = new System.Drawing.Size(204, 20);
            this.txtDescricaoModalidade.TabIndex = 52;
            // 
            // lblNomeModalidade
            // 
            this.lblNomeModalidade.AutoSize = true;
            this.lblNomeModalidade.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeModalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeModalidade.ForeColor = System.Drawing.Color.Black;
            this.lblNomeModalidade.Location = new System.Drawing.Point(25, 20);
            this.lblNomeModalidade.Name = "lblNomeModalidade";
            this.lblNomeModalidade.Size = new System.Drawing.Size(129, 18);
            this.lblNomeModalidade.TabIndex = 54;
            this.lblNomeModalidade.Text = "Nome Modalidade";
            // 
            // dgvCadastroModalidades
            // 
            this.dgvCadastroModalidades.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dgvCadastroModalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadastroModalidades.Location = new System.Drawing.Point(28, 77);
            this.dgvCadastroModalidades.Name = "dgvCadastroModalidades";
            this.dgvCadastroModalidades.Size = new System.Drawing.Size(413, 209);
            this.dgvCadastroModalidades.TabIndex = 59;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditar.Location = new System.Drawing.Point(346, 301);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(95, 34);
            this.btnEditar.TabIndex = 63;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExcluir.Location = new System.Drawing.Point(247, 301);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(93, 34);
            this.btnExcluir.TabIndex = 62;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAtualizar.Location = new System.Drawing.Point(139, 301);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(102, 34);
            this.btnAtualizar.TabIndex = 61;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCadastrar.Location = new System.Drawing.Point(28, 301);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(105, 34);
            this.btnCadastrar.TabIndex = 60;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // FormCadastroDeModalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 359);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dgvCadastroModalidades);
            this.Controls.Add(this.txtNomeModalidade);
            this.Controls.Add(this.lblDescricaoModalidade);
            this.Controls.Add(this.txtDescricaoModalidade);
            this.Controls.Add(this.lblNomeModalidade);
            this.Name = "FormCadastroDeModalidades";
            this.Text = "Cadastrar Modalidades";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroModalidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeModalidade;
        private System.Windows.Forms.Label lblDescricaoModalidade;
        private System.Windows.Forms.TextBox txtDescricaoModalidade;
        private System.Windows.Forms.Label lblNomeModalidade;
        private System.Windows.Forms.DataGridView dgvCadastroModalidades;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnCadastrar;
    }
}
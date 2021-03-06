
namespace WinFormsPresentationLayer
{
    partial class FormCadastroDeClientes
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
            this.dtpDataMatricula = new System.Windows.Forms.DateTimePicker();
            this.lblDataMatricula = new System.Windows.Forms.Label();
            this.lblTelefoneFixo = new System.Windows.Forms.Label();
            this.txtTelefoneFixo = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.txtTelefoneCelular = new System.Windows.Forms.TextBox();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblTelefoneCelular = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dgvCadastroClientes = new System.Windows.Forms.DataGridView();
            this.lblRG = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDataMatricula
            // 
            this.dtpDataMatricula.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataMatricula.Location = new System.Drawing.Point(178, 227);
            this.dtpDataMatricula.Name = "dtpDataMatricula";
            this.dtpDataMatricula.Size = new System.Drawing.Size(119, 20);
            this.dtpDataMatricula.TabIndex = 48;
            // 
            // lblDataMatricula
            // 
            this.lblDataMatricula.AutoSize = true;
            this.lblDataMatricula.BackColor = System.Drawing.Color.Transparent;
            this.lblDataMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataMatricula.ForeColor = System.Drawing.Color.Black;
            this.lblDataMatricula.Location = new System.Drawing.Point(175, 206);
            this.lblDataMatricula.Name = "lblDataMatricula";
            this.lblDataMatricula.Size = new System.Drawing.Size(103, 18);
            this.lblDataMatricula.TabIndex = 49;
            this.lblDataMatricula.Text = "Data Matrícula";
            // 
            // lblTelefoneFixo
            // 
            this.lblTelefoneFixo.AutoSize = true;
            this.lblTelefoneFixo.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefoneFixo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneFixo.ForeColor = System.Drawing.Color.Black;
            this.lblTelefoneFixo.Location = new System.Drawing.Point(245, 256);
            this.lblTelefoneFixo.Name = "lblTelefoneFixo";
            this.lblTelefoneFixo.Size = new System.Drawing.Size(97, 18);
            this.lblTelefoneFixo.TabIndex = 43;
            this.lblTelefoneFixo.Text = "Telefone Fixo";
            // 
            // txtTelefoneFixo
            // 
            this.txtTelefoneFixo.Location = new System.Drawing.Point(248, 277);
            this.txtTelefoneFixo.Name = "txtTelefoneFixo";
            this.txtTelefoneFixo.Size = new System.Drawing.Size(213, 20);
            this.txtTelefoneFixo.TabIndex = 42;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(37, 98);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 18);
            this.lblNome.TabIndex = 39;
            this.lblNome.Text = "Nome";
            // 
            // cmbGenero
            // 
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outros"});
            this.cmbGenero.Location = new System.Drawing.Point(307, 225);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(154, 21);
            this.cmbGenero.TabIndex = 38;
            // 
            // txtTelefoneCelular
            // 
            this.txtTelefoneCelular.Location = new System.Drawing.Point(40, 277);
            this.txtTelefoneCelular.Name = "txtTelefoneCelular";
            this.txtTelefoneCelular.Size = new System.Drawing.Size(202, 20);
            this.txtTelefoneCelular.TabIndex = 46;
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.BackColor = System.Drawing.Color.Transparent;
            this.lblDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascimento.ForeColor = System.Drawing.Color.Black;
            this.lblDataNascimento.Location = new System.Drawing.Point(37, 204);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(123, 18);
            this.lblDataNascimento.TabIndex = 44;
            this.lblDataNascimento.Text = "Data Nascimento";
            // 
            // lblTelefoneCelular
            // 
            this.lblTelefoneCelular.AutoSize = true;
            this.lblTelefoneCelular.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefoneCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneCelular.ForeColor = System.Drawing.Color.Black;
            this.lblTelefoneCelular.Location = new System.Drawing.Point(37, 256);
            this.lblTelefoneCelular.Name = "lblTelefoneCelular";
            this.lblTelefoneCelular.Size = new System.Drawing.Size(115, 18);
            this.lblTelefoneCelular.TabIndex = 47;
            this.lblTelefoneCelular.Text = "Telefone Celular";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(38, 153);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 18);
            this.lblEmail.TabIndex = 41;
            this.lblEmail.Text = "E-mail";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Window;
            this.txtNome.Location = new System.Drawing.Point(40, 121);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(256, 20);
            this.txtNome.TabIndex = 34;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(40, 175);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(257, 20);
            this.txtEmail.TabIndex = 36;
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(40, 227);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(132, 20);
            this.dtpDataNascimento.TabIndex = 37;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.BackColor = System.Drawing.Color.Transparent;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.ForeColor = System.Drawing.Color.Black;
            this.lblCPF.Location = new System.Drawing.Point(304, 100);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(38, 18);
            this.lblCPF.TabIndex = 40;
            this.lblCPF.Text = "CPF";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.BackColor = System.Drawing.Color.Transparent;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.ForeColor = System.Drawing.Color.Black;
            this.lblGenero.Location = new System.Drawing.Point(304, 204);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(58, 18);
            this.lblGenero.TabIndex = 45;
            this.lblGenero.Text = "Gênero";
            // 
            // txtCPF
            // 
            this.txtCPF.BackColor = System.Drawing.SystemColors.Window;
            this.txtCPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCPF.Location = new System.Drawing.Point(307, 121);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(154, 20);
            this.txtCPF.TabIndex = 35;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(358, 323);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(103, 34);
            this.btnEditar.TabIndex = 53;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(259, 323);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(93, 34);
            this.btnExcluir.TabIndex = 52;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.Location = new System.Drawing.Point(151, 323);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(102, 34);
            this.btnAtualizar.TabIndex = 51;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(40, 324);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(105, 34);
            this.btnCadastrar.TabIndex = 50;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dgvCadastroClientes
            // 
            this.dgvCadastroClientes.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dgvCadastroClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadastroClientes.Location = new System.Drawing.Point(519, 121);
            this.dgvCadastroClientes.Name = "dgvCadastroClientes";
            this.dgvCadastroClientes.Size = new System.Drawing.Size(254, 237);
            this.dgvCadastroClientes.TabIndex = 59;
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.BackColor = System.Drawing.Color.Transparent;
            this.lblRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRG.ForeColor = System.Drawing.Color.Black;
            this.lblRG.Location = new System.Drawing.Point(304, 153);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(31, 18);
            this.lblRG.TabIndex = 61;
            this.lblRG.Text = "RG";
            // 
            // txtRG
            // 
            this.txtRG.BackColor = System.Drawing.SystemColors.Window;
            this.txtRG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRG.Location = new System.Drawing.Point(307, 176);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(154, 20);
            this.txtRG.TabIndex = 60;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.Color.Black;
            this.lblMensagem.Location = new System.Drawing.Point(93, 22);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(615, 30);
            this.lblMensagem.TabIndex = 62;
            this.lblMensagem.Text = "Preencha todos os campos corretamente para cadastrar o cliente";
            // 
            // FormCadastroDeClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(957, 491);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.lblRG);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.dgvCadastroClientes);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dtpDataMatricula);
            this.Controls.Add(this.lblDataMatricula);
            this.Controls.Add(this.lblTelefoneFixo);
            this.Controls.Add(this.txtTelefoneFixo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.txtTelefoneCelular);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.lblTelefoneCelular);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.dtpDataNascimento);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.txtCPF);
            this.Name = "FormCadastroDeClientes";
            this.Text = "Cadastrar Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDataMatricula;
        private System.Windows.Forms.Label lblDataMatricula;
        private System.Windows.Forms.Label lblTelefoneFixo;
        private System.Windows.Forms.TextBox txtTelefoneFixo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.TextBox txtTelefoneCelular;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblTelefoneCelular;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView dgvCadastroClientes;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.Label lblMensagem;
    }
}
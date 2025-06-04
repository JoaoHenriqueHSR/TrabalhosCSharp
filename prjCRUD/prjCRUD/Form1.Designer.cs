namespace prjCRUD
{
    partial class frmCadastroContato
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtCelular = new TextBox();
            lblNome = new Label();
            lblEmail = new Label();
            lblCelular = new Label();
            btnInserir = new Button();
            btnAtualizar = new Button();
            btnExcluir = new Button();
            btnLimpar = new Button();
            dgvContatos = new DataGridView();
            lblID = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvContatos).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.HotTrack;
            lblTitulo.Location = new Point(256, 29);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(269, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Cadastro de contatos";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(160, 153);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(202, 23);
            txtNome.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(160, 211);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(202, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(160, 269);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(202, 23);
            txtCelular.TabIndex = 3;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(48, 156);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(48, 214);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email:";
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.Location = new Point(48, 272);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(44, 15);
            lblCelular.TabIndex = 6;
            lblCelular.Text = "Celular";
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(48, 367);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 7;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(151, 367);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 8;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(254, 367);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 9;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(357, 367);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 10;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // dgvContatos
            // 
            dgvContatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContatos.Location = new Point(512, 118);
            dgvContatos.Name = "dgvContatos";
            dgvContatos.Size = new Size(240, 150);
            dgvContatos.TabIndex = 11;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(54, 98);
            lblID.Name = "lblID";
            lblID.Size = new Size(18, 15);
            lblID.TabIndex = 12;
            lblID.Text = "ID";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(160, 95);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(202, 23);
            textBox1.TabIndex = 13;
            // 
            // frmCadastroContato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 419);
            Controls.Add(textBox1);
            Controls.Add(lblID);
            Controls.Add(dgvContatos);
            Controls.Add(btnLimpar);
            Controls.Add(btnExcluir);
            Controls.Add(btnAtualizar);
            Controls.Add(btnInserir);
            Controls.Add(lblCelular);
            Controls.Add(lblEmail);
            Controls.Add(lblNome);
            Controls.Add(txtCelular);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(lblTitulo);
            Name = "frmCadastroContato";
            Text = "Tela Cadastro de Contato";
            ((System.ComponentModel.ISupportInitialize)dgvContatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtCelular;
        private Label lblNome;
        private Label lblEmail;
        private Label lblCelular;
        private Button btnInserir;
        private Button btnAtualizar;
        private Button btnExcluir;
        private Button btnLimpar;
        private DataGridView dgvContatos;
        private Label lblID;
        private TextBox textBox1;
    }
}

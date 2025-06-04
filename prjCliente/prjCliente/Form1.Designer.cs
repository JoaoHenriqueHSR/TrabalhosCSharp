namespace prjCliente
{
    partial class frmCadastrarClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarClientes));
            bntCadastrar = new Button();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtCelular = new TextBox();
            lblNome = new Label();
            lblEmail = new Label();
            lblCelular = new Label();
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // bntCadastrar
            // 
            bntCadastrar.Location = new Point(239, 349);
            bntCadastrar.Name = "bntCadastrar";
            bntCadastrar.Size = new Size(75, 23);
            bntCadastrar.TabIndex = 0;
            bntCadastrar.Text = "Cadastrar";
            bntCadastrar.UseVisualStyleBackColor = true;
            bntCadastrar.Click += bntCadastrar_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(214, 174);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(214, 229);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(214, 284);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(100, 23);
            txtCelular.TabIndex = 3;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(141, 174);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(141, 233);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email";
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.Location = new Point(141, 292);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(47, 15);
            lblCelular.TabIndex = 6;
            lblCelular.Text = "Celular:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(121, 79);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(213, 37);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "Cadastro Cliente";
            // 
            // frmCadastrarClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 450);
            Controls.Add(lblTitulo);
            Controls.Add(lblCelular);
            Controls.Add(lblEmail);
            Controls.Add(lblNome);
            Controls.Add(txtCelular);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(bntCadastrar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCadastrarClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Clientes";
            FormClosing += frmCadastrarClientes_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bntCadastrar;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtCelular;
        private Label lblNome;
        private Label lblEmail;
        private Label lblCelular;
        private Label lblTitulo;
    }
}

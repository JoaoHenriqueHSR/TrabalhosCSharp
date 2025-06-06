using prjCliente.Models;

namespace prjCliente
{
    public partial class frmCadastrarClientes : Form
    {
        Cliente Cliente = new Cliente();
        public frmCadastrarClientes()
        {
            InitializeComponent();
        }

        private void bntCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Preencha o campo \"Nome\".", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNome.Focus();
                return;
            }
            if(string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Preencha o campo \"Email\".", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEmail.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCelular.Text))
            {
                MessageBox.Show("Preencha o campo \"Celular\".", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCelular.Focus();
                return;
            }

            if (!Cliente.emailValido(txtEmail.Text))
            {
                MessageBox.Show("O email informado é inválido.", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEmail.Focus();
                return;
            }


            Cliente.Cli_name = txtNome.Text;
            Cliente.Cli_email = txtEmail.Text;
            Cliente.Cli_celular = txtCelular.Text;
            MessageBox.Show($"Cliente cadastrado com sucesso!\nNome: {Cliente.Cli_name}\nEmail: {Cliente.Cli_email}\nCelular: {Cliente.Cli_celular}", "Sucesso!");
        }

        private void frmCadastrarClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}

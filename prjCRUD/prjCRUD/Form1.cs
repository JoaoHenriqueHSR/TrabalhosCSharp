using MySql.Data.MySqlClient;

namespace prjCRUD
{
    public partial class frmCadastroContato : Form
    {
        public frmCadastroContato()
        {
            InitializeComponent();
        }

        private void frmCadastroContato_Load(object sender, EventArgs e)
        {
            try
            {
                const string servidor = "localhost";
                const string bancoDados = "bdContato";
                const string usuario = "root";
                const string senha = "aluno";

                string conexaoBanco = 
                    $"server={servidor};" + 
                    $"user id={usuario};" + 
                    $"database={bancoDados};" + 
                    $"password={senha};";

                using (MySqlConnection conexao=new MySqlConnection(conexaoBanco))
                {
                    conexao.Open();
                    conexao.Close();

                    lblTeste.Text = $"A conexão com {bancoDados} foi realizada com sucesso!";
                }
            }
            catch(MySqlException ex)
            {
                lblTeste.Text= "Falha na conexão";
                MessageBox.Show("Erro ao conectar ao banco de dados"+ ex.Message);
            }
            catch (Exception ex)
            {
                lblTeste.Text = "Erro desconhecido";
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }
    }
}

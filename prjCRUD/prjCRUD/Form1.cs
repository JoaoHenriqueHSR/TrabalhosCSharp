using MySql.Data.MySqlClient;

namespace prjCRUD
{
    public partial class frmCadastroContato : Form
    {
        public frmCadastroContato()
        {
            InitializeComponent();
            CarregarContatos();
        }

        const string servidor = "localhost";
        const string bancoDados = "bdContato";
        const string usuario = "root";
        const string senha = "aluno";

        string conexaoBanco =
            $"server={servidor};" +
            $"user id={usuario};" +
            $"database={bancoDados};" +
            $"password={senha};";

        private void frmCadastroContato_Load(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(conexaoBanco))
                {
                    conexao.Open();
                    conexao.Close();

                    lblTeste.Text = $"A conexão com {bancoDados} foi realizada com sucesso!";
                }
            }
            catch (MySqlException ex)
            {
                lblTeste.Text = "Falha na conexão";
                MessageBox.Show("Erro ao conectar ao banco de dados" + ex.Message);
            }
            catch (Exception ex)
            {
                lblTeste.Text = "Erro desconhecido";
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            // 1. Obter os dados das TextBoxes  
            string nome = txtNome.Text.Trim();
            string celular = txtCelular.Text.Trim();
            string email = txtEmail.Text.Trim();

            // 2. Validar se os campos obrigatórios estão preenchidos  
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(celular) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Por favor, preencha todos os campos para inserir um novo contato.", "Campos Obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Criar a consulta SQL INSERT  
            string query = "INSERT INTO Contato (ContatoNome, ContatoCelular, ContatoEmail) VALUES (@Nome, @Celular, @Email)";

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(conexaoBanco))
                {
                    conexao.Open();

                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@Nome", nome);
                        comando.Parameters.AddWithValue("@Celular", celular);
                        comando.Parameters.AddWithValue("@Email", email);

                        int resultado = comando.ExecuteNonQuery();

                        if (resultado > 0)
                        {
                            MessageBox.Show("Contato inserido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CarregarContatos(); // Atualiza DataGridView  
                            LimparCampos(); // Limpa os campos para uma nova inserção  
                        }
                        else
                        {
                            MessageBox.Show("Nenhum contato foi inserido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao inserir contato no banco: " + ex.Message, "Erro no Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarContatos()
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(conexaoBanco))
                {
                    conexao.Open();
                    string query = "SELECT Contatoid, ContatoNome, ContatoCelular, ContatoEmail FROM Contato";

                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    using (MySqlDataAdapter adaptador = new MySqlDataAdapter(comando))
                    {
                        System.Data.DataTable tabela = new System.Data.DataTable();
                        adaptador.Fill(tabela);
                        dgvContatos.DataSource = tabela;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            {
                // 1. Obter os dados das TextBoxes
                string id = txtId.Text.Trim();
                string nome = txtNome.Text.Trim();
                string celular = txtCelular.Text.Trim();
                string email = txtEmail.Text.Trim();

                // 2. Validar se os campos obrigatórios estão preenchidos
                if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(celular) || string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Por favor, preencha todos os campos para editar um contato.", "Campos Obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 3. Criar a consulta SQL UPDATE
                string query = "UPDATE Contato SET ContatoNome = @Nome, ContatoCelular = @Celular, ContatoEmail = @Email WHERE Contatoid = @Id";

                try
                {
                    using (MySqlConnection conexao = new MySqlConnection(conexaoBanco))
                    {
                        conexao.Open();

                        using (MySqlCommand comando = new MySqlCommand(query, conexao))
                        {
                            comando.Parameters.AddWithValue("@Id", id);
                            comando.Parameters.AddWithValue("@Nome", nome);
                            comando.Parameters.AddWithValue("@Celular", celular);
                            comando.Parameters.AddWithValue("@Email", email);

                            int resultado = comando.ExecuteNonQuery();

                            if (resultado > 0)
                            {
                                MessageBox.Show("Contato atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CarregarContatos(); // Atualiza DataGridView
                                LimparCampos(); // Limpa os campos para uma nova edição
                            }
                            else
                            {
                                MessageBox.Show("Nenhum contato foi atualizado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao atualizar contato no banco: " + ex.Message, "Erro no Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // 1. Obter o ID do contato a ser excluído
            string id = txtId.Text.Trim();

            // 2. Validar se um ID foi informado
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Por favor, selecione um contato para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Confirmar a exclusão
            DialogResult confirmacao = MessageBox.Show("Tem certeza que deseja excluir este contato?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacao == DialogResult.No)
                return;

            // 4. Criar a consulta SQL DELETE
            string query = "DELETE FROM Contato WHERE Contatoid = @Id";

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(conexaoBanco))
                {
                    conexao.Open();

                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@Id", id);

                        int resultado = comando.ExecuteNonQuery();

                        if (resultado > 0)
                        {
                            MessageBox.Show("Contato excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CarregarContatos(); // Atualiza o DataGridView
                            LimparCampos(); // Limpa os campos
                        }
                        else
                        {
                            MessageBox.Show("Nenhum contato encontrado para exclusão.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao excluir contato do banco: " + ex.Message, "Erro no Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para limpar os campos de entrada  
        private void LimparCampos()
        {
            txtNome.Text = "";
            txtCelular.Text = "";
            txtEmail.Text = "";
            txtId.Text = "";
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void dgvContatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica se uma linha foi clicada
            {
                DataGridViewRow linhaSelecionada = dgvContatos.Rows[e.RowIndex];

                txtId.Text = linhaSelecionada.Cells["Contatoid"].Value.ToString();
                txtNome.Text = linhaSelecionada.Cells["ContatoNome"].Value.ToString();
                txtCelular.Text = linhaSelecionada.Cells["ContatoCelular"].Value.ToString();
                txtEmail.Text = linhaSelecionada.Cells["ContatoEmail"].Value.ToString();
            }

        }
    }
}

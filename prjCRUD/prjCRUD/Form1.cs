using System.Text.RegularExpressions;
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
        const string senha = "12345";

        string conexaoBanco = $"server={servidor}; user id={usuario}; database={bancoDados}; password={senha};";

        private void frmCadastroContato_Load(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(conexaoBanco))// aqui � instanciado um objeto do tipo MySlqConnection, tendo como parametro a variavel com os dados atribuidos anteriomente using(){} nesse contexto, cria um escopo de execu��o da conex�o com MySql e quando terminado, ele se livra desse espa�o na memoria, executando automaticamente o metodo Dispose(), que fecha a conex�o com o banco de dados, liberando os recursos utilizados por ele.
                {
                    conexao.Open();
                    conexao.Close();

                    lblTeste.Text = $"A conex�o com {bancoDados} foi realizada com sucesso!";
                    lblTeste.ForeColor = Color.Green;
                }
            }
            catch (MySqlException ex)
            {
                lblTeste.Text = "Falha na conex�o";
                MessageBox.Show("Erro ao conectar ao banco de dados" + ex.Message);
                lblTeste.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                lblTeste.Text = "Erro desconhecido";
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
                lblTeste.ForeColor = Color.Red;
            }
        }//ESTABELECE A CONEC��O COM O BANCO DE DADOS E CARREGA OS CONTATOS

        private void btnInserir_Click(object sender, EventArgs e)//INSERE OS VALORES NO BANCO DE DADOS
        {
            // 1. Obter os dados das TextBoxes  
            string nome = txtNome.Text.Trim();
            string celular = txtCelular.Text.Trim();
            string email = txtEmail.Text.Trim();

            // 2. Validar se os campos obrigat�rios est�o preenchidos  
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(celular) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Por favor, preencha todos os campos para inserir um novo contato.", "Campos Obrigat�rios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Regex emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase);

            bool isEmail=emailRegex.IsMatch(email);

            if (!isEmail) { 
                MessageBox.Show("Por favor, insira um email v�lido.", "Email Inv�lido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Criar a consulta SQL INSERT  
            string query = "INSERT INTO Contato (ContatoNome, ContatoCelular, ContatoEmail) VALUES (@Nome, @Celular, @Email)";

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(conexaoBanco))
                {
                    conexao.Open();

                    using (MySqlCommand comando = new MySqlCommand(query, conexao))//MySqlCommand precisa de dois parametros, o primeiro � a instru��o sql, e o segundo � para onde enviar essa instru��o
                    {
                        // Adiciona os par�metros com os valores das TextBoxes
                        comando.Parameters.AddWithValue("@Nome", nome);
                        comando.Parameters.AddWithValue("@Celular", celular);
                        comando.Parameters.AddWithValue("@Email", email);

                        // Executa a consulta e obt�m o n�mero de linhas afetadas
                        int resultado = comando.ExecuteNonQuery();//parecido com os metodos de requisi��o de api, retornando o numero de linhas afetada, se for 0 ou menor, n�o foi inserido nada no banco de dados

                        if (resultado > 0)
                        {
                            MessageBox.Show($"Contato inserido com sucesso!\nLinhas criadas: {resultado}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CarregarContatos(); // Atualiza DataGridView  
                            LimparCampos(); // Limpa os campos para uma nova inser��o  
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
                    int limite;
                    int.TryParse(txtLimite.Text.Trim(), out limite);

                    limite = limite <= 0 ? 5 : limite;
                    string query = $"SELECT * FROM Contato LIMIT {limite}";

                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        using (MySqlDataAdapter adaptador = new MySqlDataAdapter(comando))
                        {
                            System.Data.DataTable tabela = new System.Data.DataTable();
                            adaptador.Fill(tabela);
                            dgvContatos.DataSource = tabela;
                        }
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

                // 2. Validar se os campos obrigat�rios est�o preenchidos
                if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(celular) || string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Por favor, preencha todos os campos para editar um contato.", "Campos Obrigat�rios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                                MessageBox.Show($"Contato atualizado com sucesso!\nLinhas alteradas: {resultado}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CarregarContatos(); // Atualiza DataGridView
                                LimparCampos(); // Limpa os campos para uma nova edi��o
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
            // 1. Obter o ID do contato a ser exclu�do
            string id = txtId.Text.Trim();

            // 2. Validar se um ID foi informado
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Por favor, selecione um contato para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Confirmar a exclus�o
            DialogResult confirmacao = MessageBox.Show($"Tem certeza que deseja excluir o contato {id}?", "Confirma��o", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacao == DialogResult.No) return;

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
                            MessageBox.Show($"Contato exclu�do com sucesso!\nLinhas excluidas: {resultado}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CarregarContatos(); // Atualiza o DataGridView
                            LimparCampos(); // Limpa os campos
                        }
                        else
                        {
                            MessageBox.Show("Nenhum contato encontrado para exclus�o.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao excluir contato do banco: " + ex.Message, "Erro no Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // M�todo para limpar os campos de entrada  
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

        private void btnRecarregar_Click(object sender, EventArgs e)
        {
            CarregarContatos();
        }

        private void frmCadastroContato_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja realmente fechar o programa?", "Confirma��o", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}

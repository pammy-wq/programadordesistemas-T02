using MySql.Data.MySqlClient;

namespace CadastroCliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtTelefone.Text == "" ||
                txtCPF.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            // Validação CPF
            if (!txtCPF.Text.All(char.IsDigit) || txtCPF.Text.Length != 11)
            {
                MessageBox.Show("CPF inválido!");
                return;
            }

            // Validação telefone
            if (txtTelefone.Text.Length < 10)
            {
                MessageBox.Show("Telefone inválido!");
                return;
            }

            // Validação email
            if (!txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Email inválido!");
                return;
            }

            string conexao = "server=localhost;database=projeto_luck_games;uid=root;pwd=;";

            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                string sql = "INSERT INTO clientes(nome, telefone, CPF) " +
             "VALUES(@nome, @telefone, @CPF)";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                    cmd.Parameters.AddWithValue("@CPF", txtCPF.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Cliente cadastrado com sucesso!");
                }
            }
        }
    }
}
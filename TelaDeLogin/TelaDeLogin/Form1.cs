using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Drawing.Drawing2D;

namespace TelaDeLogin
{
    public partial class frmLogin : Form
    {
        //aqui eu declarei as variáveis para o email e senha corretos, além de um contador de tentativas e o limite de tentativas
        //usei string para armazenar o email e senha corretos, e int para contar as tentativas e definir o limite

        string emailCorreto = "usuario@email.com";
        string senhaCorreta = "senha123";
        int tentativas = 0;
        int maxTentativas = 3;

        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string senha = txtSenha.Text;

            while (tentativas < maxTentativas)
            {
                if (email == emailCorreto && senha == senhaCorreta)
                {
                    MessageBox.Show("Login bem-sucedido!");
                    break;
                }
                else
                {
                    tentativas++;
                    MessageBox.Show("Senha incorreta. Tentativas restantes: " + (maxTentativas - tentativas));
                    break;
                }
            }

            if (tentativas == maxTentativas)
            {
                MessageBox.Show("Conta bloqueada por excesso de tentativas.");
                btnLogin.Enabled = false;
            }
        }

        //aqui eu criei um evento para o carregamento do formulário, onde eu uso a classe GraphicsPath para criar um caminho gráfico que define a forma do botão de login
        //a deixando com cantos arredondados. O método AddArc é usado para adicionar arcos aos cantos do botão, e o método CloseAllFigures é chamado para fechar o caminho gráfico.
        //Por fim, a propriedade Region do botão é definida com a nova região criada, aplicando a forma arredondada ao botão.
        private void frmLogin_Load(object sender, EventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            int radius = 30;

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btnLogin.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btnLogin.Width - radius, btnLogin.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btnLogin.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            btnLogin.Region = new Region(path);
        }
    }
    }



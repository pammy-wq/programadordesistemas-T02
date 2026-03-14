using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace picturebox
{
    public partial class frmPictureBox : Form
    {
<<<<<<< HEAD
        private string imagemLocalizada;
        
=======

        private string imagemLocalizada;

>>>>>>> upstream/main
        public frmPictureBox()
        {
            InitializeComponent();
        }

        private void btnVerImagem_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            pbCidade.Image = Image.FromFile(@"C:\Users\pamela.olemos\Downloads\saopaulo.jpg"); ///aqui esta chamando a imgem / ou seja ela vai vir de algum lugar do meu computador, quando apérta o botão ela vai vir
            pbCidade.SizeMode = PictureBoxSizeMode.StretchImage; // aqui a gente fez manualmente o sizemode porém tambem dá pra preparar via forms
=======
            pbCidade.Image = Image.FromFile(@"C:\Users\ana.cscunha1\Downloads\saopaulo.jpg");
            pbCidade.SizeMode = PictureBoxSizeMode.StretchImage;
>>>>>>> upstream/main
        }

        private void btnAnexar_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            try //aqui ele executa
            {
                //caixa de dialogo para abrir arquivo
=======
            try
            {
                //caixa de diálogo para abrir arquivo
>>>>>>> upstream/main
                OpenFileDialog abrirarquivo = new OpenFileDialog();
                abrirarquivo.Filter = "jpg files (*.jpg)|*.jpg|PNG files (*.png)|*.png|All files (*.*)|*.*";

                if (abrirarquivo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imagemLocalizada = abrirarquivo.FileName;

                    pbAnexarImagem.ImageLocation = imagemLocalizada;

                }
            }
<<<<<<< HEAD
            catch (Exception) // aqui ele excuta uma inseção
            {
                MessageBox.Show("ocorreu um erro", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
=======
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
>>>>>>> upstream/main
            }
        }
    }
}

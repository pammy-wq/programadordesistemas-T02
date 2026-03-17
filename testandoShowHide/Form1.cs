using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testandoShowHide
{
    public partial class frmShowHide : Form
    {
        public frmShowHide()
        {
            InitializeComponent();
            pbLogoTipo.Visible = false;
        }

        private void btnMostrarLogo_Click(object sender, EventArgs e)
        {
            if (pbLogoTipo.Visible) //aqui se ele estiver visivel, ele vai esconder a logo
            {
                pbLogoTipo.Hide();
                btnMostrarLogo.Text = "Mostrar Logo";
            }
            else // aqui se não estiver visivel ele vai mostrar o logo quando clicar no botão a mesma coisa do if
            {
                pbLogoTipo.Show();
                btnMostrarLogo.Text = "Enconder Logo";
            }
        }

        private void pbLogoTipo_Click(object sender, EventArgs e)
        {
            frmHome form = new frmHome();
            form.Show();
            this.Hide();
        }
    }
}

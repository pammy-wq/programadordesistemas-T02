using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pesoideal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         

        private void CalcularPeso()
        {
            if (string.IsNullOrWhiteSpace(txtAltura.Text))
            {
                lblCalcularPeso.Text = "";
                return;
            }

            double altura;

            if (!double.TryParse(txtAltura.Text, out altura) || altura <= 0)
            {
                lblCalcularPeso.Text = "";
                return;
            }

            double pesoIdeal;
            string generoSelecionado;

            if (rbMasculino.Checked)
            {
                pesoIdeal = (72.7 * altura) - 58;
                generoSelecionado = "Masculino";
            }
            else // Feminino já vem selecionado
            {
                pesoIdeal = (62.1 * altura) - 44.7;
                generoSelecionado = "Feminino";
            }

            lblAlturaTitulo.Text = "Altura: " + altura.ToString("F2") + " m";
            lblTituloGenero.Text = "Gênero: " + generoSelecionado;
            lblCalcularPeso.Text = "Peso Ideal: " + pesoIdeal.ToString("F2") + " kg";
        }

        private void rbFeminino_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFeminino.Checked)
            {
                CalcularPeso();
            }
        }

        private void rbMasculino_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMasculino.Checked)
            {
                CalcularPeso();
            }
        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {
            CalcularPeso();
        }
    }
 }

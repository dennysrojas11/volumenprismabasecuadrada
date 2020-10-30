using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppVolumenPrisma
{
    public partial class Form1 : Form
    {
        private TextBox[] textboxs;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxAltura.Focus();
            labelResultado.Visible = false;
        }

        private void textBoxAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.validar(e);
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                textBoxLado.Focus();
            }
            
        }

        private void textBoxLado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                buttonCalcular.Focus();
            }
            Validar.validar(e);
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            textboxs = new TextBox[] { textBoxLado, textBoxAltura };
            bool datosCorrectos = !textboxs.Any(X => String.IsNullOrEmpty(X.Text));

            if (datosCorrectos)
            {
                Volumen v = new Volumen(double.Parse(textBoxAltura.Text), double.Parse(textBoxLado.Text));
                labelResultado.Text = v.calcular().ToString();
                labelResultado.Visible = true; 
            }
            else
            {
                MessageBox.Show("Complete todos los campos", "Datos faltantes", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

       
    }
}
